using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace DinnamusMe
{
    class Util
    {
        static private String cMsgErro = "";
        static public String PastaAtual()
        {
            String cCaminho="";
            try
            {
                cCaminho = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
            return cCaminho;
        }
    }
}
