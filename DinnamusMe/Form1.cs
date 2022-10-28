using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Diagnostics;

namespace DinnamusMe
{
    public partial class frmPrincipal : Form
    {
        private Boolean bCargaOk = false;
        public frmPrincipal()
        {
            InitializeComponent();
            InicializarApp();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            
            
        }

        private Boolean InicializarApp() {
            Boolean bRetorno = false;
            if (!bCargaOk)
            {
                if (!IniciarApp.Iniciar())
                {
                    btEntrar.Enabled = false;
                    lblMsgStatus.Text = "Contate o suporte DTI";
                    lblMsgErro.Text = DAO.MsgErro + " " + IniciarApp.MsgErro; 

                }
                else
                {
                    bCargaOk = true;
                    btEntrar.Enabled = true;
                    lblMsgStatus.Text = "Base OK";
                    bRetorno = true;
                }
            }
            return bRetorno;
        }
        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            

        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            
            frmMenu _frmMenu = new frmMenu();
            
            _frmMenu.ShowDialog(); 
        }

        private void lblMsgErro_ParentChanged(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Closed(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_Closing(object sender, CancelEventArgs e)
        {

          
            

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do DinnamuS Mobile?","DinnamuS Mobile",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                Process.GetCurrentProcess().Kill();
                Application.Exit();
            }           
            
        }
    }
}