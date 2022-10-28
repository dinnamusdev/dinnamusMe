using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DinnamusMe
{
    class Conferencia
    {
        public static DAOServidor DAOServidorContagem = null;
        static private Dictionary<String, String> dcCamposBusca = new Dictionary<string, string>();

        private static Dictionary<String, String> DcCamposBusca
        {
            get
            {

                if (dcCamposBusca.Count == 0)
                {
                    dcCamposBusca.Add("Codigo Barra Forn.", "ig.codbarraforn");
                    dcCamposBusca.Add("Codigo Barra Int.", "ig.codbarraint");
                    dcCamposBusca.Add("Referencia", "ig.referencia");
                    dcCamposBusca.Add("Codigo Seq.", "cp.codigo");
                }
                return Conferencia.dcCamposBusca;
            }
            set { Conferencia.dcCamposBusca = value; }
        }
        public static bool IncluirItem(Int32 nCodigoConferencia,Int32 nIG_Chaveunica, String cCodigoBarra, String cDescricao, Decimal nQuantidade, Decimal Preco,int nFilial, int nLoja, String cTipo) {
            bool bRet = false;
            try
            {
                Decimal Total=0;
                //MessageBox.Show("Teste 6");
                DataSet dsPreco = DAOServidorContagem.getDataSet("select top 1 precovenda from itenstabelapreco where codigoproduto=" + nIG_Chaveunica ) ;
                if (dsPreco.Tables[0].Rows.Count > 0) {
                    try
                    {
                        //MessageBox.Show("Teste 7");
                        Preco = Decimal.Parse(dsPreco.Tables[0].Rows[0]["precovenda"].ToString());
                    }
                    catch (Exception)
                    {
                        
                        
                    }
                    
                }
                //MessageBox.Show("Teste 8");
                Total = Decimal.Round( Preco*nQuantidade,2);
                int nIdUnico = 0;
                String cSQL = "";
                if (cTipo=="Transferencia")
                {
                    //nIdUnico = DAOServidorContagem.GerarSequenciaTabela("itensmovtrans", nLoja);
                    cSQL = "insert into itensmovtrans(codigo,codprod,descricao,quantidade,preco,total,ref) values " +
                    "("  + nCodigoConferencia + "," + nIG_Chaveunica + ",'" + cDescricao + "'," + nQuantidade.ToString().Replace(",", ".") + "," + Preco.ToString().Replace(",", ".") + "," + Total.ToString().Replace(",", ".") + ",'" + cCodigoBarra + "')";
                }
                else
                {
                    nIdUnico = DAOServidorContagem.GerarSequenciaTabela("itensped", nLoja);
                    cSQL = "insert into itensped(idunico,codigo,codprod,descricao,quantidade,preco,total,ref) values " +
                    "(" + nIdUnico + "," + nCodigoConferencia + "," + nIG_Chaveunica + ",'" + cDescricao + "'," + nQuantidade.ToString().Replace(",", ".") + "," + Preco.ToString().Replace(",", ".") + "," + Total.ToString().Replace(",", ".") + ",'" + cCodigoBarra + "')";
                }
                //int nIdUnico= DAOServidorContagem.GerarSequenciaTabela("itensped",nLoja);
                //String cSQL = "insert into itensped(idunico,codigo,codprod,descricao,quantidade,preco,total,ref) values "+
                //"(" + nIdUnico + "," + nCodigoConferencia + "," + nIG_Chaveunica + ",'" + cDescricao + "'," + nQuantidade.ToString().Replace(",", ".") + "," + Preco.ToString().Replace(",", ".") + "," + Total.ToString().Replace(",", ".") + ",'"+ cCodigoBarra +"')";
                bRet = DAOServidorContagem.ExecutarSQL(cSQL,false);
                if (!bRet)
                {
                    MessageBox.Show(DAOServidorContagem.MsgErro);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                
            }
            return bRet;
        }
        public static bool ExcluirItemConferido(int nCodigoConferencia, int nIdUnico, String cTipo) {
            try
            {
                if (cTipo == "Transferencia")
                {
                    return DAOServidorContagem.ExecutarSQL("delete from itensmovtrans where codigo=" + nCodigoConferencia + " and chaveunica=" + nIdUnico, false);
                }
                else
                {
                    return DAOServidorContagem.ExecutarSQL("delete from itensped where codigo=" + nCodigoConferencia + " and idunico=" + nIdUnico, false);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        
        }
        public static DataSet ListarItensConferidos(int nCodigoConferencia)
        {
            DataSet ds = null;
            try
            {
                ds = DAOServidorContagem.getDataSet("select i.idunico id,i.codigo,i.quantidade as qt,i.ref as codigobarra,i.descricao from itensped i " +
                                        "where i.codigo=" + nCodigoConferencia + " order by i.idunico desc", "ITENSCONF");

                if (ds == null)
                {
                    MessageBox.Show(DAOServidorContagem.MsgErro);
                }

            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return ds;

        }

        public static DataSet ListarItensTransferidos(int nCodigoConferencia)
        {
            DataSet ds = null;
            try
            {
                ds = DAOServidorContagem.getDataSet("select i.chaveunica id,i.codigo,i.quantidade as qt,i.ref as codigobarra,i.descricao from itensmovtrans i " +
                                        "where i.codigo=" + nCodigoConferencia + " order by i.chaveunica desc", "ITENSCONF");
                if (ds==null)
                {
                    MessageBox.Show(DAOServidorContagem.MsgErro);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return ds;

        }

        public static Int32 ContarItensConferidos(int nCodigoConferencia, String cTipo)
        {
            int nTotal = 0;
            try
            {
                String cRet = "";
                DataSet ds =null;
                if (cTipo == "Transferencia")
                {
                    ds = DAOServidorContagem.getDataSet("select sum(i.quantidade) as qt from itensmovtrans i " +
                                         "where i.codigo=" + nCodigoConferencia, "itensconf");
                }
                else
                {
                    ds = DAOServidorContagem.getDataSet("select sum(i.quantidade) as qt from itensped i " +
                                            "where i.codigo=" + nCodigoConferencia, "itensconf");
                }

                if (ds == null)
                {
                    MessageBox.Show(DAOServidorContagem.MsgErro);
                }

                if (ds.Tables[0].Rows.Count >0)
                {
                    cRet = ds.Tables[0].Rows[0]["qt"].ToString();
                    if (!cRet.ToLower().Equals(""))
                    {                        
                        nTotal = Decimal.ToInt32(Decimal.Parse(cRet));    
                    }                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return nTotal;
        }
        public static DataSet ListarConferencias() {
            return ListarConferencias(0);            
        }

        public static DataSet ListarConferencias(int nCodigoConf) {
            DataSet ds = null;
            try
            {

                ds=DAOServidorContagem.getDataSet("select codigo ,vendedor resp,data,loja,filial from dadosped where feito='N' and recebido='N' and nomemov='CONFERENCIA'" + ( nCodigoConf>0 ? " and codigo="+nCodigoConf : "" ), "CONF");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return ds;
            
        }

        public static DataSet ListarTransferencias() {
            return ListarTransferencias(0);
        }
        public static DataSet ListarTransferencias(int nCodigoConf)
        {
            DataSet ds = null;
            try
            {

                ds = DAOServidorContagem.getDataSet("select codigo ,resposavel,Loja, lojadestino Filial, LocalEstoqueDestino Destino  from dadostransf where feito='C' " + (nCodigoConf > 0 ? " and codigo=" + nCodigoConf : ""), "CONF");
                if (ds==null)
                {
                    MessageBox.Show(DAOServidorContagem.MsgErro);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return ds;

        }
       
        public static bool IncluirConferencia(int nLoja, int nFilial, DateTime cData, String cCodigoUsuario, String cNomeUsuario)
        {

            try
            {

                int nCodigoConferencia = DAOServidorContagem.GerarSequenciaTabela("dadosped", nLoja);
                String cSQL = "insert into dadosped(codigo,loja,filial,data,codvendedor,vendedor,feito,recebido,dataprevdevol,nomemov,codcliente,cliente) values" +
                    "(" + nCodigoConferencia + "," + nLoja + "," + nFilial + ",'" + cData.ToString("MM/dd/yyyy") + "','" + cCodigoUsuario + "','" + cNomeUsuario + "','N','N','" + cData.ToString("MM/dd/yyyy") + "','CONFERENCIA','0','** Fornecedor **')";
                
                return DAOServidorContagem.ExecutarSQL(cSQL, false);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
        public static bool IncluirTransferencia(int nLoja, int nLocalEstoqueOrigem, int nLojaDestino ,DateTime cData, String cNomeUsuario)
        {

            try
            {

                //int nCodigoTransf = DAOServidorContagem.GerarSequenciaTabela("dadostransf", nLoja);
                String cSQL = "insert into dadostransf(loja,lojadestino,LocalEstoqueDestino,data,resposavel,feito) values" +
                    "(" + nLoja + "," + nLocalEstoqueOrigem + "," + nLojaDestino + ",'" + cData.ToString("MM/dd/yyyy") + "','" + cNomeUsuario + "','C')";

                if (DAOServidorContagem.ExecutarSQL(cSQL, false))
                {
                    return true;
                }
                else {
                    MessageBox.Show(DAOServidorContagem.MsgErro);
                    return false;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }

        }
 

 
        public static DataSet PesquisarProduto(String cCodigo, String cCampoBusca)
        {
            DataSet ds = null;
            try
            {
                cCampoBusca = DcCamposBusca[cCampoBusca];

                ds = DAOServidorContagem.getDataSet("select cp.nome,ig.chaveunica,cp.chaveunica cp_chaveunica, cp.precodecompra preco from cadproduto cp inner join itensgradeproduto ig on ig.codigo=cp.chaveunica where " + cCampoBusca + "='" + cCodigo + "'");
            

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            return ds;
            
        }
             
     
    }
}
