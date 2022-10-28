using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DinnamusMe
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {

        }

        private void menuItem3_Click_1(object sender, EventArgs e)
        {
            AbrirInventario _AbrirInventario = new AbrirInventario();
            _AbrirInventario.ShowDialog();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            DigitarInventario _DigitarInventario = new DigitarInventario();
            _DigitarInventario.ShowDialog(); 
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            FecharContagem _FecharContagem = new FecharContagem("F");
            _FecharContagem.ShowDialog(); 

        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            FecharContagem _FecharContagem = new FecharContagem("R");
            _FecharContagem.ShowDialog(); 
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            GerarArquivoInventario _GerarArquivoInventario = new GerarArquivoInventario();
            _GerarArquivoInventario.ShowDialog();
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            ExcluirInventario _ExcluirInventario = new ExcluirInventario();
            _ExcluirInventario.ShowDialog(); 
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realizar Sincronismo. Isso pode demorar alguns minutos?", "Base Off", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (IniciarApp.ForcarImportacaoBase())
                    MessageBox.Show("Sincronismo realizado com sucesso");
                else
                    MessageBox.Show("Falha no Sincronismo. " + IniciarApp.MsgErro);
            }
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Realizar Compactação da Base. Após o procedimento o aplicativo precisará ser fechado", "Base Off", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (Banco.Compactar())
                    MessageBox.Show("Compactação realizada com sucesso");
                else
                    MessageBox.Show("Falha na Compactação. " + Banco.MsgErro );
            }
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            (new frmCFGServidor()).ShowDialog();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            (new frmRegistrarContagem_Lista("Conferencia")).ShowDialog();
        }

        private void menuItem16_Click(object sender, EventArgs e)
        {
            (new frmRegistrarContagem_Lista("Transferencia")).ShowDialog();
        }
        
    }
}