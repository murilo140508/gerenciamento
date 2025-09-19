namespace gerenciamento
{
    partial class FrmFinanceiro
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
            txtDescricao = new TextBox();
            txtValor = new TextBox();
            txtPesquisar = new TextBox();
            cboTipo = new ComboBox();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnBuscar = new Button();
            txtCodigo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cboServico = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            dgvFinanceiro = new DataGridView();
            label7 = new Label();
            dtpData = new DateTimePicker();
            button1 = new Button();
            label8 = new Label();
            chkPagamento = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvFinanceiro).BeginInit();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(155, 100);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(125, 27);
            txtDescricao.TabIndex = 0;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(155, 150);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 1;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(640, 45);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(125, 27);
            txtPesquisar.TabIndex = 2;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(155, 199);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(151, 28);
            cboTipo.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(65, 370);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(165, 370);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(265, 370);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = " Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(790, 43);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(155, 57);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 60);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 9;
            label1.Text = "código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 103);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 10;
            label2.Text = "descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 153);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 11;
            label3.Text = "valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 199);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 12;
            label4.Text = "tipo";
            // 
            // cboServico
            // 
            cboServico.FormattingEnabled = true;
            cboServico.Location = new Point(155, 243);
            cboServico.Name = "cboServico";
            cboServico.Size = new Size(151, 28);
            cboServico.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 246);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 15;
            label5.Text = "serviço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(533, 48);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 16;
            label6.Text = "Pesquisar";
            // 
            // dgvFinanceiro
            // 
            dgvFinanceiro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinanceiro.Location = new Point(402, 103);
            dgvFinanceiro.Name = "dgvFinanceiro";
            dgvFinanceiro.RowHeadersWidth = 51;
            dgvFinanceiro.Size = new Size(504, 188);
            dgvFinanceiro.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 293);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 18;
            label7.Text = "Data";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(130, 293);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(250, 27);
            dtpData.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(757, 320);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "Relatorio";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 338);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 22;
            label8.Text = "pagamento";
            // 
            // chkPagamento
            // 
            chkPagamento.AutoSize = true;
            chkPagamento.Location = new Point(165, 334);
            chkPagamento.Name = "chkPagamento";
            chkPagamento.Size = new Size(128, 24);
            chkPagamento.TabIndex = 23;
            chkPagamento.Text = "chkPagamento";
            chkPagamento.UseVisualStyleBackColor = true;
            // 
            // FrmFinanceiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 472);
            Controls.Add(chkPagamento);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(dtpData);
            Controls.Add(label7);
            Controls.Add(dgvFinanceiro);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cboServico);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(btnBuscar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(cboTipo);
            Controls.Add(txtPesquisar);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            Name = "FrmFinanceiro";
            Text = "FrmFuncionario";
            Load += FrmFinanceiro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFinanceiro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescricao;
        private TextBox txtValor;
        private TextBox txtPesquisar;
        private ComboBox cboTipo;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnBuscar;
        private TextBox txtCodigo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboServico;
        private Label label5;
        private Label label6;
        private DataGridView dgvFinanceiro;
        private Label label7;
        private DateTimePicker dtpData;
        private Button button1;
        private Label label8;
        private CheckBox chkPagamento;
    }
}