using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DinnamusMe
{
    public partial class DigitarInventario : Form
    {
        private System.Collections.Generic.Dictionary<int, DAOServidor> dicDao = new Dictionary<int, DAOServidor>();
        private int nLojaAtual = 0;
        private int nFilialAtual = 0;
        private int nTipoInventario = -1;
        private DAOServidor daoInvent = null;

       
        public DigitarInventario()
        {
            
            InitializeComponent();
            InicializarUI();

            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public Boolean InicializarUI() 
        {
            try
            {
                DataTable dt = DAO.getDataSet("SELECT     d.codigo Codigo, f.NomeFilial,f.codigofilial , CASE WHEN d .feito IS NULL THEN 'ABERTO' ELSE 'FECHADO' END AS situacao, d.datainicio , d.tipoinventario Tipo " +
                                                        "FROM         dadosinvent d, Filial f " +
                                                        "WHERE     f.CodigoFilial = d.filial ", "Inventario").Tables["Inventario"];

                cbOpcaoBusca.SelectedIndex = 0;
                if (dt.Rows.Count > 0)
                {
                    dbgInventarios.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Não foi encontrado nenhum inventário");
                    tabControl1.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex > 0)
                {
                    DataTable dt = (DataTable)dbgInventarios.DataSource;
                    if (tabControl1.SelectedIndex !=0) {
                        int nCodigoInventarioAtual =  int.Parse(dt.Rows[dbgInventarios.CurrentRowIndex]["codigo"].ToString());
                        int Tipo = int.Parse(dt.Rows[dbgInventarios.CurrentRowIndex]["tipo"].ToString());
                        nLojaAtual = int.Parse(dt.Rows[dbgInventarios.CurrentRowIndex]["codigo"].ToString());
                        if (!dicDao.ContainsKey(nCodigoInventarioAtual))
                        {                            
                            if(Tipo==0){
                                DAOServidor daoinvent = new DAOServidor();
                                if (daoinvent.Iniciar(nCodigoInventarioAtual))
                                {
                                    dicDao.Add(nCodigoInventarioAtual, daoinvent);
                                }
                                else
                                {
                                    MessageBox.Show("Não foi possível iniciar a conexão remota");
                                    return;
                                }
                            }
                        }

                        DataSet dsDadosInventario = Inventario.DadosInventario(nCodigoInventarioAtual);
                        if (dsDadosInventario.Tables[0].Rows.Count >0)
                        {
                            nLojaAtual = int.Parse(dsDadosInventario.Tables[0].Rows[0]["loja"].ToString());
                            nFilialAtual  = int.Parse(dsDadosInventario.Tables[0].Rows[0]["filial"].ToString());
                            nTipoInventario  = int.Parse(dsDadosInventario.Tables[0].Rows[0]["tipoinventario"].ToString());
                        }
                    }                    
                    if (dt.Rows.Count > 0)
                    {                       
                        txtInventarioAtual.Text = dt.Rows[dbgInventarios.CurrentRowIndex]["codigo"].ToString();
                        if (dt.Rows[dbgInventarios.CurrentRowIndex]["situacao"].ToString() == "ABERTO")
                        {
                            btRemover.Enabled = true;

                            txtProcurar.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Inventário fechado. Liberado apenas consulta");
                            btRemover.Enabled = false;
                            tabControl1.SelectedIndex = 2;
                        }

                        if (tabControl1.SelectedIndex == 1)
                        {
                            txtCodigoFilial.Text = dt.Rows[dbgInventarios.CurrentRowIndex]["codigofilial"].ToString();
                            txtNomeFilial.Text = dt.Rows[dbgInventarios.CurrentRowIndex]["nomefilial"].ToString();
                            txtCodigoFilial2.Text = txtCodigoFilial.Text;
                            txtNomeFilial2.Text = txtNomeFilial.Text;
                            txtCodigoInventario2.Text = txtInventarioAtual.Text;

                        }
                        else if (tabControl1.SelectedIndex == 2)
                        {
                            txtCodigoFilial.Text = dt.Rows[dbgInventarios.CurrentRowIndex]["codigofilial"].ToString();
                            txtNomeFilial.Text = dt.Rows[dbgInventarios.CurrentRowIndex]["nomefilial"].ToString();
                            txtCodigoFilial2.Text = txtCodigoFilial.Text;
                            txtNomeFilial2.Text = txtNomeFilial.Text;
                            txtCodigoInventario2.Text = txtInventarioAtual.Text;
                            Int32 nCodigoInv = Int32.Parse(txtInventarioAtual.Text);
                            dbgItensInventario.DataSource = Inventario.ListarItensInventario(nCodigoInv,0,0).Tables[0];
                            txtContado.Text = Inventario.TotalContado(nCodigoInv).ToString();

                        }
                        
                    }
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); 
            }

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            IncluirItem();
        }

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            
  
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
        private String TirarZerosInsignificantes(String cTexto) {
            String cRetorno = "";
            String cLetra ="";
            try
            {
                for (int i = 0; i < cTexto.Length ; i++)
                {
                    if (cLetra == "0" && cTexto.Substring(i, 1) != "0" && cRetorno == "") {
                        cRetorno = cTexto.Substring(i, 1);
                    }
                    else
                    {
                        if (cRetorno != "")
                        {
                            cRetorno = cRetorno + cTexto.Substring(i, 1);
                        }
                    }
                    cLetra = cTexto.Substring(i, 1);
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return cRetorno;
        }
        private Boolean IncluirItem()
        {
            bool bRetorno = false;
            try
            {
                if (ValidarItem())
                {

                   /*if ( cbOpcaoBusca.Text=="Referencia")
                    {
                                               
                       txtProcurar.Text = TirarZerosInsignificantes(txtProcurar.Text);
                        
                    }*/

                    Int32 nCodigoInventario = Int32.Parse(txtInventarioAtual.Text);
                    DataTable dt = (DataTable)dbgInventarios.DataSource;
                    int Tipo = int.Parse(dt.Rows[dbgInventarios.CurrentRowIndex]["tipo"].ToString());
                    DataSet ds = null;
                    if (Tipo==0)
                    {
                        
                        if (nTipoInventario == 0)
                        {
                            daoInvent = dicDao[nCodigoInventario];
                        }

                         ds = Inventario.PesquisarItem(daoInvent, txtProcurar.Text, cbOpcaoBusca.Text);
                    }
                    else {
                         ds = Inventario.PesquisarItem_Local(txtProcurar.Text, cbOpcaoBusca.Text);
                    
                    }

                    if (ds != null)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {                            
                            Int32 nIG_ChaveUnica = Int32.Parse(ds.Tables[0].Rows[0]["chaveunica"].ToString());
                            Int32 nCP_ChaveUnica = Int32.Parse(ds.Tables[0].Rows[0]["cp_chaveunica"].ToString());
                            String cNome = ds.Tables[0].Rows[0]["nome"].ToString();
                            txtUltimoProduto.Text = "Nome: " + cNome + " - Codigo:( " + txtProcurar.Text + " )";
                            if (txtQt.Text.Length > 0)
                            {                                
                                if (Inventario.IncluirItem(nCodigoInventario, nCP_ChaveUnica ,nIG_ChaveUnica, txtProcurar.Text, cNome, decimal.Parse(txtQt.Text), nFilialAtual, nLojaAtual, nTipoInventario, daoInvent))
                                {
                                    txtUltimoProduto.Text += " Quant: (" + txtQt.Text + ")";
                                    bRetorno = true;
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
            return bRetorno;
        }

        private void chkQtAutomatica_CheckStateChanged(object sender, EventArgs e)
        {
         
                
                txtProcurar.Focus();
                if (!chkQtAutomatica.Checked)                 
                    txtQt.Text = "";                
                else
                    txtQt.Text = "1";
         

        }


        private void txtQt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return)            
                IncluirItem();
            
        }

        private void txtProcurar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                IncluirItem();
        }

        private void txtQt_GotFocus(object sender, EventArgs e)
        {
            txtQt.SelectionStart = 0;
            txtQt.SelectionLength = txtQt.Text.Length;
            txtQt.BackColor = Color.Yellow;
            
        }

        private void txtProcurar_LostFocus(object sender, EventArgs e)
        {
            txtProcurar.BackColor = Color.White;
        }

        private void txtQt_LostFocus(object sender, EventArgs e)
        {
            txtQt.BackColor = Color.White;
        }

        private void txtProcurar_GotFocus(object sender, EventArgs e)
        {
            txtProcurar.SelectionStart = 0;
            txtProcurar.SelectionLength = txtQt.Text.Length;
            txtProcurar.BackColor = Color.Yellow;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            
        }

        private void btRemover_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão?", "Exclusão Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    DataTable dt = (DataTable)dbgItensInventario.DataSource;

                    if (dbgItensInventario.CurrentRowIndex >= 0)
                    {
                        Int32 nIDItem;
                        
                        Int32 nCodigoInv = Int32.Parse(txtCodigoInventario2.Text);
                        nIDItem = Int32.Parse(dt.Rows[dbgItensInventario.CurrentRowIndex]["id"].ToString());

                        DAOServidor daoinventario = null;
                        if (nTipoInventario==0)
                        {
                            daoinventario = dicDao[nCodigoInv];
                        }

                        if (Inventario.ExcluirItemInventario(nIDItem, nTipoInventario, daoinventario,nCodigoInv,nLojaAtual,nFilialAtual))
                        {
                            dbgItensInventario.DataSource = Inventario.ListarItensInventario(Int32.Parse(txtInventarioAtual.Text),0,0).Tables[0];

                            dt = (DataTable)dbgItensInventario.DataSource;

                            if (dt.Rows.Count > 0)
                                dbgItensInventario.CurrentRowIndex = 0;

                            //Int32 nCodigoInv = Int32.Parse(txtCodigoInventario2.Text);

                            txtContado.Text = Inventario.TotalContado(nCodigoInv).ToString();

                            MessageBox.Show("Item excluído com sucesso");

                        }
                        else
                            MessageBox.Show("Não foi possível excluir o item");

                        txtProcurar.Focus();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DigitarInventario_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Rocker Up
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Rocker Down
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void cbOpcaoBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProcurar.Focus();
        }

        private void txtQt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUltimoProduto_GotFocus(object sender, EventArgs e)
        {
            txtProcurar.Focus();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}