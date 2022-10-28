using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DinnamusMe
{
    class UsuariosApp
    {
        static private String cNomeUsuarioLogin = "";


        static public String NomeUsuarioLogin
        {
            get { return cNomeUsuarioLogin; }
            private set { cNomeUsuarioLogin = value; }
        }
        public static bool Login(String cLogin, String cSenha) 
        {
            bool bRetorno = false;
            try
            {
                DataSet ds;
                ds=DAO.getDataSet("select nome from usuario where sigla='"+ cLogin  +"' and senha='"+ cSenha  +"'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    NomeUsuarioLogin = ds.Tables[0].Rows[0]["Nome"].ToString();
                    bRetorno = true;
                }
                else
                    NomeUsuarioLogin = "";
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return bRetorno;
        }
    }
}
