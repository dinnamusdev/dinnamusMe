using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml;
using System.Windows.Forms;
using System.IO;

namespace DinnamusMe
{
    class IniciarApp
    {
        private static String cMsgErro;

        private static frmCarga carga = new frmCarga();
        static public String MsgErro
        {
            get { return cMsgErro; }
            private set { cMsgErro = value; }
        }
        static public Boolean ForcarImportacaoBase() 
        {
            bool bRetorno = false;


            //if(MessageBox.Show("Deseja fazer a limpeza do base ?","Sincronismo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1 );                
            if (!LimparBaseOff())
            {
                MsgErro = "Não foi possível limpar a base offline - ForcarImportacaoBase";
                bRetorno = false;
            }

            if (ImportarDados())
            {
                bRetorno = true;
            }
            return bRetorno;


        }
        static public bool Iniciar() 
        {
            DataSet ds;
            bool bRetorno = false;
            if (!DAO.Iniciar())
            {
                MessageBox.Show("Não foi possível iniciar a conexão com o banco " + DAO.MsgErro);                
            }
            else
            {
                
               ds = VerificarDadosSinc();
               if (ds.Tables[0].Rows.Count > 0)
               {
                   DateTime dtUltimoSinc = DateTime.Parse(ds.Tables[0].Rows[0]["UltimoSincronismo"].ToString());
                   MessageBox.Show("Ultimo sinc. feito em :" + dtUltimoSinc.ToString("dd/MM/yyyy"),"DinnamuS ME",MessageBoxButtons.OK,MessageBoxIcon.Exclamation ,MessageBoxDefaultButton.Button1 );
                   bRetorno = true;
               }
               else
               {
                   if (LimparBaseOff())
                   {
                       if (CriarPastaApp())
                       {
                           if (VerificarExistenciaArquivosSinc())
                               bRetorno = ImportarDados();
                           else
                           {
                               MessageBox.Show("Arquivos de sinc. não localizados. Carregue-os na pasta [sincronismo]","DinnamuS ME",MessageBoxButtons.OK ,MessageBoxIcon.Exclamation ,MessageBoxDefaultButton.Button1 );                              
                           }
                       }
                       else
                       {
                           MessageBox.Show("Não foi possível criar as pasta do app");
                       }
                   }
                   else
                       MessageBox.Show("Não foi possível limpar a base off");
               }                
            }

            return bRetorno;
        }
        static private DataSet VerificarDadosSinc()
        {
            DataSet ds = null;

            try
            {
                ds = DAO.getDataSet("select * from Sincronismo order by id desc");
                
            }
            catch (Exception ex)
            {

                MsgErro = ex.Message + " - VerificarDadosSinc";
 
            }
            return ds;
            
        }
        static private bool CriarPastaApp()
        {
            bool bRetorno = false;
            try
            {
                
                if (Directory.GetDirectories(Util.PastaAtual() +"\\" ,"sincronismo").Length == 0)
                    Directory.CreateDirectory(Util.PastaAtual()  + "\\sincronismo");


                if (Directory.GetDirectories(Util.PastaAtual() + "\\", "inventarios").Length == 0)
                    Directory.CreateDirectory(Util.PastaAtual() + "\\inventarios");  

                bRetorno = true;
            }
            catch (Exception ex) 
            {

                MsgErro = ex.Message + " - CriarPastaApp"; 
                
            }
            return bRetorno;
        }
        static private DataSet LerArquivoXML(String cNomeArquivo) 
        {
            String cNomeArquivoCompleto = Util.PastaAtual() + "\\" + cNomeArquivo;

            DataSet ds = new DataSet();
            try
            {               
                ds.ReadXml(cNomeArquivoCompleto);
            }
            catch (Exception ex)
            {

                MsgErro = ex.Message + " - LerArquivoXML";
                ds = null;
            }
            
            
            return ds;           
            
        }
        
        static private Boolean ImportarDados()
        {

            Boolean bRetorno = false;
            //DAO.IniciarTransacao();
            carga = new frmCarga();
            carga.Show();
            if (ImportarDadosAcao())
            {
              //  DAO.ConfirmarTransacao();
                bRetorno = true;
            }
            else 
            {
               //DAO.DesfazerTransacao();
            }
            carga.Dispose();
            return bRetorno;
            
        }
        static private Boolean LimparBaseOff() 
        {
            Boolean bRetorno=false;
            try
            {
                DAO.IniciarTransacao();
                if (DAO.ExecutarSQL("delete from filial;", true))
                    if (DAO.ExecutarSQL("delete from lojas;", true))
                        if (DAO.ExecutarSQL("delete from usuario;",true))
                            if (DAO.ExecutarSQL("delete from cadproduto;", true))
                                if (DAO.ExecutarSQL("delete from itensgradeproduto;", true))
                                    if (DAO.ExecutarSQL("delete from itensgradeproduto_busca_extra;", true))
                                    {
                                        bRetorno = true;
                                    }
                
                if (bRetorno)
                {
                   DAO.ConfirmarTransacao();
                }
                else
                {
                   DAO.DesfazerTransacao();
                   bRetorno =false;
                }                
               
            }
            catch (Exception ex)
            {

                MsgErro = ex.Message + " - LimparBaseOff";
            }
            return bRetorno;
        }
        static private bool RegistrarSincronismo() 
        {
            Boolean bRetorno = false;
            String cStringSQL = "insert into sincronismo (ultimosincronismo) values ('" + DateTime.Now.ToString("MM/dd/yy") + "')";
            try 
	        {
                if (DAO.ExecutarSQL(cStringSQL,false))
                    bRetorno= true;
                
	        }
	        catch (Exception ex) 
	        {
                MsgErro = ex.Message + " - RegistrarSincronismo";
		        
	        }
            return bRetorno;


        }
        public static int ContarLinha(String cArquivo, String cTextoPesquisa)
        {
            String cRetorno = "";
            String cTextoAPesquisar = "";
            int nLinhas = 0;


            try
            {
                ManipularArquivos ma = new ManipularArquivos();

                if (ma.AbrirArquivo(cArquivo))
                {
                    String cDadosArquivo = "";
                    while (!ma.StreamArquivo.EndOfStream)
                    {
                        cDadosArquivo = ma.StreamArquivo.ReadLine();
                        if (cDadosArquivo != null)
                        {
                            cTextoAPesquisar = cDadosArquivo.Substring(0, cTextoPesquisa.Length);

                            if (cTextoAPesquisar == cTextoPesquisa)
                            {
                                nLinhas++;
                            }

                        }
                    }
                }
                ma.FecharStream();
            }
            catch (Exception ex)
            {
                nLinhas = -1;
            }
            return nLinhas;
        }

        static private bool ProcessarArquivo(String cNomeArquivo)
        {

            Boolean bRetorno = true;
            String cLinha="";
            String cPrimeiraParteInsert = "";
            String StringSQL="";
            
            
            try
            {
                Application.DoEvents();
                carga.lblTexto.Text  = cNomeArquivo;

                carga.barra.Minimum = 1;
                carga.barra.Maximum = ContarLinha(cNomeArquivo + ".din","");
                ManipularArquivos ma = new ManipularArquivos(cNomeArquivo + ".din");
                int nLinha = 0;  
                while (!ma.FimDoArquivo()) 
                {

                    Application.DoEvents();
                    nLinha =nLinha +1;
                    carga.barra.Value = nLinha;
                    cLinha = ma.LerLinha();
                    
                    if (cPrimeiraParteInsert=="")
                        cPrimeiraParteInsert = cLinha.Replace(";","") ;
                    else
                    {
                        StringSQL = "insert into " + cNomeArquivo.Replace("sincronismo\\","") + " " + cPrimeiraParteInsert + " " + cLinha;
                        carga.lblSQL.Text  = StringSQL;
                        Console.Out.Write(StringSQL); 

                        if (!DAO.ExecutarSQL(StringSQL,false))
                        {
                            bRetorno = false;
                            break;
                        }       
                    }
                }
                ma.FecharStream();

            }
            catch (Exception ex)
            {

                MsgErro = ex.Message+ " - ProcessarArquivo";
                bRetorno = false;
            }


            return bRetorno;
        }
        static private Boolean ImportarDadosAcao()
        {
            Boolean bRetorno = false;
            
            if (ProcessarArquivo("sincronismo\\usuario"))
                if (ProcessarArquivo("sincronismo\\cadproduto"))
                    if (ProcessarArquivo("sincronismo\\itensgradeproduto"))
                        if (ProcessarArquivo("sincronismo\\itensgradeproduto_busca_extra"))
                            if (ProcessarArquivo("sincronismo\\filial"))
                                if (ProcessarArquivo("sincronismo\\lojas"))
                                    if(RegistrarSincronismo())
                                        bRetorno = true;
            return bRetorno;
        }
        static private Boolean VerificarExistenciaArquivosSinc() 
        {
            bool bRetorn = false;
            try
            {
                if (Directory.GetFiles(Util.PastaAtual() +"\\sincronismo\\","*.din").Length >0)
                {
                    bRetorn = true;
                }

            }
            catch (Exception ex)

            {

                MsgErro = ex.Message + " - VerificarExistenciaArquivosSinc"; 
            }
            return bRetorn;
        }
    }
}
