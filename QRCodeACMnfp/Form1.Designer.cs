namespace InsideNotaFiscal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Conteudo = new System.Windows.Forms.Label();
            this.lbl_Extrato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtExtrato = new System.Windows.Forms.TextBox();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_chromeVersao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblNLancamentos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbManual = new System.Windows.Forms.RadioButton();
            this.rdbAutomatico = new System.Windows.Forms.RadioButton();
            this.btnExcluirRegistro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Conteudo
            // 
            this.lbl_Conteudo.AutoSize = true;
            this.lbl_Conteudo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Conteudo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Conteudo.Location = new System.Drawing.Point(2, 14);
            this.lbl_Conteudo.Name = "lbl_Conteudo";
            this.lbl_Conteudo.Size = new System.Drawing.Size(74, 18);
            this.lbl_Conteudo.TabIndex = 3;
            this.lbl_Conteudo.Text = "QRCode";
            // 
            // lbl_Extrato
            // 
            this.lbl_Extrato.AutoSize = true;
            this.lbl_Extrato.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Extrato.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Extrato.Location = new System.Drawing.Point(14, 93);
            this.lbl_Extrato.Name = "lbl_Extrato";
            this.lbl_Extrato.Size = new System.Drawing.Size(55, 13);
            this.lbl_Extrato.TabIndex = 4;
            this.lbl_Extrato.Text = "Extrato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Enabled = false;
            this.txtCNPJ.Location = new System.Drawing.Point(82, 38);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.ReadOnly = true;
            this.txtCNPJ.Size = new System.Drawing.Size(211, 20);
            this.txtCNPJ.TabIndex = 8;
            this.txtCNPJ.TabStop = false;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(82, 64);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(111, 20);
            this.txtData.TabIndex = 9;
            this.txtData.TabStop = false;
            // 
            // txtExtrato
            // 
            this.txtExtrato.Enabled = false;
            this.txtExtrato.Location = new System.Drawing.Point(81, 90);
            this.txtExtrato.Name = "txtExtrato";
            this.txtExtrato.ReadOnly = true;
            this.txtExtrato.Size = new System.Drawing.Size(112, 20);
            this.txtExtrato.TabIndex = 10;
            this.txtExtrato.TabStop = false;
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(82, 12);
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(211, 20);
            this.txtQRCode.TabIndex = 0;
            this.txtQRCode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtQRCode_PreviewKeyDown);
            // 
            // mskValor
            // 
            this.mskValor.Enabled = false;
            this.mskValor.Location = new System.Drawing.Point(82, 116);
            this.mskValor.Name = "mskValor";
            this.mskValor.ReadOnly = true;
            this.mskValor.Size = new System.Drawing.Size(111, 20);
            this.mskValor.TabIndex = 19;
            this.mskValor.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(158, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gerar Relatorio e Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chrome: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Dev:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Indigo;
            this.linkLabel1.Location = new System.Drawing.Point(50, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Anderson Silva";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Release:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_chromeVersao);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(159, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 55);
            this.panel2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "1.1.2 - purple";
            // 
            // lbl_chromeVersao
            // 
            this.lbl_chromeVersao.AutoSize = true;
            this.lbl_chromeVersao.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chromeVersao.Location = new System.Drawing.Point(55, 6);
            this.lbl_chromeVersao.Name = "lbl_chromeVersao";
            this.lbl_chromeVersao.Size = new System.Drawing.Size(76, 13);
            this.lbl_chromeVersao.TabIndex = 8;
            this.lbl_chromeVersao.Text = "110.0.5481.77";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nº";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Total: ";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorTotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblValorTotal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(78, 38);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(199, 18);
            this.lblValorTotal.TabIndex = 26;
            this.lblValorTotal.Text = "0,00";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNLancamentos
            // 
            this.lblNLancamentos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNLancamentos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblNLancamentos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNLancamentos.Location = new System.Drawing.Point(81, 8);
            this.lblNLancamentos.Name = "lblNLancamentos";
            this.lblNLancamentos.Size = new System.Drawing.Size(196, 18);
            this.lblNLancamentos.TabIndex = 25;
            this.lblNLancamentos.Text = "0";
            this.lblNLancamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(771, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.dataGridView1);
            this.buttonPanel.Location = new System.Drawing.Point(297, 12);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(771, 437);
            this.buttonPanel.TabIndex = 29;
            // 
            // btnInformacoes
            // 
            this.btnInformacoes.BackColor = System.Drawing.SystemColors.Info;
            this.btnInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacoes.Location = new System.Drawing.Point(5, 394);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(135, 55);
            this.btnInformacoes.TabIndex = 4;
            this.btnInformacoes.Text = "Manual do Usuário";
            this.btnInformacoes.UseVisualStyleBackColor = false;
            this.btnInformacoes.Click += new System.EventHandler(this.btnInformacoes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.rdbManual);
            this.panel1.Controls.Add(this.rdbAutomatico);
            this.panel1.Location = new System.Drawing.Point(199, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 71);
            this.panel1.TabIndex = 1;
            // 
            // rdbManual
            // 
            this.rdbManual.AutoSize = true;
            this.rdbManual.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rdbManual.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbManual.Location = new System.Drawing.Point(8, 39);
            this.rdbManual.Name = "rdbManual";
            this.rdbManual.Size = new System.Drawing.Size(84, 22);
            this.rdbManual.TabIndex = 1;
            this.rdbManual.TabStop = true;
            this.rdbManual.Text = "Manual";
            this.rdbManual.UseVisualStyleBackColor = false;
            this.rdbManual.CheckedChanged += new System.EventHandler(this.rdbManual_CheckedChanged);
            // 
            // rdbAutomatico
            // 
            this.rdbAutomatico.AutoSize = true;
            this.rdbAutomatico.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rdbAutomatico.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAutomatico.Location = new System.Drawing.Point(8, 11);
            this.rdbAutomatico.Name = "rdbAutomatico";
            this.rdbAutomatico.Size = new System.Drawing.Size(70, 22);
            this.rdbAutomatico.TabIndex = 0;
            this.rdbAutomatico.TabStop = true;
            this.rdbAutomatico.Text = "Auto.";
            this.rdbAutomatico.UseVisualStyleBackColor = false;
            this.rdbAutomatico.CheckedChanged += new System.EventHandler(this.rdbAutomatico_CheckedChanged);
            // 
            // btnExcluirRegistro
            // 
            this.btnExcluirRegistro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluirRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirRegistro.Location = new System.Drawing.Point(5, 348);
            this.btnExcluirRegistro.Name = "btnExcluirRegistro";
            this.btnExcluirRegistro.Size = new System.Drawing.Size(134, 40);
            this.btnExcluirRegistro.TabIndex = 3;
            this.btnExcluirRegistro.Text = "Excluir ultimo registro";
            this.btnExcluirRegistro.UseVisualStyleBackColor = false;
            this.btnExcluirRegistro.Click += new System.EventHandler(this.btnExcluirRegistro_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblValorTotal);
            this.panel3.Controls.Add(this.lblNLancamentos);
            this.panel3.Location = new System.Drawing.Point(5, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 63);
            this.panel3.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1075, 456);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnExcluirRegistro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInformacoes);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mskValor);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.txtExtrato);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Extrato);
            this.Controls.Add(this.lbl_Conteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSIDE - Nota fiscal - ACM Uirapuru";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Conteudo;
        private System.Windows.Forms.Label lbl_Extrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtExtrato;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblNLancamentos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button btnInformacoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbManual;
        private System.Windows.Forms.RadioButton rdbAutomatico;
        private System.Windows.Forms.Button btnExcluirRegistro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_chromeVersao;
        private System.Windows.Forms.Label label5;
    }
}
