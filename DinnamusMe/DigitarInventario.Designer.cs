namespace DinnamusMe
{
    partial class DigitarInventario
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
            System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dbgInventarios = new System.Windows.Forms.DataGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cbOpcaoBusca = new System.Windows.Forms.ComboBox();
            this.txtUltimoProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoFilial = new System.Windows.Forms.TextBox();
            this.txtNomeFilial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInventarioAtual = new System.Windows.Forms.TextBox();
            this.lblFilial = new System.Windows.Forms.Label();
            this.chkQtAutomatica = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtContado = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btRemover = new System.Windows.Forms.Button();
            this.txtCodigoFilial2 = new System.Windows.Forms.TextBox();
            this.txtNomeFilial2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoInventario2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dbgItensInventario = new System.Windows.Forms.DataGrid();
            this.btFechar = new System.Windows.Forms.Button();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridTableStyle1
            // 
            dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn8);
            dataGridTableStyle1.MappingName = "Inventario";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.HeaderText = "Cod.";
            this.dataGridTextBoxColumn1.MappingName = "Codigo";
            this.dataGridTextBoxColumn1.Width = 30;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.HeaderText = "Filial";
            this.dataGridTextBoxColumn2.MappingName = "NomeFilial";
            this.dataGridTextBoxColumn2.Width = 80;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.HeaderText = "Situação";
            this.dataGridTextBoxColumn3.MappingName = "situacao";
            this.dataGridTextBoxColumn3.Width = 60;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.HeaderText = "Iniciado";
            this.dataGridTextBoxColumn4.MappingName = "datainicio";
            this.dataGridTextBoxColumn4.Width = 70;
            // 
            // dataGridTableStyle2
            // 
            dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            dataGridTableStyle2.MappingName = "itensinvent";
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.HeaderText = "Qt";
            this.dataGridTextBoxColumn5.MappingName = "qt";
            this.dataGridTextBoxColumn5.Width = 30;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.HeaderText = "Nome";
            this.dataGridTextBoxColumn6.MappingName = "descricao";
            this.dataGridTextBoxColumn6.Width = 90;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.HeaderText = "Cod.Barra";
            this.dataGridTextBoxColumn7.MappingName = "codigobarra";
            this.dataGridTextBoxColumn7.Width = 80;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 291);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btFechar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dbgInventarios);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 268);
            this.tabPage1.Text = "Inventários";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 37);
            this.label2.Text = "Selecione um inventário para realizar a contagem";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.Text = "Inventários Cadastrados";
            // 
            // dbgInventarios
            // 
            this.dbgInventarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dbgInventarios.Location = new System.Drawing.Point(0, 27);
            this.dbgInventarios.Name = "dbgInventarios";
            this.dbgInventarios.Size = new System.Drawing.Size(240, 179);
            this.dbgInventarios.TabIndex = 1;
            this.dbgInventarios.TableStyles.Add(dataGridTableStyle1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.cbOpcaoBusca);
            this.tabPage2.Controls.Add(this.txtUltimoProduto);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtCodigoFilial);
            this.tabPage2.Controls.Add(this.txtNomeFilial);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtInventarioAtual);
            this.tabPage2.Controls.Add(this.lblFilial);
            this.tabPage2.Controls.Add(this.chkQtAutomatica);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtQt);
            this.tabPage2.Controls.Add(this.btPesquisar);
            this.tabPage2.Controls.Add(this.txtProcurar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 268);
            this.tabPage2.Text = "Digitar";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.Text = "Pesq.";
            // 
            // cbOpcaoBusca
            // 
            this.cbOpcaoBusca.Items.Add("Codigo Barra Forn.");
            this.cbOpcaoBusca.Items.Add("Codigo Barra Int.");
            this.cbOpcaoBusca.Items.Add("Referencia");
            this.cbOpcaoBusca.Items.Add("Codigo Seq.");
            this.cbOpcaoBusca.Location = new System.Drawing.Point(50, 57);
            this.cbOpcaoBusca.Name = "cbOpcaoBusca";
            this.cbOpcaoBusca.Size = new System.Drawing.Size(174, 22);
            this.cbOpcaoBusca.TabIndex = 27;
            this.cbOpcaoBusca.SelectedIndexChanged += new System.EventHandler(this.cbOpcaoBusca_SelectedIndexChanged);
            // 
            // txtUltimoProduto
            // 
            this.txtUltimoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUltimoProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtUltimoProduto.Location = new System.Drawing.Point(3, 159);
            this.txtUltimoProduto.Multiline = true;
            this.txtUltimoProduto.Name = "txtUltimoProduto";
            this.txtUltimoProduto.ReadOnly = true;
            this.txtUltimoProduto.Size = new System.Drawing.Size(221, 85);
            this.txtUltimoProduto.TabIndex = 21;
            this.txtUltimoProduto.GotFocus += new System.EventHandler(this.txtUltimoProduto_GotFocus);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(7, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 20);
            this.label6.Text = "Ultimo Produto Lido";
            // 
            // txtCodigoFilial
            // 
            this.txtCodigoFilial.Enabled = false;
            this.txtCodigoFilial.Location = new System.Drawing.Point(59, 3);
            this.txtCodigoFilial.Name = "txtCodigoFilial";
            this.txtCodigoFilial.Size = new System.Drawing.Size(42, 21);
            this.txtCodigoFilial.TabIndex = 15;
            // 
            // txtNomeFilial
            // 
            this.txtNomeFilial.Enabled = false;
            this.txtNomeFilial.Location = new System.Drawing.Point(100, 3);
            this.txtNomeFilial.Name = "txtNomeFilial";
            this.txtNomeFilial.Size = new System.Drawing.Size(124, 21);
            this.txtNomeFilial.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.Text = "FILIAL";
            // 
            // txtInventarioAtual
            // 
            this.txtInventarioAtual.Enabled = false;
            this.txtInventarioAtual.Location = new System.Drawing.Point(100, 30);
            this.txtInventarioAtual.Name = "txtInventarioAtual";
            this.txtInventarioAtual.Size = new System.Drawing.Size(124, 21);
            this.txtInventarioAtual.TabIndex = 11;
            // 
            // lblFilial
            // 
            this.lblFilial.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilial.Location = new System.Drawing.Point(7, 31);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(115, 20);
            this.lblFilial.Text = "INVENTÁRIO";
            // 
            // chkQtAutomatica
            // 
            this.chkQtAutomatica.Checked = true;
            this.chkQtAutomatica.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQtAutomatica.Location = new System.Drawing.Point(84, 112);
            this.chkQtAutomatica.Name = "chkQtAutomatica";
            this.chkQtAutomatica.Size = new System.Drawing.Size(70, 20);
            this.chkQtAutomatica.TabIndex = 3;
            this.chkQtAutomatica.Text = "&Qt.Auto";
            this.chkQtAutomatica.CheckStateChanged += new System.EventHandler(this.chkQtAutomatica_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.Text = "QT";
            // 
            // txtQt
            // 
            this.txtQt.Location = new System.Drawing.Point(51, 111);
            this.txtQt.MaxLength = 5;
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(27, 21);
            this.txtQt.TabIndex = 2;
            this.txtQt.Text = "1";
            this.txtQt.TextChanged += new System.EventHandler(this.txtQt_TextChanged);
            this.txtQt.GotFocus += new System.EventHandler(this.txtQt_GotFocus);
            this.txtQt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQt_KeyPress);
            this.txtQt.LostFocus += new System.EventHandler(this.txtQt_LostFocus);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(185, 85);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(39, 21);
            this.btPesquisar.TabIndex = 1;
            this.btPesquisar.Text = "&Ok";
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(51, 85);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(128, 21);
            this.txtProcurar.TabIndex = 0;
            this.txtProcurar.TextChanged += new System.EventHandler(this.txtProcurar_TextChanged);
            this.txtProcurar.GotFocus += new System.EventHandler(this.txtProcurar_GotFocus);
            this.txtProcurar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcurar_KeyPress);
            this.txtProcurar.LostFocus += new System.EventHandler(this.txtProcurar_LostFocus);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.Text = "Produto";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage3.Controls.Add(this.txtContado);
            this.tabPage3.Controls.Add(this.lbl);
            this.tabPage3.Controls.Add(this.btRemover);
            this.tabPage3.Controls.Add(this.txtCodigoFilial2);
            this.tabPage3.Controls.Add(this.txtNomeFilial2);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtCodigoInventario2);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.dbgItensInventario);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(240, 268);
            this.tabPage3.Text = "Itens";
            // 
            // txtContado
            // 
            this.txtContado.Location = new System.Drawing.Point(156, 31);
            this.txtContado.Name = "txtContado";
            this.txtContado.ReadOnly = true;
            this.txtContado.Size = new System.Drawing.Size(72, 21);
            this.txtContado.TabIndex = 25;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl.Location = new System.Drawing.Point(111, 32);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(66, 20);
            this.lbl.Text = "CONT.";
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(118, 62);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(115, 21);
            this.btRemover.TabIndex = 23;
            this.btRemover.Text = "(-) Remover Item";
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click_1);
            // 
            // txtCodigoFilial2
            // 
            this.txtCodigoFilial2.Location = new System.Drawing.Point(74, 7);
            this.txtCodigoFilial2.Name = "txtCodigoFilial2";
            this.txtCodigoFilial2.ReadOnly = true;
            this.txtCodigoFilial2.Size = new System.Drawing.Size(31, 21);
            this.txtCodigoFilial2.TabIndex = 20;
            // 
            // txtNomeFilial2
            // 
            this.txtNomeFilial2.Location = new System.Drawing.Point(104, 7);
            this.txtNomeFilial2.Name = "txtNomeFilial2";
            this.txtNomeFilial2.ReadOnly = true;
            this.txtNomeFilial2.Size = new System.Drawing.Size(124, 21);
            this.txtNomeFilial2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(11, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.Text = "FILIAL";
            // 
            // txtCodigoInventario2
            // 
            this.txtCodigoInventario2.Location = new System.Drawing.Point(74, 31);
            this.txtCodigoInventario2.Name = "txtCodigoInventario2";
            this.txtCodigoInventario2.ReadOnly = true;
            this.txtCodigoInventario2.Size = new System.Drawing.Size(31, 21);
            this.txtCodigoInventario2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(11, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.Text = "INVENT.";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.Text = "Itens Registrados";
            // 
            // dbgItensInventario
            // 
            this.dbgItensInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dbgItensInventario.Location = new System.Drawing.Point(7, 85);
            this.dbgItensInventario.Name = "dbgItensInventario";
            this.dbgItensInventario.Size = new System.Drawing.Size(224, 180);
            this.dbgItensInventario.TabIndex = 9;
            this.dbgItensInventario.TableStyles.Add(dataGridTableStyle2);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(173, 247);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(64, 18);
            this.btFechar.TabIndex = 2;
            this.btFechar.Text = "&Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.HeaderText = "Tipo";
            this.dataGridTextBoxColumn8.MappingName = "Tipo";
            // 
            // DigitarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "DigitarInventario";
            this.Text = "Digitar Inventário";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DigitarInventario_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGrid dbgInventarios;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkQtAutomatica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.TextBox txtInventarioAtual;
        private System.Windows.Forms.TextBox txtCodigoFilial;
        private System.Windows.Forms.TextBox txtNomeFilial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUltimoProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGrid dbgItensInventario;
        private System.Windows.Forms.TextBox txtCodigoFilial2;
        private System.Windows.Forms.TextBox txtNomeFilial2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoInventario2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.TextBox txtContado;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbOpcaoBusca;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
    }
}