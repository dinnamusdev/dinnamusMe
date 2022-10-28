using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DinnamusMe
{
    public partial class frmRegistrarContagem_Lista : Form
    {

        private DAOServidor DAOServidorContagem = null;
        private int nCodigoConferenciaAtual =0;
        private int nCodigoLojaAtual = 0;
        private int nCodigoFilialAtual = 0;
        private String TipoModulo = "";
        private String NomeTipoModuloTransferencia = "Transferencia";
        private String NomeTipoModuloConferencia = "Conferencia";
        private String NomeModulo() {
            if (TipoModulo.Equals(NomeTipoModuloConferencia))
            {
                return NomeTipoModuloConferencia;
            }else
	        {
                return NomeTipoModuloTransferencia;                            
	        }        
        }

        public frmRegistrarContagem_Lista(String TipoModulo)
        {
            InitializeComponent();
            this.TipoModulo = TipoModulo;
            if (!Iniciar_UI())
            {
                this.Dispose();
            }

        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }


        public bool Iniciar_UI() {

            try
            {

                DataTable dt = DAO.getDataSet("select * from lojas", "lojas").Tables["lojas"];
                cbLoja.DataSource = dt;
                cbLoja.DisplayMember = "nome";
                cbLoja.ValueMember = "codigo";
                this.Text = NomeModulo() + " de Mercadorias";
                if (TipoModulo=="Transferencia")
                {
                    lblLojaOrigem.Text = "Escolha a Loja Origem";
                    lblLojaDestino.Visible = true;
                    cbLojaDestino.Visible = true;
                    lblLojaDestino.Text = "Escolha a Loja Destino";
                    brAbrirCotagem.Text = "Iniciar Transferencia";
                    
                }

                

                DataTable dtResp = DAO.getDataSet("select * from usuario", "resp").Tables["resp"];

                cbResponsavel.DataSource = dtResp;
                cbResponsavel.DisplayMember = "Nome";
                cbResponsavel.ValueMember = "Sigla";
                
                

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void brAbrirCotagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbLoja.SelectedIndex<0)
                {
                    MessageBox.Show("Informe a loja","Iniciar "+ NomeModulo());
                    return;
                }
                if (cbFilial.SelectedIndex<0)
                {
                    MessageBox.Show("Informe a filial", "Iniciar "+ NomeModulo());
                    return;
                }
                if (cbResponsavel.SelectedIndex < 0)
                {
                    MessageBox.Show("Informe o responsável", "Iniciar " + NomeModulo());
                    return;
                }

                if (MessageBox.Show("Confirma a inclusão da " + NomeModulo() + " ?", NomeModulo(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int nCodigoLoja = int.Parse(cbLoja.SelectedValue.ToString());
                    int nCodigoLojaDestino = 0; 
                    if (NomeModulo()==NomeTipoModuloTransferencia)
	                {
                        nCodigoLojaDestino = int.Parse(cbLojaDestino.SelectedValue.ToString());
	                }
                    
                    int nCodigoFilial = int.Parse(cbFilial.SelectedValue.ToString());
                    String cResp= cbResponsavel.SelectedValue.ToString();
                    if (IniciarConexao(nCodigoLoja))
                    {
                        bool bRet = false;
                        if (NomeModulo()==NomeTipoModuloConferencia)
                        {
                            bRet=IniciarConferencia(nCodigoLoja, nCodigoFilial, cResp, dtConf.Value);
                        }
                        else
                        {
                            bRet = IniciarTransferencia(nCodigoLoja, nCodigoFilial, nCodigoLojaDestino, cResp, dtConf.Value);
                        }    
                        if (bRet) {
                            AtualizarGridConf();
                            MessageBox.Show( NomeModulo() +" iniciada com sucesso");
                            if (NomeModulo() == NomeTipoModuloTransferencia) {
                                tabControl1.SelectedIndex = 3;
                            }                                
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível iniciar a "+ NomeModulo());
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "  - brAbrirCotagem_Click ");
            }
        }
        private bool IniciarConferencia(int nLoja,int nFilial,String cResp, DateTime cData) {
            try
            {

                String cCodigoUsuario="";
                String cNomeUsuario="";
                DataSet dsResp = DAOServidorContagem.getDataSet("select * from usuario where sigla='"+ cResp +"' and isnull(bloqueio,0)=0");
                if (dsResp.Tables[0].Rows.Count>0)
                {
                    cCodigoUsuario= dsResp.Tables[0].Rows[0]["codigo"].ToString();
                    cNomeUsuario= dsResp.Tables[0].Rows[0]["nome"].ToString();
            		 
                }else
	            {
                    MessageBox.Show("Usuario não localizado no servidor","Iniciar Conferência");
                    return false;
	            }

                //int nCodigoConferencia = DAOServidorContagem.GerarSequenciaTabela("dadosped",nLoja);
                //String cSQL = "insert into dadosped(codigo,loja,filial,data,codvendedor,vendedor,feito,recebido,dataprevdevol,nomemov) values" +
                 //   "(" + nCodigoConferencia + "," + nLoja + "," + nFilial + ",'" + cData.ToString("MM/dd/yyyy") + "','" + cCodigoUsuario + "','" + cNomeUsuario + "','N','N','" + cData.ToString("MM/dd/yyyy") + "','CONFERENCIA')";

                return Conferencia.IncluirConferencia(nLoja, nFilial, cData, cCodigoUsuario, cNomeUsuario);
                
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                
            }
            return false;
        
        
        }
        private bool IniciarTransferencia(int nLoja, int nFilial, int nLojaDestino ,String cResp, DateTime cData)
        {
            try
            {

                String cCodigoUsuario = "";
                String cNomeUsuario = "";
                DataSet dsResp = DAOServidorContagem.getDataSet("select * from usuario where sigla='" + cResp + "' and isnull(bloqueio,0)=0");
                if (dsResp.Tables[0].Rows.Count > 0)
                {
                    cCodigoUsuario = dsResp.Tables[0].Rows[0]["codigo"].ToString();
                    cNomeUsuario = dsResp.Tables[0].Rows[0]["nome"].ToString();

                }
                else
                {
                    MessageBox.Show("Usuario não localizado no servidor", "Iniciar Transferencia");
                    return false;
                }

                return Conferencia.IncluirTransferencia(nLoja, nFilial, nLojaDestino, cData, cNomeUsuario );
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " - IniciarTransferencia" );

            }
            return false;


        }
        private bool IniciarConexao(int nCodigoLoja) {

            try
            {
                DAOServidorContagem = null;

                DataSet dsDadosLoja = DAO.getDataSet("select * from lojas where codigo=" + nCodigoLoja);
                if (dsDadosLoja.Tables[0].Rows.Count>0)
                {
                    String cHost="",cUser ="",cSenha="",cBanco="";
                    cHost = dsDadosLoja.Tables[0].Rows[0]["host"].ToString();
                    cUser = dsDadosLoja.Tables[0].Rows[0]["usuario"].ToString();
                    cSenha = dsDadosLoja.Tables[0].Rows[0]["senha"].ToString();
                    cBanco = dsDadosLoja.Tables[0].Rows[0]["banco"].ToString();

                    DAOServidorContagem = new DAOServidor();
                    if(!DAOServidorContagem.Iniciar(cHost,cUser ,cSenha,cBanco)){
                        MessageBox.Show("Não foi possível iniciar a conexao com " + cHost + " - banco : " + cBanco);
                    }
                    else
                    {
                        Conferencia.DAOServidorContagem = DAOServidorContagem;
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível iniciar a conexao");
                }

                

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }           

        }

        private void frmRegistrarContagem_Lista_Activated(object sender, EventArgs e)
        {
            
        }

        private void cbFilial_GotFocus(object sender, EventArgs e)
        {
            try
            {

                int nCodigoLoja = 0;

                if (cbLoja.SelectedIndex >= 0) { 
                
                    nCodigoLoja  = int.Parse(cbLoja.SelectedValue.ToString());

                    cbFilial.DataSource = DAO.getDataSet("select * from filial where codigoloja=" + nCodigoLoja,"filial").Tables["Filial"];
                    cbFilial.DisplayMember = "NomeFilial";
                    cbFilial.ValueMember = "CodigoFilial";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private bool AtualizarGridConf() {
            try
            {
                
               // MessageBox.Show(NomeModulo() + " - " + NomeTipoModuloConferencia);


                if (NomeModulo()==NomeTipoModuloConferencia)
                {
                    dbgContagens.DataSource = Conferencia.ListarConferencias().Tables["CONF"];
                }
                else
                {
                    dbgContagens.DataSource = Conferencia.ListarTransferencias().Tables["CONF"];
                }
                //DAOServidorContagem.getDataSet("select codigo ,vendedor resp,data,loja,filial from dadosped where feito='N' and recebido='N' and nomemov='CONFERENCIA'","CONF").Tables["CONF"];
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        
        }
        private bool ValidarItem()
        {
            bool bRetorno = false;


            if (txtProcurar.Text.Length > 0)
            {
                if (cbOpcaoBusca.Text == "Codigo Barra Int.")
                {
                    if (txtProcurar.Text.Length != 13)
                        MessageBox.Show("O Codigo B.Int precisa ter 13 digitos", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    else
                        bRetorno = true;

                }
                else
                    bRetorno = true;

            }
            if (bRetorno)
            {
                if (txtQt.Text.Length > 0 && chkQtAutomatica.Checked)
                {
                    try
                    {
                        Int32.Parse(txtQt.Text);
                        bRetorno = true;
                    }
                    catch (Exception)
                    {
                        bRetorno = false;
                        MessageBox.Show("Quantidade Inválida", "Inventário");
                    }
                }
            }

            return bRetorno;
        }
        private bool Iniciar_cbFilial(int nCodigoLoja){
            try
            {


                cbFilial.DataSource = DAO.getDataSet("select * from filial where codigoloja=" + nCodigoLoja, "filial").Tables["filial"];
                cbFilial.DisplayMember = "NomeFilial";
                cbFilial.ValueMember = "CodigoFilial";


                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int nLoja = int.Parse( cbLoja.SelectedValue.ToString());
                if (DAOServidorContagem == null)
                {
                    IniciarConexao(nLoja);

                }
                if (tabControl1.SelectedIndex == 3 || tabControl1.SelectedIndex == 4)
                {
                    
                    if (nCodigoConferenciaAtual == 0) {
                        MessageBox.Show("Selecione uma conferência");
                        tabControl1.SelectedIndex = 2;
                        return; 
                    }

                }
                if (tabControl1.SelectedIndex == 2)
                {

                     AtualizarGridConf();
                     
                }
                else if (tabControl1.SelectedIndex == 3) {
                    if (cbOpcaoBusca.SelectedIndex <0)
                    {
                        cbOpcaoBusca.SelectedIndex = 0;    
                    }                    
                    txtProcurar.Focus();
                }
                else if (tabControl1.SelectedIndex == 4) {
                    txtConferencia.Text = nCodigoConferenciaAtual.ToString();
                    AtualizaGridItens(nCodigoConferenciaAtual,NomeModulo());
                
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private bool AtualizaGridItens(int nCodigoConferencia,String cTipo){
            try
            {

                if (cTipo=="Conferencia"){
            	    dbgItensConferidos.DataSource = Conferencia.ListarItensConferidos(nCodigoConferencia).Tables["ITENSCONF"];	 
	            }else{
                    dbgItensConferidos.DataSource = Conferencia.ListarItensTransferidos(nCodigoConferencia).Tables["ITENSCONF"];	                 
                }
                
                txtContado.Text = Conferencia.ContarItensConferidos(nCodigoConferencia,cTipo).ToString();

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        
        }
        private void txtPrDataocurar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                IncluirItem();
            }
        }
        private bool IncluirItem() {
            
            bool bRet = false;
            try
            {

                bool bVerificacao = false;
                if (NomeModulo() == NomeTipoModuloConferencia) {
                    if (Conferencia.ListarConferencias(nCodigoConferenciaAtual).Tables[0].Rows.Count != 0) 
                        bVerificacao = true;                   
                }else if (Conferencia.ListarTransferencias(nCodigoConferenciaAtual).Tables[0].Rows.Count != 0) {
                        bVerificacao = true;
                }
                
                

                if (!bVerificacao)
                {
                    MessageBox.Show("A " + NomeModulo() + " ja esta encerrada");
                    nCodigoConferenciaAtual = 0;
                    nCodigoFilialAtual = 0;
                    nCodigoLojaAtual = 0;
                    tabControl1.SelectedIndex = 2;
                    dbgContagens.Focus();
                    return false;
                }
                //MessageBox.Show("Teste 2");
                if (ValidarItem()) {
                    DataSet ds= Conferencia.PesquisarProduto(txtProcurar.Text, cbOpcaoBusca.Text);
                    if (ds != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            int nLojaAtual = nCodigoLojaAtual;
                            int nFilialAtual = nCodigoFilialAtual;
                            //MessageBox.Show("Teste 3");
                            Int32 nIG_ChaveUnica = Int32.Parse(ds.Tables[0].Rows[0]["chaveunica"].ToString());
                            Int32 nCP_ChaveUnica = Int32.Parse(ds.Tables[0].Rows[0]["cp_chaveunica"].ToString());
                            Decimal nPreco = 0;// Decimal.Parse(ds.Tables[0].Rows[0]["preco"].ToString());
                            String cNome = ds.Tables[0].Rows[0]["nome"].ToString();
                            //MessageBox.Show("Teste 4");
                            txtUltimoProduto.Text = "Nome: " + cNome + " - Codigo:( " + txtProcurar.Text + " )";
                            if (txtQt.Text.Length > 0)
                            {
                                //MessageBox.Show("Teste 5");
                                if (Conferencia.IncluirItem(nCodigoConferenciaAtual, nIG_ChaveUnica, txtProcurar.Text, cNome, decimal.Parse(txtQt.Text),nPreco, nFilialAtual, nLojaAtual ,NomeModulo()))
                                {
                                    txtUltimoProduto.Text += " Quant: (" + txtQt.Text + ")";
                                    bRet = true;
                                    txtProcurar.Text = "";
                                    if(chkQtAutomatica.Checked)
                                        txtQt.Text = "1";
                                    else
                                        txtQt.Text = "";
                                    txtProcurar.Focus();
                                }
                                else
                                {
                                    Beep.MessageBeep();
                                    MessageBox.Show("Problema na inclusão do item");
                                    txtProcurar.Focus();
                                }
                            }
                            else
                            {
                                txtQt.Focus();
                            }
                        }
                        else
                        {
                            Beep.MessageBeep();
                            MessageBox.Show("Produto não localizado", "Inventário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            txtProcurar.Text = "";
                            txtProcurar.Focus();
                        }
                    }
                }
           }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return bRet;
        
        }

        private void dbgContagens_CurrentCellChanged(object sender, EventArgs e)
        {
            try 
	        {	        
        	    	DataTable dt = (DataTable)dbgContagens.DataSource;
                    if (dt.Rows.Count>0)
                    {
                        nCodigoConferenciaAtual = int.Parse(dt.Rows[dbgContagens.CurrentRowIndex]["codigo"].ToString());
                        nCodigoLojaAtual = int.Parse(dt.Rows[dbgContagens.CurrentRowIndex]["loja"].ToString());
                        nCodigoFilialAtual = int.Parse(dt.Rows[dbgContagens.CurrentRowIndex]["filial"].ToString());
                        txtCodigoConf.Text = nCodigoConferenciaAtual.ToString();
                	    	 
                    }else{
                        nCodigoConferenciaAtual = 0;
                        nCodigoFilialAtual = 0;
                        nCodigoLojaAtual = 0;
                        txtCodigoConf.Text  = "";
                    }
	        }
	        catch (Exception ex)
	        {
        		
		        MessageBox.Show(ex.Message);
	        }
        }

        private void txtProcurar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                IncluirItem();
            }
        }

        private void btPesquisar_Click_1(object sender, EventArgs e)
        {
            IncluirItem();
        }

        private void txtQt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                IncluirItem();
            }
        }

        private void txtQt_GotFocus_1(object sender, EventArgs e)
        {
            txtQt.SelectionStart = 0;
            txtQt.SelectionLength = txtQt.Text.Length;
            txtQt.BackColor = Color.Yellow;
        }

        private void txtQt_LostFocus_1(object sender, EventArgs e)
        {
            txtQt.BackColor = Color.White;
        }

        private void txtProcurar_GotFocus_1(object sender, EventArgs e)
        {
            txtProcurar.SelectionStart = 0;
            txtProcurar.SelectionLength = txtQt.Text.Length;
            txtProcurar.BackColor = Color.Yellow;
        }

        private void txtProcurar_LostFocus_1(object sender, EventArgs e)
        {
            txtProcurar.BackColor = Color.White;
        }

        private void cbOpcaoBusca_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtProcurar.Focus();
        }

        private void chkQtAutomatica_CheckStateChanged_1(object sender, EventArgs e)
        {
            txtProcurar.Focus();
            if (!chkQtAutomatica.Checked)
                txtQt.Text = "";
            else
                txtQt.Text = "1";
        }

        private void txtQt_TextChanged_1(object sender, EventArgs e)
        {

        }
       
        private void btRemover_Click(object sender, EventArgs e)
        {
            try{
               if (MessageBox.Show("Confirma a exclusão?", "Exclusão Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (dbgItensConferidos.CurrentRowIndex >= 0)
                    {

                        if ((NomeModulo()=="Conferencia" ? Conferencia.ListarConferencias(nCodigoConferenciaAtual ).Tables[0].Rows.Count : Conferencia.ListarTransferencias(nCodigoConferenciaAtual).Tables[0].Rows.Count )== 0 )
                        {
                            MessageBox.Show("A "+ NomeModulo() +" ja esta encerrada");
                            nCodigoConferenciaAtual = 0;
                            nCodigoFilialAtual = 0;
                            nCodigoLojaAtual = 0;
                            tabControl1.SelectedIndex = 2;
                            dbgContagens.Focus();
                            return;
                        }

                        DataTable dt = (DataTable)dbgItensConferidos.DataSource;
                        Int32 nIDItem=0;
                                                
                        nIDItem = Int32.Parse(dt.Rows[dbgItensConferidos.CurrentRowIndex]["id"].ToString());
                                                
                        if (Conferencia.ExcluirItemConferido(nCodigoConferenciaAtual,nIDItem,NomeModulo()))
                        {                          
                            AtualizaGridItens(nCodigoConferenciaAtual,NomeModulo());

                            MessageBox.Show("Item excluído com sucesso");

                        }
                        else{
                            MessageBox.Show("Não foi possível excluir o item");
                        
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbLojaDestino_GotFocus(object sender, EventArgs e)
        {
            try
            {

                int nCodigoLojaOrigem = 0;
                nCodigoLojaOrigem = int.Parse(cbLoja.SelectedValue.ToString());
                DataTable dt = DAO.getDataSet("select codigofilial codigo,nomefilial nome from filial where codigoloja <> " + nCodigoLojaOrigem, "lojas").Tables["lojas"];
                cbLojaDestino.DataSource = dt;
                cbLojaDestino.DisplayMember = "nome";
                cbLojaDestino.ValueMember = "codigo";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbLoja_GotFocus(object sender, EventArgs e)
        {
            try
            {
                if (TipoModulo == NomeTipoModuloTransferencia)
                {
                    if (cbLoja.SelectedIndex >= 0)
                    {
                        int nCodigoLojaDestino = 0;
                        nCodigoLojaDestino = int.Parse(cbLojaDestino.SelectedValue.ToString());
                        DataTable dt = DAO.getDataSet("select * from lojas where codigo <> " + nCodigoLojaDestino, "lojas").Tables["lojas"];
                        cbLoja.DataSource = dt;
                        cbLoja.DisplayMember = "nome";
                        cbLoja.ValueMember = "codigo";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtContado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}