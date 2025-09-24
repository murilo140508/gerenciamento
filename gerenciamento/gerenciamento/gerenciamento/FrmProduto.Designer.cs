namespace gerenciamento
{
    partial class FrmProduto
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
            btnFoto = new Button();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnCadastrar = new Button();
            cboTipo = new ComboBox();
            txtQuantidade = new TextBox();
            txtValor = new TextBox();
            txtDescricao = new TextBox();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            dgvProduto = new DataGridView();
            Foto = new PictureBox();
            label8 = new Label();
            lblFoto = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Foto).BeginInit();
            SuspendLayout();
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(596, 5);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(94, 29);
            btnFoto.TabIndex = 42;
            btnFoto.Text = "Adicionar foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(345, 254);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 41;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(245, 254);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 40;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(145, 254);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 39;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(45, 254);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 38;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(151, 193);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(151, 28);
            cboTipo.TabIndex = 37;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(151, 156);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(125, 27);
            txtQuantidade.TabIndex = 36;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(151, 120);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 35;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(151, 85);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(125, 27);
            txtDescricao.TabIndex = 34;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(151, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 33;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(151, 23);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 32;
            // 
            // dgvProduto
            // 
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Location = new Point(115, 303);
            dgvProduto.Name = "dgvProduto";
            dgvProduto.RowHeadersWidth = 51;
            dgvProduto.Size = new Size(614, 143);
            dgvProduto.TabIndex = 31;
            dgvProduto.CellContentClick += dgvProduto_CellContentClick;
            // 
            // Foto
            // 
            Foto.Location = new Point(476, 43);
            Foto.Name = "Foto";
            Foto.Size = new Size(280, 195);
            Foto.TabIndex = 30;
            Foto.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(569, 258);
            label8.Name = "label8";
            label8.Size = new Size(121, 20);
            label8.TabIndex = 29;
            label8.Text = "Caminho da foto";
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Location = new Point(513, 9);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(39, 20);
            lblFoto.TabIndex = 28;
            lblFoto.Text = "Foto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 196);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 27;
            label6.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 159);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 26;
            label5.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 123);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 25;
            label4.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 88);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 24;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 58);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 23;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 26);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 22;
            label1.Text = "Codigo";
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFoto);
            Controls.Add(btnPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(cboTipo);
            Controls.Add(txtQuantidade);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(dgvProduto);
            Controls.Add(Foto);
            Controls.Add(label8);
            Controls.Add(lblFoto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Foto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFoto;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnCadastrar;
        private ComboBox cboTipo;
        private TextBox txtQuantidade;
        private TextBox txtValor;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private DataGridView dgvProduto;
        private PictureBox Foto;
        private Label label8;
        private Label lblFoto;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}