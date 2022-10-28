using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DinnamusMe
{
    class CriarArquivo
    {

        String cMsgErro = "";

        public String MsgErro
        {
            get { return cMsgErro; }
            private set { cMsgErro = value; }
        }
        StreamWriter _StreamWriter = null;


        public CriarArquivo(String cNomeArquivo) 
        {
            try
            {

                _StreamWriter = new StreamWriter(cNomeArquivo,false,Encoding.UTF8);
                

            }
            catch (Exception ex)
            {
                MsgErro = ex.Message;
                
            }
        }

        public bool GravarLinha(String cLinha) 
        {
            bool bRetorno = false;
            try
            {
                _StreamWriter.WriteLine(cLinha);

                bRetorno = true;

            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }
            return bRetorno;
        }
        public void FecharArquivo() 
        {
           
            _StreamWriter.Close();            

        }
    }
}
