using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.Data.SqlServerCe;
using System.Data;

namespace DinnamusMe
{
    class DAO
    {
        static private SqlCeTransaction trx;
        static private SqlCeConnection cn=null;
        static private SqlCeDataAdapter adp = new SqlCeDataAdapter();
        static private SqlCeCommand cmd = null;
        

        static public String cMsgErro = "";
        static public bool Iniciar()
        {
            
            bool bRet = false;
            
            String cStringCNX= Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\principal.sdf";

            if (File.Exists(cStringCNX))
            {
                try
                {
                    cn = new System.Data.SqlServerCe.SqlCeConnection("Data Source ='" + cStringCNX + "'");
                    
                    cn.Open();
                    
                    bRet = true;
                }
                catch (System.Data.SqlServerCe.SqlCeException e)
                {
                    CapturarMsgErro(e);  
                }

            }
            else {

                MsgErro = "Arquivo de dados PRINCIPAL.SDF não localizado.";
            }       	                  
     
            return bRet;

        }
        static public String MsgErro
        {
            get {
                
                return cMsgErro; 
            
            }
            private set {
                
                cMsgErro = value; 
            
            }
        }
        static public void Fechar() 
        {
            adp = null;
            cmd = null;
            trx = null;
            cn.Close();
            cn.Dispose();            
            cn = null;

        }
        static private void CapturarMsgErro(SqlCeException e)
        {
            
            MsgErro = "";
            foreach (SqlCeError error in e.Errors)
            {
                MsgErro += error.Message + " ";
            }
        
        }
        static public Boolean IniciarTransacao()
        {
            Boolean bRetorno = false;
            try
            {
                trx = cn.BeginTransaction();

                bRetorno = true;
            }
            catch (SqlCeException ex)
            {

                MsgErro = ex.Message;
            }

            return bRetorno;
            
   
        }
        static public Boolean ConfirmarTransacao()
        {
            Boolean bRetorno = false;
            try
            {
                trx.Commit();

                trx.Dispose();

                bRetorno = true;
            }
            catch (SqlCeException ex)
            {

                MsgErro = ex.Message;
            }

            return bRetorno;

        }
        static public Boolean DesfazerTransacao()
        {
            Boolean bRetorno = false;
            try
            {
                trx.Rollback(); 

                bRetorno = true;
            }
            catch (SqlCeException ex)
            {

                MsgErro = ex.Message;
            }

            return bRetorno;

        }

        static public Object ExecuteEscalar(String cStringSQL) 
        {
            Object cRetorno = "";
            
            try
            {
                cmd = new SqlCeCommand(cStringSQL);

                cmd.Connection = cn;

                cRetorno = cmd.ExecuteScalar();

            }
            catch (SqlCeException ex)
            {
                cRetorno = "{erro}";
                MsgErro = ex.Message;
            }
            return cRetorno;
        }
        
        static public Boolean ExecutarSQL(String StringSQL, Boolean bUsarTransacao)
        {
            Boolean bRetorno = false;
            try
            {
                cmd = new SqlCeCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = StringSQL;

                cmd.Connection = cn;

                if (bUsarTransacao)
                    cmd.Transaction = trx;
                

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                
                bRetorno = true;

            }
            catch (SqlCeException  ex)
            {

                MsgErro = ex.Message + " - " + StringSQL;
            }
            return bRetorno;
        }

        static public DataSet getDataSet(String cStringSql)
        {
            return getDataSet(cStringSql, ""); 
        }
        static public DataSet getDataSet(String cStringSql, String cNomeDataSet) 
        {
            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCeCommand(cStringSql);

                cmd.Connection = cn;

                adp.SelectCommand = cmd;
                if(cNomeDataSet.Length ==0)
                   adp.Fill(ds);
                else
                   adp.Fill(ds, cNomeDataSet);

            }
            catch (SqlCeException ex)
            {
                CapturarMsgErro(ex);
                ds = null;
            }
            return ds;
        }

    }

}
