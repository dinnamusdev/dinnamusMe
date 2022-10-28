using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DinnamusMe
{
    class ManipularArquivos
    {
        
        private StreamReader _StreamArquivo = null;

        public StreamReader StreamArquivo
        {
            get { return _StreamArquivo; }
            set { _StreamArquivo = value; }
        }
        private String cMsgErro = "";

        public String MsgErro
        {
            get { return cMsgErro; }
            private set { cMsgErro = value; }
        }
        public ManipularArquivos() { }
        public ManipularArquivos(String cNomeArquivos) 
        {
            try
            {
                _StreamArquivo = new StreamReader(Util.PastaAtual() + "\\" + cNomeArquivos);
            }
            catch (Exception ex)
            {
                MsgErro = ex.Message; 
                 
            }            
        }
        public bool AbrirArquivo(String cNomeArquivos)
        {
            try
            {
                _StreamArquivo = new StreamReader(Util.PastaAtual() + "\\" + cNomeArquivos);
                return true;
            }
            catch (Exception ex)
            {
                MsgErro = ex.Message;
                return false;

            }
        }
        public String LerLinha() 
        {
            String cLinha="";
            try
            {
                if (!_StreamArquivo.EndOfStream)
                    cLinha = _StreamArquivo.ReadLine();
                else
                    cLinha = "FIM DO ARQUIVO";

            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }
            
            return cLinha; 
        }
        public Boolean FimDoArquivo() 
        {
            return _StreamArquivo.EndOfStream;
        }
        public Boolean FecharStream() 
        {
            Boolean bRetorno = false;

            try
            {
                _StreamArquivo.Close();
                
                bRetorno = true;
            }
            catch (Exception ex)
            {

                MsgErro = ex.Message;
            }
            return bRetorno;
        }
    }
}
