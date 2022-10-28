using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.IO;
using System.Reflection;

namespace DinnamusMe
{
    class Banco
    {
        static String cMsgErro;

        public static String MsgErro
        {
            get { return Banco.cMsgErro; }
            set { Banco.cMsgErro = value; }
        }
        static private SqlCeEngine engineCe ;
        static String cStringCNX = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\principal.sdf";
        static public bool Compactar() 
        {
            bool bRetorno = false;
            try
            {
                DAO.Fechar();
                engineCe = new SqlCeEngine("Data Source ='" + cStringCNX + "'");
                engineCe.Compact(null);
                bRetorno = false;
            }
            catch (SqlCeException ex)
            {

                MsgErro = ex.Message; 
                
            }
            return bRetorno;
            
        }
    }
}
