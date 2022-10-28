namespace DinnamusMe
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblMsgStatus = new System.Windows.Forms.Label();
            this.btEntrar = new System.Windows.Forms.Button();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // lblMsgStatus
            // 
            this.lblMsgStatus.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblMsgStatus.ForeColor = System.Drawing.Color.White;
            this.lblMsgStatus.Location = new System.Drawing.Point(13, 110);
            this.lblMsgStatus.Name = "lblMsgStatus";
            this.lblMsgStatus.Size = new System.Drawing.Size(209, 20);
            this.lblMsgStatus.Text = "Verificando base...Aguarde";
            this.lblMsgStatus.ParentChanged += new System.EventHandler(this.label3_ParentChanged);
            // 
            // btEntrar
            // 
            this.btEntrar.Enabled = false;
            this.btEntrar.Location = new System.Drawing.Point(13, 145);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(209, 35);
            this.btEntrar.TabIndex = 2;
            this.btEntrar.Text = "Entrar DinnamuS ME";
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.ForeColor = System.Drawing.Color.White;
            this.lblMsgErro.Location = new System.Drawing.Point(13, 183);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(209, 58);
            this.lblMsgErro.ParentChanged += new System.EventHandler(this.lblMsgErro_ParentChanged);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(150, 256);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(72, 20);
            this.btFechar.TabIndex = 5;
            this.btFechar.Text = "Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.lblMsgErro);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.lblMsgStatus);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "DinnamuS ME 1.0";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Closed += new System.EventHandler(this.frmPrincipal_Closed);
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmPrincipal_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblMsgStatus;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.Button btFechar;

    }
}

