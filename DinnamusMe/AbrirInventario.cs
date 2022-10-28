using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DinnamusMe
{
    public partial class AbrirInventario : Form
    {
        private Boolean bCargaOK = false;
        public AbrirInventario()
        {
            InitializeComponent();
            InicializarUI();
        }

        private Boolean ValidarDados() 
        {
            Boolean bRetorno = false;
            try
            {
                if (cbFilial.SelectedValue.ToString().Length >= 0)
                {
                    if (cbTipoInventario.SelectedItem.ToString().Length >= 0)
                    {
                        bRetorno = true;
                    }
                }

                if (cbTipoInventario.SelectedValue.ToString().Trim() == "Online")
                {
                    if (txtServidor.Text.Length ==0)
                    {
                        MessageBox.Show("Informe o servidor do banco");
                        return false;
                    }
                    if (txtUsuario.Text.Length == 0)
                    {
                        MessageBox.Show("Informe o usuário");
                        return false;
                    }
                    if (txtSenha.Text.Length == 0)
                    {
                        MessageBox.Show("Informe a senha");
                        return false;
                    }
                    if (txtBanco.Text.Length == 0)
                    {
                        MessageBox.Show("Informe o nome do banco");
                        return false;
                    }
                    bRetorno = true;

                    
                    
                
                }
            }
            catch (Exception)
            {

                bRetorno =false;
            }
            return bRetorno;
            
 

        }
        private void btIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidarDados()){

                    Int32 nLoja = Int32.Parse(txtCodigoLoja.Text);

                    if (Inventario.Abrir(Int32.Parse(cbFilial.SelectedValue.ToString()), dtInicioInvent.Value, txtResponsavel.Text, nLoja,cbTipoInventario.SelectedIndex,txtServidor.Text,txtUsuario.Text,txtSenha.Text,txtBanco.Text ))
                    {
                        Int32 nUltimoInventario=Inventario.ObterNumeroUltimoInventario();
                        MessageBox.Show("Inventário [ " + nUltimoInventario.ToString() + " ] incluido com sucesso");                                                
                        
                        this.Close();                     
                    }
                    else 
                    {
                        MessageBox.Show("Não foi possível incluir o Inventário");
                    }  
                }
            }
            catch (Exception ex)
            {

                lblMSG.Text = ex.Message;
            }
        }
        private Boolean InicializarUI() 
        {
            Boolean bRetorno = false;
            try
            {

                DataSet ds = DAO.getDataSet("select CodigoFilial,NomeFilial From Filial");
                if (ds.Tables.Count > 0)
                {
                    cbFilial.ValueMember = "CodigoFilial";
                    cbFilial.DisplayMember = "NomeFilial";
                    cbFilial.DataSource = ds.Tables[0];
                    cbFilial.Enabled = true;
                }
                else
                    cbFilial.Enabled = false;

                dtInicioInvent.Value = DateTime.Now;
                DataSet dsLoja=DAO.getDataSet("select codigo, nome from lojas");
                txtLoja.Text =  dsLoja.Tables[0].Rows[0]["nome"].ToString();
                txtCodigoLoja.Text = dsLoja.Tables[0].Rows[0]["codigo"].ToString();
                cbTipoInventario.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                lblMSG.Text = ex.Message;
                
            }
            return bRetorno;            

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}