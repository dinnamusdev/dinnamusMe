namespace DinnamusMe
{
    partial class frmCFGServidor
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
            this.dbgLojas = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbgLojas
            // 
            this.dbgLojas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dbgLojas.Location = new System.Drawing.Point(10, 21);
            this.dbgLojas.Name = "dbgLojas";
            this.dbgLojas.Size = new System.Drawing.Size(216, 85);
            this.dbgLojas.TabIndex = 0;
            this.dbgLojas.TableStyles.Add(this.dataGridTableStyle1);
            this.dbgLojas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dbgLojas_KeyUp);
            this.dbgLojas.Click += new System.EventHandler(this.dbgLojas_Click);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.MappingName = "cfg";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridTextBoxColumn1.MappingName = "codigo";
            this.dataGridTextBoxColumn1.Width = 40;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.HeaderText = "Nome";
            this.dataGridTextBoxColumn2.MappingName = "nome";
            this.dataGridTextBoxColumn2.Width = 150;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.Text = "Lojas";
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(10, 129);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(100, 20);
            this.Host.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(64, 128);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(122, 21);
            this.txtHost.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(64, 155);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(76, 21);
            this.txtUsuario.TabIndex = 5;
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(10, 156);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(100, 20);
            this.Usuario.Text = "Usuario";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(64, 182);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(76, 21);
            this.txtSenha.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Senha";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(64, 209);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(122, 21);
            this.txtBanco.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Banco";
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(114, 236);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(72, 20);
            this.btGravar.TabIndex = 13;
            this.btGravar.Text = "Gravar";
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // frmCFGServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbgLojas);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmCFGServidor";
            this.Text = "Configurar Servidor";
            this.Load += new System.EventHandler(this.frmCFGServidor_Load);
            this.Activated += new System.EventHandler(this.frmCFGServidor_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCFGServidor_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dbgLojas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
    }
}