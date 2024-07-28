﻿namespace Sistema_Vendas.view
{
    partial class FCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCliente));
            panel1 = new Panel();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            botaoNovo = new ToolStripButton();
            botaoSalvar = new ToolStripButton();
            botaoExcluir = new ToolStripButton();
            botaoEditar = new ToolStripButton();
            botaoImprimir = new ToolStripButton();
            botaoFechar = new ToolStripButton();
            tabControl1 = new TabControl();
            tabPesquisa = new TabPage();
            dataGridView1 = new DataGridView();
            idcliente = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            cpf_cnpj = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            logradouro = new DataGridViewTextBoxColumn();
            bairro = new DataGridViewTextBoxColumn();
            cidade = new DataGridViewTextBoxColumn();
            uf = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            botaoPesquisar = new Button();
            txtPesquisar = new TextBox();
            tabDados = new TabPage();
            txtUF = new ComboBox();
            label10 = new Label();
            txtCidade = new TextBox();
            label9 = new Label();
            txtBairro = new TextBox();
            label8 = new Label();
            txtLogradouro = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtTelefone = new MaskedTextBox();
            label5 = new Label();
            txtCPF = new MaskedTextBox();
            label4 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            tabDados.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 38);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Clientes";
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { botaoNovo, botaoSalvar, botaoExcluir, botaoEditar, botaoImprimir, botaoFechar });
            toolStrip1.Location = new Point(0, 38);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(808, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // botaoNovo
            // 
            botaoNovo.Image = (Image)resources.GetObject("botaoNovo.Image");
            botaoNovo.ImageTransparentColor = Color.Magenta;
            botaoNovo.Name = "botaoNovo";
            botaoNovo.Size = new Size(68, 25);
            botaoNovo.Text = "&Novo";
            botaoNovo.Click += botaoNovo_Click;
            // 
            // botaoSalvar
            // 
            botaoSalvar.Image = (Image)resources.GetObject("botaoSalvar.Image");
            botaoSalvar.ImageTransparentColor = Color.Magenta;
            botaoSalvar.Name = "botaoSalvar";
            botaoSalvar.Size = new Size(73, 25);
            botaoSalvar.Text = "&Salvar";
            botaoSalvar.Click += botaoSalvar_Click;
            // 
            // botaoExcluir
            // 
            botaoExcluir.Image = (Image)resources.GetObject("botaoExcluir.Image");
            botaoExcluir.ImageTransparentColor = Color.Magenta;
            botaoExcluir.Name = "botaoExcluir";
            botaoExcluir.Size = new Size(75, 25);
            botaoExcluir.Text = "&Excluir";
            botaoExcluir.Click += botaoExcluir_Click;
            // 
            // botaoEditar
            // 
            botaoEditar.Image = (Image)resources.GetObject("botaoEditar.Image");
            botaoEditar.ImageTransparentColor = Color.Magenta;
            botaoEditar.Name = "botaoEditar";
            botaoEditar.Size = new Size(70, 25);
            botaoEditar.Text = "E&ditar";
            botaoEditar.Click += botaoEditar_Click;
            // 
            // botaoImprimir
            // 
            botaoImprimir.Image = (Image)resources.GetObject("botaoImprimir.Image");
            botaoImprimir.ImageTransparentColor = Color.Magenta;
            botaoImprimir.Name = "botaoImprimir";
            botaoImprimir.Size = new Size(91, 25);
            botaoImprimir.Text = "&Imprimir";
            // 
            // botaoFechar
            // 
            botaoFechar.Alignment = ToolStripItemAlignment.Right;
            botaoFechar.Image = (Image)resources.GetObject("botaoFechar.Image");
            botaoFechar.ImageTransparentColor = Color.Magenta;
            botaoFechar.Name = "botaoFechar";
            botaoFechar.Size = new Size(76, 25);
            botaoFechar.Text = "&Fechar";
            botaoFechar.Click += botaoFechar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPesquisa);
            tabControl1.Controls.Add(tabDados);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 66);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(808, 390);
            tabControl1.TabIndex = 2;
            // 
            // tabPesquisa
            // 
            tabPesquisa.Controls.Add(dataGridView1);
            tabPesquisa.Controls.Add(panel2);
            tabPesquisa.Location = new Point(4, 30);
            tabPesquisa.Name = "tabPesquisa";
            tabPesquisa.Padding = new Padding(3);
            tabPesquisa.Size = new Size(800, 356);
            tabPesquisa.TabIndex = 0;
            tabPesquisa.Text = "Pesquisar";
            tabPesquisa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idcliente, nome, cpf_cnpj, telefone, email, logradouro, bairro, cidade, uf });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(794, 296);
            dataGridView1.TabIndex = 1;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // idcliente
            // 
            idcliente.DataPropertyName = "idcliente";
            idcliente.HeaderText = "ID";
            idcliente.Name = "idcliente";
            idcliente.ReadOnly = true;
            idcliente.Width = 50;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 150;
            // 
            // cpf_cnpj
            // 
            cpf_cnpj.DataPropertyName = "cpf_cnpj";
            cpf_cnpj.HeaderText = "CPF";
            cpf_cnpj.Name = "cpf_cnpj";
            cpf_cnpj.ReadOnly = true;
            cpf_cnpj.Width = 80;
            // 
            // telefone
            // 
            telefone.DataPropertyName = "telefone";
            telefone.HeaderText = "Telefone";
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            telefone.Width = 80;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // logradouro
            // 
            logradouro.DataPropertyName = "logradouro";
            logradouro.HeaderText = "Logradouro";
            logradouro.Name = "logradouro";
            logradouro.ReadOnly = true;
            // 
            // bairro
            // 
            bairro.DataPropertyName = "bairro";
            bairro.HeaderText = "Bairro";
            bairro.Name = "bairro";
            bairro.ReadOnly = true;
            // 
            // cidade
            // 
            cidade.DataPropertyName = "cidade";
            cidade.HeaderText = "Cidade";
            cidade.Name = "cidade";
            cidade.ReadOnly = true;
            // 
            // uf
            // 
            uf.DataPropertyName = "uf";
            uf.HeaderText = "UF";
            uf.Name = "uf";
            uf.ReadOnly = true;
            uf.Width = 50;
            // 
            // panel2
            // 
            panel2.Controls.Add(botaoPesquisar);
            panel2.Controls.Add(txtPesquisar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 54);
            panel2.TabIndex = 0;
            // 
            // botaoPesquisar
            // 
            botaoPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botaoPesquisar.Image = (Image)resources.GetObject("botaoPesquisar.Image");
            botaoPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            botaoPesquisar.Location = new Point(664, 11);
            botaoPesquisar.Name = "botaoPesquisar";
            botaoPesquisar.Size = new Size(109, 36);
            botaoPesquisar.TabIndex = 1;
            botaoPesquisar.Text = "&Pesquisar";
            botaoPesquisar.TextAlign = ContentAlignment.MiddleRight;
            botaoPesquisar.UseVisualStyleBackColor = true;
            botaoPesquisar.Click += botaoPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisar.Location = new Point(15, 16);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(643, 29);
            txtPesquisar.TabIndex = 0;
            // 
            // tabDados
            // 
            tabDados.Controls.Add(txtUF);
            tabDados.Controls.Add(label10);
            tabDados.Controls.Add(txtCidade);
            tabDados.Controls.Add(label9);
            tabDados.Controls.Add(txtBairro);
            tabDados.Controls.Add(label8);
            tabDados.Controls.Add(txtLogradouro);
            tabDados.Controls.Add(label7);
            tabDados.Controls.Add(txtEmail);
            tabDados.Controls.Add(label6);
            tabDados.Controls.Add(txtTelefone);
            tabDados.Controls.Add(label5);
            tabDados.Controls.Add(txtCPF);
            tabDados.Controls.Add(label4);
            tabDados.Controls.Add(txtNome);
            tabDados.Controls.Add(label3);
            tabDados.Controls.Add(txtID);
            tabDados.Controls.Add(label2);
            tabDados.Location = new Point(4, 30);
            tabDados.Name = "tabDados";
            tabDados.Padding = new Padding(3);
            tabDados.Size = new Size(800, 356);
            tabDados.TabIndex = 1;
            tabDados.Text = "Dados Gerais";
            tabDados.UseVisualStyleBackColor = true;
            // 
            // txtUF
            // 
            txtUF.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUF.FormattingEnabled = true;
            txtUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            txtUF.Location = new Point(102, 301);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(104, 29);
            txtUF.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(72, 304);
            label10.Name = "label10";
            label10.Size = new Size(32, 21);
            label10.TabIndex = 16;
            label10.Text = "UF:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(102, 266);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(357, 29);
            txtCidade.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 269);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 14;
            label9.Text = "Cidade:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(102, 231);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(357, 29);
            txtBairro.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 234);
            label8.Name = "label8";
            label8.Size = new Size(55, 21);
            label8.TabIndex = 12;
            label8.Text = "Bairro:";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(102, 196);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(357, 29);
            txtLogradouro.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 199);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 10;
            label7.Text = "Logradouro:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(102, 161);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(357, 29);
            txtEmail.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 164);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 8;
            label6.Text = "Email:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(102, 126);
            txtTelefone.Mask = "(##) #####-####";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(125, 29);
            txtTelefone.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 129);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 6;
            label5.Text = "Telefone:";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(102, 91);
            txtCPF.Mask = "###,###,###-##";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(125, 29);
            txtCPF.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 95);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 4;
            label4.Text = "CPF:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(102, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(357, 29);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 59);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // txtID
            // 
            txtID.Location = new Point(102, 21);
            txtID.Name = "txtID";
            txtID.Size = new Size(71, 29);
            txtID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 24);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 0;
            label2.Text = "ID: ";
            // 
            // FCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 456);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FCliente";
            Text = "FCliente";
            Load += FCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabDados.ResumeLayout(false);
            tabDados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton botaoNovo;
        private ToolStripButton botaoSalvar;
        private ToolStripButton botaoExcluir;
        private ToolStripButton botaoEditar;
        private ToolStripButton botaoImprimir;
        private ToolStripButton botaoFechar;
        private TabControl tabControl1;
        private TabPage tabPesquisa;
        private TabPage tabDados;
        private Panel panel2;
        private Button botaoPesquisar;
        private TextBox txtPesquisar;
        private DataGridView dataGridView1;
        private MaskedTextBox txtCPF;
        private Label label4;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private TextBox txtEmail;
        private Label label6;
        private MaskedTextBox txtTelefone;
        private Label label5;
        private TextBox txtLogradouro;
        private Label label7;
        private ComboBox txtUF;
        private Label label10;
        private TextBox txtCidade;
        private Label label9;
        private TextBox txtBairro;
        private Label label8;
        private DataGridViewTextBoxColumn idcliente;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpf_cnpj;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn logradouro;
        private DataGridViewTextBoxColumn bairro;
        private DataGridViewTextBoxColumn cidade;
        private DataGridViewTextBoxColumn uf;
    }
}