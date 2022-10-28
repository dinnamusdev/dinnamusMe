using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DinnamusMe
{
    class Inventario
    {
        static private Dictionary<String, String> dcCamposBusca = new Dictionary<string, string>();

        private static Dictionary<String, String> DcCamposBusca
        {
            get {

                if (dcCamposBusca.Count == 0) 
                {
                    dcCamposBusca.Add("Codigo Barra Forn.","ig.codbarraforn");
                    dcCamposBusca.Add("Codigo Barra Int.","ig.codbarraint");
                    dcCamposBusca.Add("Referencia","ig.referencia");
                    dcCamposBusca.Add("Codigo Seq.","cp.codigo");
                }
                return Inventario.dcCamposBusca; 
            }
            set { Inventario.dcCamposBusca = value; }
        }
        /*
        static private void AtualizarOrdemBusca(String cCampos)
        {

            try
            {
                dcCamposBusca.Clear();
                char[] charSeparators = new char[] { ';' };

                String[] cCampos = cCampos.Text.Split(charSeparators);

                cbOpcaoBusca.Items.Clear();
                for (int i = 0; i < cCampos.Length; i++)
                {

                    cbOpcaoBusca.Items.Add(cCampos[i]);
                }
            }
            catch (Exception ex)
            {

                MsgErro = ex.Message ;
            }

        }*/
        static private String cMsgErro = "";
        static private DataSet dsProdutos;

        public static DataSet DsProdutos
        {
            get { return Inventario.dsProdutos; }
            private set { Inventario.dsProdutos = value; }
        }
        static public String MsgErro
        {
            get { return cMsgErro; }
            set { cMsgErro = value; }
        }
        
        
        public static Int32 ObterNumeroUltimoInventario() 
        {
            String cStringSQL = "";
            Int32  nUltimoInventario=0;
            String cRetorno;
            cStringSQL ="select max(codigo) from dadosinvent";
        
            try 
	        {
                cRetorno = DAO.ExecuteEscalar(cStringSQL).ToString() ;
                if (cRetorno.Length > 0)
                {
                    nUltimoInventario = Int32.Parse(cRetorno);
                }
        		
	        }
	        catch (Exception ex)
	        {
        		MsgErro = ex.Message;
		        
	        }
            return nUltimoInventario;
        }

        public static DataSet PesquisarItem(DAOServidor daoserv, String cCodigo, String cCampoBusca)
        {
            
            DataSet ds=null;

            try 
	        {
                cCampoBusca = DcCamposBusca[cCampoBusca];

                //MessageBox.Show("Alterado");

                //MessageBox.Show(cCampoBusca + "='" + cCodigo + "'");

 
                ds = daoserv.getDataSet("select cp.nome,ig.chaveunica,cp.chaveunica cp_chaveunica from cadproduto cp inner join itensgradeproduto ig on ig.codigo=cp.chaveunica where " + cCampoBusca + "='" + cCodigo + "'");
                        		
	        }
	        catch (Exception ex)
	        {
        		
		        MsgErro = ex.Message ;
	        }
            return ds;
        }
        public static DataSet PesquisarItem_Local(String cCodigo, String cCampoBusca)
        {

            DataSet ds = null;

            try
            {
                cCampoBusca = DcCamposBusca[cCampoBusca];

                //MessageBox.Show("Alterado");

                //MessageBox.Show(cCampoBusca + "='" + cCodigo + "'");


                ds = DAO.getDataSet("select cp.nome,ig.chaveunica,cp.chaveunica cp_chaveunica from cadproduto cp inner join itensgradeproduto ig on ig.codigo=cp.chaveunica where " + cCampoBusca + "='" + cCodigo + "'");

            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }
            return ds;
        }
        public static bool AtualizarEstoqueReal(DAOServidor daoInventario, int nCodigoInventario, Int32 nIG_Chaveunica, decimal nQuantidade, int nLoja, int nFilial, Int32 nCP_Chaveunica)
        {
            bool bRet = false;

            try
            {

                if(daoInventario.IniciarTransacao()){
                    if (AtualizarEstoqueReal_Acao(daoInventario, nCodigoInventario, nCP_Chaveunica,nIG_Chaveunica, nQuantidade, nLoja, nFilial))
                    {
                        bRet= daoInventario.ConfirmarTransacao();
                    }else
                    {
                        daoInventario.DesfazerTransacao();
                    }                     
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            return bRet;
        }
        public static bool AtualizarEstoqueReal_BloquearVendaProdZerado(DAOServidor daoInventario,  Int32 nCP_Chaveunica, bool bStatus )
        {
            try
            {
                return daoInventario.ExecutarSQL("update cadproduto set bloquearnegativo=" + ( bStatus ? "1" : "0" )  +  " where chaveunica=" + nCP_Chaveunica,true );
                               
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
                 return false;
            }
        }
        public static bool AtualizarEstoqueReal_Acao(DAOServidor daoInventario, int nCodigoInventario, Int32 nCP_Chaveunica, Int32 nIG_Chaveunica, decimal nQuantidade, int nLoja, int nFilial)
        {
            bool bRet = false;

            try
            {
                bool bPrimeiraLeitura = false;
                //MessageBox.Show("teste 1");
                DataSet dsProcurarProdutoNosInventario = DAO.getDataSet("select codigo from itensinvent where codigo=" + nIG_Chaveunica);
                if (dsProcurarProdutoNosInventario.Tables[0].Rows.Count==0)
                {
                  // primeira contagem do produto - ZERA ESTOQUE ATUAL
                    decimal  nSaldoAtual = AtualizarEstoqueReal_SaldoAtual(daoInventario, nIG_Chaveunica, nLoja, nFilial);
                    //MessageBox.Show("teste 2");
                    
                    if(!AtualizarEstoqueReal_BloquearVendaProdZerado(daoInventario,nCP_Chaveunica,true )){
                        return false;
                    }
                    /*if (nSaldoAtual<0)
                    {
                        if (!AtualizarEstoqueReal_GerarMovimentacao(daoInventario, nCodigoInventario, nLoja,nFilial  ,nIG_Chaveunica, nSaldoAtual * -1, "E"))
                        {
                            return false;
                        }
                    }
                    else if(nSaldoAtual>0)
                    {
                        if (!AtualizarEstoqueReal_GerarMovimentacao(daoInventario, nCodigoInventario, nLoja, nFilial ,nIG_Chaveunica, nSaldoAtual, "S"))
                        {
                            return false;
                        }
                    }*/
                    bPrimeiraLeitura = true;
                    
                }

                if (!AtualizarEstoqueReal_AtualizarSaldo(daoInventario, nCodigoInventario, nLoja, nFilial, nIG_Chaveunica, nQuantidade, bPrimeiraLeitura ))
                {
                    return false;
                }
                /*
                if (!AtualizarEstoqueReal_GerarMovimentacao(daoInventario, nCodigoInventario, nLoja,nFilial, nIG_Chaveunica, nQuantidade , "E"))
                {
                    return false;
                }*/
                bRet = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            return bRet;
        }        
        public static decimal AtualizarEstoqueReal_SaldoAtual(DAOServidor daoInventario, Int32 nIG_Chaveunica,  int nLoja, int nFilial)
        {
            decimal nSaldo = 0;

            try
            {
             
                DataSet dsDadosProdutos = daoInventario.getDataSet("select estoque from estoquefilial where codigoproduto ="+  nIG_Chaveunica  +"  and codigoloja="+ nLoja  +" and codigofilial=" + nFilial );
                if (dsDadosProdutos.Tables[0].Rows.Count>0)
                {
                    nSaldo = decimal.Parse(dsDadosProdutos.Tables[0].Rows[0]["estoque"].ToString());
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            return nSaldo;
        }

        public static bool AtualizarEstoqueReal_AtualizarSaldo(DAOServidor daoInventario , int nCodigoInventario,int nLoja, int nFilial ,Int32 nIG_Chaveunica, decimal nQuantidade, bool bSubstituirEstoque) {
            bool bRet = false;
            
            try
            {
                //MessageBox.Show("teste 3");
                String cSQL = "update estoquefilial set estoque=" + (!bSubstituirEstoque ? " isnull(estoque,0)+ " :"") + nQuantidade + " where codigoproduto="+ nIG_Chaveunica  +" and codigoloja="+ nLoja  +" and codigofilial=" + nFilial ;

                if (daoInventario.ExecutarSQL(cSQL,true))
                {
                    bRet = true;
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            return bRet;
        }
        public static bool AtualizarEstoqueReal_GerarMovimentacao(DAOServidor daoInventario , int nCodigoInventario,int nLoja, int nFilial,Int32 nIG_Chaveunica, decimal nQuantidade, String cTipoMovInventario) {
            bool bRet = false;
            
            try
            {
                String cCodMov="",cNomeMov="",cTipoMov="";
                if(cTipoMovInventario=="S"){
                    cCodMov="8" ; cNomeMov="Ajuste do Inventario - (Saida)" ; cTipoMov="S";
                }else
                {
                    cCodMov="7" ; cNomeMov="Ajuste do Inventario - (Entrada)" ; cTipoMov="E";                                    
                }

                int nCodigoDadosMoviEstoque = daoInventario.GerarSequenciaTabela("dadosmoviestoque", nLoja);
                String cSQL = "insert into dadosmoviestoque(codigo,feito,codmov,tipomov,nomemov,loja,data,codigoinventario,codigofilial) values " +
                    "(" + nCodigoDadosMoviEstoque + ", 'S', '" + cCodMov + "','" + cTipoMov + "','" + cNomeMov + "'," + nLoja + ", '" + DateTime.Today.ToString("MM/dd/yyyy") + "', " + nCodigoInventario + "," + nFilial + ")";
                if (daoInventario.ExecutarSQL(cSQL,true))
                {
            		 String cSQLItem = "insert into ItensMovEstoque (CHAVEUNICA,codigo,codprod,codmov,nomemov,tipomov,data,quantidade,loja) values " +
                         "("+ daoInventario.GerarSequenciaTabela("itensmovestoque", nLoja) +","+ nCodigoDadosMoviEstoque  +","+ nIG_Chaveunica  +",'"+ cCodMov  +"','"+ cNomeMov  +"','"+ cTipoMov  +"','"+ DateTime.Today.ToString("MM/dd/yyyy") +"',"+ nQuantidade  +","+ nLoja  +")" ;

                     if (daoInventario.ExecutarSQL(cSQLItem,true)){
                        bRet=true;
                     }
                }                                   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            return bRet;
        }
        public static bool IncluirItem(Int32 nCodigoInventario, Int32 nCP_Chaveunica,Int32 nIG_Chaveunica, String cCodigoBarra, String cDescricao, Decimal nQuantidade, int nFilial, int nLoja, int nTipoInventario,DAOServidor daoInventario)
        {
            bool bRetorno = false;
            try
            {
                //MessageBox.Show("teste " + nTipoInventario.ToString());
                if (nTipoInventario==0)
                {
                    //MessageBox.Show("teste 0");
                    if (!AtualizarEstoqueReal(daoInventario, nCodigoInventario, nIG_Chaveunica, nQuantidade, nLoja, nFilial, nCP_Chaveunica))
                    {
                        MessageBox.Show("Não foi possível ajustar o estoque atual","Inventario");
                        return false;
                    }

                }
                

                DAO.IniciarTransacao();

                bRetorno = IncluirItem_Acao(nCodigoInventario, nIG_Chaveunica, cCodigoBarra, cDescricao, nQuantidade);
                
                if(bRetorno)
                {
                    if(DAO.ConfirmarTransacao())
                    {
                        bRetorno =true;
                    }
                    else 
                        MsgErro=DAO.MsgErro;  
                }
                else
                    DAO.DesfazerTransacao();

            }
            catch (Exception ex)
            {

                MsgErro = DAO.MsgErro;
            }


            return bRetorno;
        }
        public static bool  IncluirItem_Acao(Int32 nCodigoInventario, Int32 nIG_Chaveunica, String cCodigoBarra,String cDescricao,Decimal nQuantidade )
        {
            bool bRetorno=false;
            String cStringSQL ="";
            
            try 
	        {               
                cStringSQL = "insert into itensinvent(codigoinventario,codigo,qt,codigobarra,descricao) values " +
                    "(" + nCodigoInventario + "," + nIG_Chaveunica + "," + nQuantidade + ",'" + cCodigoBarra + "','" + cDescricao + "')";

                if (DAO.ExecutarSQL(cStringSQL, true))                        
                        bRetorno = true;                    
               
	        }
	        catch (Exception ex)
	        {
        		MsgErro = ex.Message ;
		        
	        }

            return bRetorno;
        }
        
        public static Boolean Abrir(Int32 nFilial, DateTime dtInicio, String cResponsavel, Int32  nLoja , Int32 nTipoInventario, String ipservidor, String usuario, String senha, String banco) 
        {
            Boolean bRetorno = false;
            String cStringSQL="insert into dadosinvent(Loja,datainicio,responsavel,filial,tipoinventario,ipservidor,usuario,senha,banco) values " +
                    "(" + nLoja + ",'" + dtInicio.ToString("MM/dd/yyyy") + "','" + cResponsavel + "'," + nFilial + "," + nTipoInventario + ",'"+ ipservidor +"','"+ usuario +"','"+ senha +"','"+ banco +"')";
            try
            {
                    
                if (DAO.ExecutarSQL(cStringSQL,false))
                {
                    bRetorno = true;
                }


            }
            catch (Exception ex)
            {
                MsgErro = ex.Message;
               
            }
            return bRetorno;
        }
        public static bool ExcluirItemInventario_ServidorRemoto(DAOServidor daoinventario, int nCodigoInventario, Int32 nIDItem, int nLoja, int nFilial, Int32 nCP_Chaveunica ) {
            bool bRet = false;
            if (daoinventario.IniciarTransacao())
            {
                if (ExcluirItemInventario_ServidorRemoto_Acao(daoinventario, nCodigoInventario, nIDItem, nLoja, nFilial, nCP_Chaveunica))
                {
                    bRet = daoinventario.ConfirmarTransacao();
                }else
	            {
                    daoinventario.DesfazerTransacao();
	            }
            }
            return bRet;
        }
        public static bool ExcluirItemInventario_ServidorRemoto_Acao(DAOServidor daoinventario, int nCodigoInventario,Int32 nIDItem, int nLoja, int nFilial, Int32 nCP_Chaveunica)
        {
            bool bRetorno = false;

            try
            {
                DataSet dsItem = DAO.getDataSet("select codigo,qt from itensinvent where id=" + nIDItem);
                if (dsItem.Tables[0].Rows.Count>0)
                {
                    Int32 nCodigoItem = Int32.Parse(dsItem.Tables[0].Rows[0]["codigo"].ToString());

                    decimal nQtItem = decimal.Parse(dsItem.Tables[0].Rows[0]["qt"].ToString());

                    decimal nSaldoAtual = AtualizarEstoqueReal_SaldoAtual(daoinventario, nCodigoItem, nLoja, nFilial);

                    decimal nNovoSaldo = nSaldoAtual - nQtItem;
                    if (nNovoSaldo == 0) {
                        if (!AtualizarEstoqueReal_BloquearVendaProdZerado(daoinventario, nCP_Chaveunica, true)) {
                            return false;
                        }
                    } 
                        

                    /*if (!AtualizarEstoqueReal_GerarMovimentacao(daoinventario, nCodigoInventario, nLoja, nFilial, nCodigoItem, nQtItem, "E"))
                    {
                        return false;
                    }*/
                    if (!AtualizarEstoqueReal_AtualizarSaldo(daoinventario, nCodigoInventario, nLoja, nFilial, nCodigoItem, nNovoSaldo, true)) {
                        return false;
                    }
                    bRetorno = true;
                }
            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }

            return bRetorno;
        }
        public static bool ExcluirItemInventario(Int32 nIDItem,int nTipoInventario ,DAOServidor daoinventario, int nCodigoInventario, int nLoja, int nFilial) 
        {
            bool bRetorno = false;

            try
            {
                if (nTipoInventario==0)
	            {
                    if (!ExcluirItemInventario_ServidorRemoto(daoinventario, nCodigoInventario, nIDItem, nLoja, nFilial,0)) {
                        return false;
                    }
	            }
                
                if (DAO.ExecutarSQL("delete from itensinvent where id=" + nIDItem,false)) 
                {
                    bRetorno = true;
                }

            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }

            return bRetorno;
        }

        public static DataSet ListarItensInventario(Int32 nNumeroInventario, int UltimaChaveLida, int TamanhoPagina) 
        {
            DataSet ds=null;
            try
            {


                ds = DAO.getDataSet("select i.id,i.codigo,i.qt,i.codigobarra,i.descricao from itensinvent i " +                                         
                                        "where i.codigoinventario=" + nNumeroInventario + " order by id desc" ,"itensinvent");
               

            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }
            return ds;
        }

        public static DataSet DadosInventario(Int32 nNumeroInventario)
        {
            DataSet ds = null;
            try
            {
                ds = DAO.getDataSet("select d.* from dadosinvent d " +
                                        "where d.codigo=" + nNumeroInventario , "itensinvent");

            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }
            return ds;
        }

        public static bool ReabrirContagemInventario(Int32 nNumeroInventario)
        {

            bool bRetorno = false;
            try
            {
                bRetorno = DAO.ExecutarSQL("update dadosinvent set feito=null where codigo=" + nNumeroInventario, false);

            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }
            return bRetorno;

        }
        public static bool FecharContagemInventario(Int32 nNumeroInventario)
        {

            bool bRetorno = false;
            try
            {
                bRetorno  = DAO.ExecutarSQL("update dadosinvent set feito='S' where codigo="+  nNumeroInventario,false);

            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }
            return bRetorno;
        
        }
        public static Int32 TotalContado(Int32 nNumeroInventario)
        {
            Int32 nTotalContado = 0;
            Object cRetorno=null;
            try
            {
                cRetorno = DAO.ExecuteEscalar("select sum(qt) from itensinvent i " +
                                        "where i.codigoinventario=" + nNumeroInventario);

                nTotalContado = Int32.Parse(cRetorno.ToString() );

            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }
            return nTotalContado;
        }
        public static bool GravarArquivosInventarioPC(Int32 nCodigoInventario)
        {
            bool bRetorno = true;
            String cLinha = "";
            String cNomeArquivo = "";
            DataSet ds=null;
            CriarArquivo caArquivo=null;
            try
            {
                caArquivo = new CriarArquivo(Util.PastaAtual() + "\\inventarios\\dadosinvent" + nCodigoInventario.ToString() + ".din");  

                ds = DAO.getDataSet("select codigo,loja,datainicio,responsavel,filial from dadosinvent where codigo=" + nCodigoInventario);
                for (Int32 i = 0; i < ds.Tables[0].Rows.Count; i++) 
                {
                    cLinha = ds.Tables[0].Rows[i]["codigo"].ToString() + ";" + ds.Tables[0].Rows[i]["loja"].ToString() + ";"
                        + ds.Tables[0].Rows[i]["datainicio"].ToString() + ";" + ds.Tables[0].Rows[i]["responsavel"].ToString() + ";" +
                        ds.Tables[0].Rows[i]["filial"].ToString() + ";";
                    if (!caArquivo.GravarLinha(cLinha))
                    {
                        bRetorno = false;
                        break; 
                    }
                }
                caArquivo.FecharArquivo();
                if (bRetorno)
                {                    
                    caArquivo = new CriarArquivo(Util.PastaAtual() + "\\inventarios\\itensinvent" + nCodigoInventario.ToString() + ".din");
                    ds = DAO.getDataSet("select codigoinventario,codigo,qt,codigobarra,descricao from itensinvent where codigoinventario=" + nCodigoInventario);
                    for (Int32 i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        cLinha = ds.Tables[0].Rows[i]["codigoinventario"].ToString() + ";" + ds.Tables[0].Rows[i]["codigo"].ToString() + ";"
                            + ds.Tables[0].Rows[i]["qt"].ToString() + ";" + ds.Tables[0].Rows[i]["codigobarra"].ToString() + ";" +
                            ds.Tables[0].Rows[i]["descricao"].ToString() + ";";
                        if (!caArquivo.GravarLinha(cLinha))
                        {
                            bRetorno = false;
                            break;
                        }
                    }
                    caArquivo.FecharArquivo();
                

                }

            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }

            return bRetorno;            
        }
        public static bool ExcluirInventario(int nInventario) 
        {
            bool bRetorno = false;
            try
            {

                DAO.IniciarTransacao();

                if (ExcluirInventario_Acao(nInventario))
                {
                    DAO.ConfirmarTransacao();
                    bRetorno = true;
                }
                else
                    DAO.DesfazerTransacao();

            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }
            return bRetorno;
        }
        private  static bool ExcluirInventario_Acao(int nInventario)
        {
            bool bRetorno = false;
            try
            {

                if (DAO.ExecutarSQL("delete from dadosinvent where codigo=" + nInventario,true )) 
                {
                    if (DAO.ExecutarSQL("delete from itensinvent where codigoinventario=" + nInventario,true))
                        bRetorno = true;
                }

                
            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }
            return bRetorno;
        }

    }
}
