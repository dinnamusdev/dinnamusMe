namespace DinnamusMe
{
    partial class ExcluirInventario
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
            System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lblMSG = new System.Windows.Forms.Label();
            this.dbgInventarios = new System.Windows.Forms.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.SuspendLayout();
            // 
            // dataGridTableStyle1
            // 
            dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            dataGridTableStyle1.MappingName = "Inventario";
            // 
            // dataGridTextBoxColumn1
            // 
            //this.dataGridTextBoxColumn1.Format = "";
            //this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridTextBoxColumn1.MappingName = "Codigo";
            // 
            // dataGridTextBoxColumn2
            // 
            //this.dataGridTextBoxColumn2.Format = "";
            //this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Filial";
            this.dataGridTextBoxColumn2.MappingName = "NomeFilial";
            // 
            // dataGridTextBoxColumn3
            // 
            //this.dataGridTextBoxColumn3.Format = "";
            //this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Situação";
            this.dataGridTextBoxColumn3.MappingName = "Situacao";
            // 
            // dataGridTextBoxColumn4
            // 
            //this.dataGridTextBoxColumn4.Format = "dd/MM/yyyy";
            //this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Iniciado";
            this.dataGridTextBoxColumn4.MappingName = "Datainicio";
            // 
            // lblMSG
            // 
            this.lblMSG.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblMSG.Location = new System.Drawing.Point(2, 28);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(219, 20);
            this.lblMSG.Text = "Inventários";
            // 
            // dbgInventarios
            // 
            this.dbgInventarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dbgInventarios.Location = new System.Drawing.Point(2, 51);
            this.dbgInventarios.Name = "dbgInventarios";
            this.dbgInventarios.Size = new System.Drawing.Size(237, 99);
            this.dbgInventarios.TabIndex = 5;
            this.dbgInventarios.TableStyles.Add(dataGridTableStyle1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Usuário";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(49, 153);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(80, 21);
            this.txtLogin.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(49, 180);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(80, 21);
            this.txtSenha.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Senha";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(49, 207);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(80, 20);
            this.btLogin.TabIndex = 11;
            this.btLogin.Text = "Login";
            this.btLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(135, 207);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(80, 20);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(135, 154);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 20);
            // 
            // ExcluirInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.dbgInventarios);
            this.Menu = this.mainMenu1;
            this.Name = "ExcluirInventario";
            this.Text = "Excluir Inventário";
            this.Load += new System.EventHandler(this.ExcluirInventario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.DataGrid dbgInventarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
    }
}