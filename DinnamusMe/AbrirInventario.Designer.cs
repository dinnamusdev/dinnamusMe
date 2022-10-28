namespace DinnamusMe
{
    partial class AbrirInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btIncluir = new System.Windows.Forms.Button();
            this.lblMSG = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbTipoInventario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoLoja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtInicioInvent = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.cbFilial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(0, 234);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(133, 20);
            this.btIncluir.TabIndex = 3;
            this.btIncluir.Text = "Incluir Inventário";
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // lblMSG
            // 
            this.lblMSG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMSG.Location = new System.Drawing.Point(0, 257);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(240, 27);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 228);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbTipoInventario);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCodigoLoja);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtLoja);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dtInicioInvent);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtResponsavel);
            this.tabPage1.Controls.Add(this.cbFilial);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 205);
            this.tabPage1.Text = "Inventario";
            // 
            // cbTipoInventario
            // 
            this.cbTipoInventario.Items.Add("Online");
            this.cbTipoInventario.Items.Add("Off-Line");
            this.cbTipoInventario.Location = new System.Drawing.Point(8, 182);
            this.cbTipoInventario.Name = "cbTipoInventario";
            this.cbTipoInventario.Size = new System.Drawing.Size(224, 22);
            this.cbTipoInventario.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.Text = "Tipo Inventário";
            // 
            // txtCodigoLoja
            // 
            this.txtCodigoLoja.Location = new System.Drawing.Point(8, 15);
            this.txtCodigoLoja.Name = "txtCodigoLoja";
            this.txtCodigoLoja.ReadOnly = true;
            this.txtCodigoLoja.Size = new System.Drawing.Size(32, 21);
            this.txtCodigoLoja.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.Text = "Loja";
            // 
            // txtLoja
            // 
            this.txtLoja.Location = new System.Drawing.Point(44, 15);
            this.txtLoja.Name = "txtLoja";
            this.txtLoja.ReadOnly = true;
            this.txtLoja.Size = new System.Drawing.Size(186, 21);
            this.txtLoja.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.Text = "Data Início";
            // 
            // dtInicioInvent
            // 
            this.dtInicioInvent.Location = new System.Drawing.Point(8, 97);
            this.dtInicioInvent.Name = "dtInicioInvent";
            this.dtInicioInvent.Size = new System.Drawing.Size(224, 22);
            this.dtInicioInvent.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.Text = "Responsável";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(8, 140);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(224, 21);
            this.txtResponsavel.TabIndex = 26;
            // 
            // cbFilial
            // 
            this.cbFilial.Location = new System.Drawing.Point(8, 56);
            this.cbFilial.Name = "cbFilial";
            this.cbFilial.Size = new System.Drawing.Size(224, 22);
            this.cbFilial.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.Text = "Filial";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtBanco);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtSenha);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtUsuario);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtServidor);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 205);
            this.tabPage2.Text = "Dados Servidor";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(32, 172);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(149, 21);
            this.txtBanco.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(32, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.Text = "Banco";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(32, 125);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(149, 21);
            this.txtSenha.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(32, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(32, 78);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(149, 21);
            this.txtUsuario.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(32, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.Text = "Usuario";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(32, 31);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(149, 21);
            this.txtServidor.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(32, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.Text = "Servidor";
            // 
            // btFechar
            // 
            this.btFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btFechar.Location = new System.Drawing.Point(139, 234);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(74, 20);
            this.btFechar.TabIndex = 16;
            this.btFechar.Text = "&Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // AbrirInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(240, 270);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.btIncluir);
            this.Name = "AbrirInventario";
            this.Text = "Abrir Inventário";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbTipoInventario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoLoja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtInicioInvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.ComboBox cbFilial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btFechar;


    }
}