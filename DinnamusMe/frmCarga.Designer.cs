namespace DinnamusMe
{
    partial class frmCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarga));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.barra = new System.Windows.Forms.ProgressBar();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblSQL = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(13, 98);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(214, 25);
            // 
            // lblTexto
            // 
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(13, 75);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(214, 20);
            // 
            // lblSQL
            // 
            this.lblSQL.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblSQL.ForeColor = System.Drawing.Color.White;
            this.lblSQL.Location = new System.Drawing.Point(13, 126);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(214, 116);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(60, 245);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(121, 20);
            this.btFechar.TabIndex = 4;
            this.btFechar.Text = "FECHAR";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.lblSQL);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.barra);
            this.Menu = this.mainMenu1;
            this.Name = "frmCarga";
            this.Text = "Carga dos Arquivos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        public System.Windows.Forms.ProgressBar barra;
        public System.Windows.Forms.Label lblTexto;
        public System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}