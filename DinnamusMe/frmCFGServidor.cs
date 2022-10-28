using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DinnamusMe
{
    public partial class frmCFGServidor : Form
    {
        public frmCFGServidor()
        {
            InitializeComponent();
            
        }

        private void frmCFGServidor_Load(object sender, EventArgs e)
        {

        }
        private bool IniciarUI() {

            try
            {
                DataSet dt = DAO.getDataSet("select * from lojas");

                dbgLojas.DataSource = dt.Tables[0];
                

                return true;
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void frmCFGServidor_Activated(object sender, EventArgs e)
        {
            if (!IniciarUI())
            {
                MessageBox.Show("Não foi possível iniciar o modulo");
                this.Dispose();
            }
            else
            {
                AtualizarCampos();
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            String cHost = "", cBanco = "", cUsuario = "", cSenha = "";
            cHost = txtHost.Text;
            cBanco = txtBanco.Text;
            cUsuario = txtUsuario.Text;
            cSenha = txtSenha.Text;
            int nLinha = dbgLojas.CurrentRowIndex;

            if (MessageBox.Show("Confirma os dados do servidor", "Config.Servidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            { 
                if (dbgLojas.CurrentRowIndex >=0){
                

                    
                    DataTable dt = (DataTable)dbgLojas.DataSource;
                    int nCodigoLoja = int.Parse(dt.Rows[nLinha]["codigo"].ToString());

                    if (DAO.ExecutarSQL("update lojas set host='"+ cHost  +
                        "',banco='" + cBanco +
                        "',usuario='" + cUsuario +
                        "',senha='" + cSenha + 
                        "' where codigo=" + dt.Rows[nLinha]["codigo"].ToString(),false)) {

                            IniciarUI();
                            MessageBox.Show("Dados Atualizados com sucesso!","Cfg. Servidor");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível atualizar os dados!","Cfg.Servidor");
                        }


                }
            }

        }
        private void AtualizarCampos() {

            try
            {

                if (dbgLojas.CurrentRowIndex >= 0)
                {
                    int nLinha = dbgLojas.CurrentRowIndex;
                    DataTable dt = (DataTable)dbgLojas.DataSource;
                    txtBanco.Text = dt.Rows[nLinha]["banco"].ToString();
                    txtHost.Text = dt.Rows[nLinha]["host"].ToString();
                    txtUsuario.Text = dt.Rows[nLinha]["usuario"].ToString();
                    txtSenha.Text = dt.Rows[nLinha]["senha"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void dbgLojas_CurrentCellChanged(object sender, EventArgs e)
        {

            
               
        }

        private void frmCFGServidor_KeyDown(object sender, KeyEventArgs e)
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

        private void dbgLojas_Click(object sender, EventArgs e)
        {
            AtualizarCampos();
        }

        private void dbgLojas_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtualizarCampos();
        }

        private void dbgLojas_KeyUp(object sender, KeyEventArgs e)
        {
            AtualizarCampos();
        }
    }
}