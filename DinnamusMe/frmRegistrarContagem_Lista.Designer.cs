namespace DinnamusMe
{
    partial class frmRegistrarContagem_Lista
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblLojaDestino = new System.Windows.Forms.Label();
            this.cbLojaDestino = new System.Windows.Forms.ComboBox();
            this.lblLojaOrigem = new System.Windows.Forms.Label();
            this.cbLoja = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilial = new System.Windows.Forms.ComboBox();
            this.brAbrirCotagem = new System.Windows.Forms.Button();
            this.dtConf = new System.Windows.Forms.DateTimePicker();
            this.cbResponsavel = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dbgContagens = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCodigoConf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOpcaoBusca = new System.Windows.Forms.ComboBox();
            this.txtUltimoProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkQtAutomatica = new System.Windows.Forms.CheckBox();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dbgItensConferidos = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txtContado = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btRemover = new System.Windows.Forms.Button();
            this.txtConferencia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 265);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblLojaDestino);
            this.tabPage4.Controls.Add(this.cbLojaDestino);
            this.tabPage4.Controls.Add(this.lblLojaOrigem);
            this.tabPage4.Controls.Add(this.cbLoja);
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(240, 242);
            this.tabPage4.Text = "Loja";
            // 
            // lblLojaDestino
            // 
            this.lblLojaDestino.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblLojaDestino.Location = new System.Drawing.Point(5, 99);
            this.lblLojaDestino.Name = "lblLojaDestino";
            this.lblLojaDestino.Size = new System.Drawing.Size(230, 20);
            this.lblLojaDestino.Text = "Escolha a Loja de Destino";
            this.lblLojaDestino.Visible = false;
            // 
            // cbLojaDestino
            // 
            this.cbLojaDestino.Location = new System.Drawing.Point(5, 122);
            this.cbLojaDestino.Name = "cbLojaDestino";
            this.cbLojaDestino.Size = new System.Drawing.Size(226, 22);
            this.cbLojaDestino.TabIndex = 18;
            this.cbLojaDestino.Visible = false;
            this.cbLojaDestino.GotFocus += new System.EventHandler(this.cbLojaDestino_GotFocus);
            // 
            // lblLojaOrigem
            // 
            this.lblLojaOrigem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblLojaOrigem.Location = new System.Drawing.Point(7, 41);
            this.lblLojaOrigem.Name = "lblLojaOrigem";
            this.lblLojaOrigem.Size = new System.Drawing.Size(230, 20);
            this.lblLojaOrigem.Text = "Escolha a Loja de Conferencia";
            // 
            // cbLoja
            // 
            this.cbLoja.Location = new System.Drawing.Point(7, 64);
            this.cbLoja.Name = "cbLoja";
            this.cbLoja.Size = new System.Drawing.Size(226, 22);
            this.cbLoja.TabIndex = 16;
            this.cbLoja.GotFocus += new System.EventHandler(this.cbLoja_GotFocus);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cbFilial);
            this.tabPage3.Controls.Add(this.brAbrirCotagem);
            this.tabPage3.Controls.Add(this.dtConf);
            this.tabPage3.Controls.Add(this.cbResponsavel);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(232, 239);
            this.tabPage3.Text = "Abrir";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.Text = "Responsavel";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.Text = "Filial";
            // 
            // cbFilial
            // 
            this.cbFilial.Location = new System.Drawing.Point(92, 73);
            this.cbFilial.Name = "cbFilial";
            this.cbFilial.Size = new System.Drawing.Size(141, 22);
            this.cbFilial.TabIndex = 16;
            this.cbFilial.GotFocus += new System.EventHandler(this.cbFilial_GotFocus);
            // 
            // brAbrirCotagem
            // 
            this.brAbrirCotagem.Location = new System.Drawing.Point(50, 184);
            this.brAbrirCotagem.Name = "brAbrirCotagem";
            this.brAbrirCotagem.Size = new System.Drawing.Size(141, 20);
            this.brAbrirCotagem.TabIndex = 13;
            this.brAbrirCotagem.Text = "Iniciar Conferência";
            this.brAbrirCotagem.Click += new System.EventHandler(this.brAbrirCotagem_Click);
            // 
            // dtConf
            // 
            this.dtConf.Location = new System.Drawing.Point(7, 18);
            this.dtConf.Name = "dtConf";
            this.dtConf.Size = new System.Drawing.Size(226, 22);
            this.dtConf.TabIndex = 12;
            // 
            // cbResponsavel
            // 
            this.cbResponsavel.Location = new System.Drawing.Point(92, 112);
            this.cbResponsavel.Name = "cbResponsavel";
            this.cbResponsavel.Size = new System.Drawing.Size(141, 22);
            this.cbResponsavel.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dbgContagens);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(232, 239);
            this.tabPage1.Text = "Consultar";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.Text = "Contagem em Aberto";
            // 
            // dbgContagens
            // 
            this.dbgContagens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dbgContagens.Location = new System.Drawing.Point(3, 24);
            this.dbgContagens.Name = "dbgContagens";
            this.dbgContagens.Size = new System.Drawing.Size(234, 215);
            this.dbgContagens.TabIndex = 1;
            this.dbgContagens.TableStyles.Add(this.dataGridTableStyle1);
            this.dbgContagens.CurrentCellChanged += new System.EventHandler(this.dbgContagens_CurrentCellChanged);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.MappingName = "CONF";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.txtCodigoConf);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbOpcaoBusca);
            this.tabPage2.Controls.Add(this.txtUltimoProduto);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.chkQtAutomatica);
            this.tabPage2.Controls.Add(this.txtQt);
            this.tabPage2.Controls.Add(this.btPesquisar);
            this.tabPage2.Controls.Add(this.txtProcurar);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(232, 239);
            this.tabPage2.Text = "Digitar";
            // 
            // txtCodigoConf
            // 
            this.txtCodigoConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCodigoConf.Location = new System.Drawing.Point(58, 4);
            this.txtCodigoConf.Name = "txtCodigoConf";
            this.txtCodigoConf.Size = new System.Drawing.Size(42, 21);
            this.txtCodigoConf.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(10, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.Text = "CONF";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(10, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.Text = "QT";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(10, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.Text = "Pesq.";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.Text = "Prod.";
            // 
            // cbOpcaoBusca
            // 
            this.cbOpcaoBusca.Items.Add("Codigo Barra Forn.");
            this.cbOpcaoBusca.Items.Add("Codigo Barra Int.");
            this.cbOpcaoBusca.Items.Add("Referencia");
            this.cbOpcaoBusca.Items.Add("Codigo Seq.");
            this.cbOpcaoBusca.Location = new System.Drawing.Point(57, 28);
            this.cbOpcaoBusca.Name = "cbOpcaoBusca";
            this.cbOpcaoBusca.Size = new System.Drawing.Size(174, 22);
            this.cbOpcaoBusca.TabIndex = 34;
            this.cbOpcaoBusca.SelectedIndexChanged += new System.EventHandler(this.cbOpcaoBusca_SelectedIndexChanged_1);
            // 
            // txtUltimoProduto
            // 
            this.txtUltimoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUltimoProduto.Location = new System.Drawing.Point(10, 130);
            this.txtUltimoProduto.Multiline = true;
            this.txtUltimoProduto.Name = "txtUltimoProduto";
            this.txtUltimoProduto.ReadOnly = true;
            this.txtUltimoProduto.Size = new System.Drawing.Size(221, 85);
            this.txtUltimoProduto.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 20);
            this.label6.Text = "Ultimo Produto Lido";
            // 
            // chkQtAutomatica
            // 
            this.chkQtAutomatica.Checked = true;
            this.chkQtAutomatica.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQtAutomatica.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.chkQtAutomatica.Location = new System.Drawing.Point(91, 83);
            this.chkQtAutomatica.Name = "chkQtAutomatica";
            this.chkQtAutomatica.Size = new System.Drawing.Size(95, 20);
            this.chkQtAutomatica.TabIndex = 32;
            this.chkQtAutomatica.Text = "&Qt.Auto";
            this.chkQtAutomatica.CheckStateChanged += new System.EventHandler(this.chkQtAutomatica_CheckStateChanged_1);
            // 
            // txtQt
            // 
            this.txtQt.Location = new System.Drawing.Point(58, 82);
            this.txtQt.MaxLength = 5;
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(27, 21);
            this.txtQt.TabIndex = 31;
            this.txtQt.Text = "1";
            this.txtQt.TextChanged += new System.EventHandler(this.txtQt_TextChanged_1);
            this.txtQt.GotFocus += new System.EventHandler(this.txtQt_GotFocus_1);
            this.txtQt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQt_KeyPress_1);
            this.txtQt.LostFocus += new System.EventHandler(this.txtQt_LostFocus_1);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(192, 56);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(39, 21);
            this.btPesquisar.TabIndex = 30;
            this.btPesquisar.Text = "&Ok";
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click_1);
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(58, 56);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(128, 21);
            this.txtProcurar.TabIndex = 29;
            this.txtProcurar.GotFocus += new System.EventHandler(this.txtProcurar_GotFocus_1);
            this.txtProcurar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcurar_KeyPress_1);
            this.txtProcurar.LostFocus += new System.EventHandler(this.txtProcurar_LostFocus_1);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage5.Controls.Add(this.dbgItensConferidos);
            this.tabPage5.Controls.Add(this.txtContado);
            this.tabPage5.Controls.Add(this.lbl);
            this.tabPage5.Controls.Add(this.btRemover);
            this.tabPage5.Controls.Add(this.txtConferencia);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Location = new System.Drawing.Point(0, 0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(240, 242);
            this.tabPage5.Text = "Itens";
            // 
            // dbgItensConferidos
            // 
            this.dbgItensConferidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dbgItensConferidos.Location = new System.Drawing.Point(3, 61);
            this.dbgItensConferidos.Name = "dbgItensConferidos";
            this.dbgItensConferidos.Size = new System.Drawing.Size(230, 178);
            this.dbgItensConferidos.TabIndex = 35;
            this.dbgItensConferidos.TableStyles.Add(this.dataGridTableStyle2);
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle2.MappingName = "ITENSCONF";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.HeaderText = "Produto";
            this.dataGridTextBoxColumn1.MappingName = "descricao";
            this.dataGridTextBoxColumn1.Width = 100;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.HeaderText = "QT";
            this.dataGridTextBoxColumn2.MappingName = "qt";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.HeaderText = "Codigo";
            this.dataGridTextBoxColumn3.MappingName = "codigobarra";
            // 
            // txtContado
            // 
            this.txtContado.Location = new System.Drawing.Point(154, 7);
            this.txtContado.Name = "txtContado";
            this.txtContado.ReadOnly = true;
            this.txtContado.Size = new System.Drawing.Size(72, 21);
            this.txtContado.TabIndex = 30;
            this.txtContado.TextChanged += new System.EventHandler(this.txtContado_TextChanged);
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl.Location = new System.Drawing.Point(109, 8);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(66, 20);
            this.lbl.Text = "TOTAL";
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(116, 38);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(115, 21);
            this.btRemover.TabIndex = 29;
            this.btRemover.Text = "(-) Remover Item";
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // txtConferencia
            // 
            this.txtConferencia.Location = new System.Drawing.Point(54, 7);
            this.txtConferencia.Name = "txtConferencia";
            this.txtConferencia.ReadOnly = true;
            this.txtConferencia.Size = new System.Drawing.Size(49, 21);
            this.txtConferencia.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(9, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.Text = "CONF";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(5, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 20);
            this.label11.Text = "Itens Conferidos";
            // 
            // frmRegistrarContagem_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu1;
            this.Name = "frmRegistrarContagem_Lista";
            this.Text = "Conferência de Mercadorias";
            this.Activated += new System.EventHandler(this.frmRegistrarContagem_Lista_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dbgContagens;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dtConf;
        private System.Windows.Forms.ComboBox cbResponsavel;
        private System.Windows.Forms.Button brAbrirCotagem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilial;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblLojaOrigem;
        private System.Windows.Forms.ComboBox cbLoja;
        private System.Windows.Forms.ComboBox cbOpcaoBusca;
        private System.Windows.Forms.TextBox txtUltimoProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkQtAutomatica;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoConf;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtContado;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.TextBox txtConferencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGrid dbgItensConferidos;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.Label lblLojaDestino;
        private System.Windows.Forms.ComboBox cbLojaDestino;

    }
}