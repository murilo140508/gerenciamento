using gerenciamento.Classe;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciamento
{
    public partial class FrmProduto : Form
    {
        MySqlConnection conn;
        int codigoTipo = 0;
        conexao conexao = new conexao();


        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string datasource = "datasource=localhost;username=root;password='';database=projeto";
                conn = new MySqlConnection(datasource);
                string sql = "Insert into produto(nome,descricao,tipo,valor,quantidade,foto) values(@nome,@descricao,@tipo,@valor,@quantidade,@foto)";
                MySqlCommand comando = new MySqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                comando.Parameters.AddWithValue("@tipo", codigoTipo);
                comando.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQuantidade.Text));
                comando.Parameters.AddWithValue("@valor", Convert.ToDecimal(txtValor.Text));
                comando.Parameters.AddWithValue("@foto", lblFoto.Text);
                conn.Open();
                //testar se gravou no banco de dados
                if (Convert.ToInt32(comando.ExecuteNonQuery()) == 1)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string datasource = "datasource=localhost;username=root;password='';database=projeto";
                conn = new MySqlConnection(datasource);
                string sql = "Update produto set nome=@nome,descricao=@descricao,tipo=@tipo,valor=@valor,quantidade=@quantidade,foto=@foto where codigoProduto=@codigo";
                MySqlCommand comando = new MySqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                comando.Parameters.AddWithValue("@tipo", codigoTipo);
                comando.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQuantidade.Text));
                comando.Parameters.AddWithValue("@valor", Convert.ToDecimal(txtValor.Text));
                comando.Parameters.AddWithValue("@foto", lblFoto.Text);
                comando.Parameters.AddWithValue("@codigo", Convert.ToInt32(txtCodigo.Text));
                conn.Open();
                //testar se gravou no banco de dados
                if (Convert.ToInt32(comando.ExecuteNonQuery()) == 1)
                {
                    MessageBox.Show("Produto Editado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao Editar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                {
                    string datasource = "datasource=localhost;username=root;password='';database=projeto";
                    conn = new MySqlConnection(datasource);
                    string sql = "delete from produto where codigoProduto=@codigo";
                    MySqlCommand comando = new MySqlCommand(sql, conn);
                    comando.Parameters.AddWithValue("@nome", txtNome.Text);
                    comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    comando.Parameters.AddWithValue("@tipo", codigoTipo);
                    comando.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQuantidade.Text));
                    comando.Parameters.AddWithValue("@valor", Convert.ToDecimal(txtValor.Text));
                    comando.Parameters.AddWithValue("@foto", lblFoto.Text);
                    comando.Parameters.AddWithValue("@codigo", Convert.ToInt32(txtCodigo.Text));
                    conn.Open();
                    //testar se gravou no banco de dados
                    if (Convert.ToInt32(comando.ExecuteNonQuery()) == 1)
                    {
                        MessageBox.Show("Produto Excluido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Excluir!");
                    }
                }
                else
                {
                    MessageBox.Show("Escolher um ID para excluir!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string sql;
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                sql = "select * from produto";
            }
            else
            {
                sql = "select * from produto where nome like '%" + txtNome.Text + "%'";
            }
            conexao conexao = new conexao();
            dgvProduto.DataSource = conexao.obterdados(sql);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem| *.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Selecione a Imagem do Produto";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhocompletofotooriginal = openFileDialog.FileName;
                string nomeArquivo = Path.GetFileName(caminhocompletofotooriginal);
                string pastaDestino = Path.Combine(Application.StartupPath, "Produto");
                if (!Directory.Exists(pastaDestino))
                {
                    Directory.CreateDirectory(pastaDestino);

                }
                string caminhodestino = Path.Combine(pastaDestino, nomeArquivo);
                try
                {
                    File.Copy(caminhocompletofotooriginal, caminhodestino, true);
                    lblFoto.Text = Path.Combine("Produto", nomeArquivo);
                    Foto.Image = System.Drawing.Image.FromFile(lblFoto.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao copiar a imagem:{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFoto.Text = "";
                }
            }
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            conexao conexao = new conexao();
            conexao.getConexao();
            cboTipo.DataSource = conexao.obterdados("select codigotipo,descricao from tipo");
            cboTipo.ValueMember = "codigotipo";
            cboTipo.DisplayMember = "descricao";
            dgvProduto.DataSource = conexao.obterdados("select * from produto");
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoTipo = Convert.ToInt32(((DataRowView)cboTipo.SelectedItem)["codigotipo"]);
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int codigo = 0;
            codigo = Convert.ToInt32(dgvProduto.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            txtCodigo.Text = codigo.ToString();
            txtNome.Text = dgvProduto.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtDescricao.Text = dgvProduto.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            cboTipo.Text = dgvProduto.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
            txtQuantidade.Text = dgvProduto.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString();
            txtValor.Text = dgvProduto.Rows[e.RowIndex].Cells["Valor"].Value.ToString();
            Foto.Image = Image.FromFile(dgvProduto.Rows[e.RowIndex].Cells["Foto"].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("teste");
        }
    }
}
