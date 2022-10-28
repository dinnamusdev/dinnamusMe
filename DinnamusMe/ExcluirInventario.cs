using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DinnamusMe
{
    public partial class ExcluirInventario : Form
    {
        public ExcluirInventario()
        {
            InitializeComponent();
            InicializarUI(true);
        }

        private void ExcluirInventario_Load(object sender, EventArgs e)
        {

        }

        public Boolean InicializarUI(bool bIgnorarMsg)
        {
            try
            {


                DataTable dt = DAO.getDataSet("SELECT     d.codigo Codigo, f.NomeFilial,f.codigofilial , CASE WHEN d .feito IS NULL THEN 'ABERTO' ELSE 'FECHADO' END AS Situacao, d.datainicio  Datainicio " +
                                                        "FROM         dadosinvent d, Filial f " +
                                                        "WHERE     f.CodigoFilial = d.filial" , "Inventario").Tables["Inventario"];
                dbgInventarios.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    if (!bIgnorarMsg)
                    {
                        MessageBox.Show("Não foi encontrado nenhum inventário ");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsuariosApp.Login(txtLogin.Text, txtSenha.Text))
            {
                lblNome.Text = UsuariosApp.NomeUsuarioLogin;
                btExcluir.Enabled = true;
            }
            else
                MessageBox.Show("Usuário e/ou Senha incorretos ", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); 

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dbgInventarios.CurrentRowIndex >= 0)
            {
                DataTable ds = (DataTable)dbgInventarios.DataSource;
                Int32 nCodigoInv = Int32.Parse(ds.Rows[dbgInventarios.CurrentRowIndex]["Codigo"].ToString());

                if (MessageBox.Show("Confirma a exclusão do inventário número " + nCodigoInv.ToString() + " ?", "Excluir Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (Inventario.ExcluirInventario(nCodigoInv))
                    {
                        InicializarUI(true);
                        MessageBox.Show("Inventário excluido com sucesso", "Exclusão OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    }
                    else
                        MessageBox.Show("Não foi possível excluir o Inventário ", "Falha na Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
            }


        }
    }
}