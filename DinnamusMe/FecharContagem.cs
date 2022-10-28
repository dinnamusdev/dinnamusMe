using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DinnamusMe
{
    public partial class FecharContagem : Form
    {
        private String cTipoForm = "";
        public FecharContagem(String cTipo)
        {
            InitializeComponent();
            cTipoForm = cTipo;
            InicializarUI(false);
            
        }

        public Boolean InicializarUI(bool bIgnorarMsg)
        {
            try
            {
                this.Text = cTipoForm == "F" ? "Fechar Inventário" : "Re-Abrir Inventário";
                lblMSG.Text = cTipoForm == "F" ? "Inventários Abertos" : "Inventários Fechados";
                btFecharContagem.Text = cTipoForm == "F" ? "Fechar Inventário" : "Re-Abrir Inventário";

                DataTable dt = DAO.getDataSet("SELECT     d.codigo Codigo, f.NomeFilial,f.codigofilial , CASE WHEN d .feito IS NULL THEN 'ABERTO' ELSE 'FECHADO' END AS situacao, d.datainicio  " +
                                                        "FROM         dadosinvent d, Filial f " +
                                                        "WHERE     f.CodigoFilial = d.filial and " + (cTipoForm == "F" ? "d.feito is null " : "d.feito ='S'"), "Inventario").Tables["Inventario"];
                dbgInventarios.DataSource = dt;
                if (dt.Rows.Count == 0)    
                {
                    if (!bIgnorarMsg)
                    {
                        MessageBox.Show("Não foi encontrado nenhum inventário " + (cTipoForm == "F" ? "Aberto" : "Fechado"));
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            return true;
        }

        private void btFecharContagem_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable )dbgInventarios.DataSource;
            if (dt.Rows.Count > 0)
            {
                Int32 nCodigoInventario = Int32.Parse(dt.Rows[dbgInventarios.CurrentRowIndex]["codigo"].ToString());
                if (MessageBox.Show("Confirma o fechamento do inventário " + nCodigoInventario + " ?", "Fechar Contagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (cTipoForm == "F")
                    {
                        if (Inventario.FecharContagemInventario(nCodigoInventario))
                        {
                            InicializarUI(true);
                            MessageBox.Show("Inventário [ " + nCodigoInventario + " ] fechado com sucesso", "Fechamento OK");
                        }
                        else
                            MessageBox.Show("Não foi possível fechar a contagem " + nCodigoInventario);
                    }
                    else
                    {
                        if (Inventario.ReabrirContagemInventario(nCodigoInventario))
                        {
                            InicializarUI(true);
                            MessageBox.Show("Inventário [ " + nCodigoInventario + " ] re-aberto com sucesso", "Fechamento OK");
                        }
                        else
                            MessageBox.Show("Não foi possível re-abrir a contagem " + nCodigoInventario);
                    }

                }
            }
        }

        private void FecharContagem_Load(object sender, EventArgs e)
        {

        }
    }
}