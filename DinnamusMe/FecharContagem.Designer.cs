namespace DinnamusMe
{
    partial class FecharContagem
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lblMSG = new System.Windows.Forms.Label();
            this.dbgInventarios = new System.Windows.Forms.DataGrid();
            this.btFecharContagem = new System.Windows.Forms.Button();
            dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.SuspendLayout();
            // 
            // dataGridTableStyle1
            // 
            dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            dataGridTableStyle1.MappingName = "Inventario";
            // 
            // dataGridTextBoxColumn1
            // 
            //this.dataGridTextBoxColumn1.Format = "";
            //this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Cod";
            this.dataGridTextBoxColumn1.MappingName = "Codigo";
            this.dataGridTextBoxColumn1.Width = 30;
            // 
            // dataGridTextBoxColumn2
            // 
            //this.dataGridTextBoxColumn2.Format = "";
           // this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Filial";
            this.dataGridTextBoxColumn2.MappingName = "NomeFilial";
            this.dataGridTextBoxColumn2.Width = 140;
            // 
            // dataGridTextBoxColumn3
            // 
            //this.dataGridTextBoxColumn3.Format = "";
            //this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Situa??o";
            this.dataGridTextBoxColumn3.MappingName = "situacao";
            // 
            // lblMSG
            // 
            this.lblMSG.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblMSG.Location = new System.Drawing.Point(0, 31);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(219, 20);
            this.lblMSG.Text = "Invent?rios Abertos";
            // 
            // dbgInventarios
            // 
            this.dbgInventarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dbgInventarios.Location = new System.Drawing.Point(0, 54);
            this.dbgInventarios.Name = "dbgInventarios";
            this.dbgInventarios.Size = new System.Drawing.Size(237, 189);
            this.dbgInventarios.TabIndex = 3;
            this.dbgInventarios.TableStyles.Add(dataGridTableStyle1);
            // 
            // btFecharContagem
            // 
            this.btFecharContagem.Location = new System.Drawing.Point(0, 249);
            this.btFecharContagem.Name = "btFecharContagem";
            this.btFecharContagem.Size = new System.Drawing.Size(123, 20);
            this.btFecharContagem.TabIndex = 4;
            this.btFecharContagem.Text = "Fechar Contagem";
            this.btFecharContagem.Click += new System.EventHandler(this.btFecharContagem_Click);
            // 
            // FecharContagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.btFecharContagem);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.dbgInventarios);
            this.Name = "FecharContagem";
            this.Text = "Fechar Contagem";
            this.Load += new System.EventHandler(this.FecharContagem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.DataGrid dbgInventarios;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.Button btFecharContagem;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;

    }
}