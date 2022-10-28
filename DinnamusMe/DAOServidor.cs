using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DinnamusMe
{
    class DAOServidor
    {
        private SqlTransaction trx;
        private SqlConnection cn=null;
        private SqlDataAdapter adp = new SqlDataAdapter();
        private SqlCommand cmd = null;
        

        public String cMsgErro = "";
        public bool Iniciar(int nCodigoInventario)
        {
            String servidor = "", usuario = "", senha = "", banco = "";
            bool bRet = false;
            DataSet dsDadosInventario = DAO.getDataSet("select ipservidor,usuario,senha,banco from dadosinvent where codigo=" + nCodigoInventario);
            String cStringCNX = "";
            if (dsDadosInventario.Tables[0].Rows.Count>0)
            {
                //String servidor="", usuario="", senha="", banco="";

                servidor = dsDadosInventario.Tables[0].Rows[0]["ipservidor"].ToString();
                usuario= dsDadosInventario.Tables[0].Rows[0]["usuario"].ToString();
                senha= dsDadosInventario.Tables[0].Rows[0]["senha"].ToString();
                banco= dsDadosInventario.Tables[0].Rows[0]["banco"].ToString();
                cStringCNX="Data Source="+ servidor +";Initial Catalog="+  banco +";User ID="+ usuario +";Password="+ senha +";";
                
            }
            //String cStringCNX= Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\principal.sdf";
 
            try
            {
                cn = new SqlConnection(cStringCNX);
                
                cn.Open();
                
                bRet = true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(servidor +  " - " + banco +" - " + e.Message);
                CapturarMsgErro(e);  
            }           	                  
     
            return bRet;

        }

        public bool Iniciar(String servidor , String usuario , String senha , String banco)
        {

            bool bRet = false;
        
            String cStringCNX = "";
        
            try
            {

                cStringCNX = "Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha + ";";

                cn = new SqlConnection(cStringCNX);

                cn.Open();

                bRet = true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                CapturarMsgErro(e);
            }

            return bRet;

        }
        public String MsgErro
        {
            get { return cMsgErro; }
            private set { cMsgErro = value; }
        }
        public void Fechar() 
        {
            adp = null;
            cmd = null;
            trx = null;
            cn.Close();
            cn.Dispose();            
            cn = null;

        }
        private void CapturarMsgErro(SqlException e)
        {
            
            MsgErro = "";
            foreach (SqlError error in e.Errors)
            {
                MsgErro += error.Message + " ";
            }
        
        }
        public Boolean IniciarTransacao()
        {
            Boolean bRetorno = false;
            try
            {
                trx = cn.BeginTransaction();

                bRetorno = true;
            }
            catch (SqlException ex)
            {

                MsgErro = ex.Message;
            }

            return bRetorno;
            
   
        }
        public Boolean ConfirmarTransacao()
        {
            Boolean bRetorno = false;
            try
            {
                trx.Commit();

                trx.Dispose();

                bRetorno = true;
            }
            catch (SqlException ex)
            {

                MsgErro = ex.Message;
            }

            return bRetorno;

        }
        public Boolean DesfazerTransacao()
        {
            Boolean bRetorno = false;
            try
            {
                trx.Rollback(); 

                bRetorno = true;
            }
            catch (SqlException ex)
            {

                MsgErro = ex.Message;
            }

            return bRetorno;

        }

        public Object ExecuteEscalar(String cStringSQL) 
        {
            Object cRetorno = "";
            
            try
            {
                cmd = new SqlCommand(cStringSQL);

                cmd.Connection = cn;

                cRetorno = cmd.ExecuteScalar();

            }
            catch (SqlException ex)
            {
                cRetorno = "{erro}";
                MsgErro = ex.Message;
            }
            return cRetorno;
        }
        
        public Boolean ExecutarSQL(String StringSQL, Boolean bUsarTransacao)
        {
            Boolean bRetorno = false;
            try
            {
                cmd = new SqlCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = StringSQL;

                cmd.Connection = cn;

                if (bUsarTransacao)
                    cmd.Transaction = trx;
                

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                
                bRetorno = true;

            }
            catch (SqlException  ex)
            {

                MsgErro = ex.Message + " - " + StringSQL;
            }
            return bRetorno;
        }

        public DataSet getDataSet(String cStringSql)
        {
            return getDataSet(cStringSql, ""); 
        }
        public DataSet getDataSet(String cStringSql, String cNomeDataSet) 
        {
            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand(cStringSql);

                cmd.Connection = cn;
                cmd.Transaction = trx;

                adp.SelectCommand = cmd;
                if(cNomeDataSet.Length ==0)
                   adp.Fill(ds);
                else
                   adp.Fill(ds, cNomeDataSet);

            }
            catch (SqlException ex)
            {
                CapturarMsgErro(ex);
                ds = null;
            }
            return ds;
        }
        public int GerarSequenciaTabela(String cNomeTabela, int vCodigoLoja)
        {
            Int32 nRet = 0;
            try
            {
                SqlCommand comando = new SqlCommand("NovoCodigoTabela", cn );
                comando.Parameters.Add(new SqlParameter("@cNomeTabela", cNomeTabela));
                comando.Parameters.Add(new SqlParameter("@nValor", 0));
                comando.Parameters["@nValor"].Direction = ParameterDirection.Output;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Transaction = trx;
                comando.ExecuteNonQuery();

                

                nRet = int.Parse(comando.Parameters["@nValor"].Value.ToString());

                String NovoCodigo = vCodigoLoja + (vCodigoLoja.ToString().Length == 1 ? "0" : "") + nRet.ToString();

                nRet = int.Parse(NovoCodigo);

            }
            catch (SqlException ex)
            {

                CapturarMsgErro(ex);

            }
            return nRet;
        }
    
    }
}
