using gerenciamento.Classe;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace gerenciamento
{
    public partial class FrmFuncionario : Form
    {
        conexao com= new conexao();
        int idcargo;
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                com.getConexao();
                string sql = "insert into funcionario(nome,email,senha,salario,cargo) values (@nome,@email,@senha,@salario,@cargo)";
                MySqlCommand command = new MySqlCommand(sql, com.conexaoProjeto);
                string senha = txtSenha.Text.ToString();
                string senhahash = BCrypt.Net.BCrypt.HashPassword(senha);

                command.Parameters.AddWithValue("nome", txtNome.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@senha", senhahash);
                command.Parameters.AddWithValue("@salario", txtSalario.Text);
                command.Parameters.AddWithValue("@cargo", idcargo);
                com.conexaoProjeto.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Cadasro com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro");
                }
                com.conexaoProjeto.Close();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                com.getConexao();
                string sql = "Update funcionario set nome=@nome,email=@email,senha=@senha,salario=@salario,cargo=@cargo where codigo=@id";
                MySqlCommand command = new MySqlCommand(sql, com.conexaoProjeto);
                string senha = txtSenha.Text.ToString();
                string senhahash = BCrypt.Net.BCrypt.HashPassword(senha);

                command.Parameters.AddWithValue("nome", txtNome.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@senha", senhahash);
                command.Parameters.AddWithValue("@salario", txtSalario.Text);
                command.Parameters.AddWithValue("@cargo", idcargo);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(txtCodigo.Text));
                com.conexaoProjeto.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Editado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao Editar");
                }
                com.conexaoProjeto.Close();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    com.getConexao();
                    string sql = "Delete from funcionario where codigo=@id";
                    MySqlCommand command = new MySqlCommand(sql, com.conexaoProjeto);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(txtCodigo.Text));
                    com.conexaoProjeto.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Excluido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Excluir");
                    }
                    com.conexaoProjeto.Close();
                }
                else
                {
                    MessageBox.Show("Campo codigo está vazio");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            cboCargo.DataSource = obterDados("Select * from cargo");
            cboCargo.ValueMember = "codigocargo";
            cboCargo.DisplayMember = "cargo";
            dgvFuncionario.DataSource = obterDados("select * from funcionario");
        }

        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idcargo = Convert.ToInt32(((DataRowView)cboCargo.SelectedItem)["codigocargo"]);
        }
        public DataTable obterDados(string sql)
        {
            com.getConexao();
            DataTable dt = new DataTable();
            MySqlCommand comando = new MySqlCommand(sql, com.conexaoProjeto);
            com.conexaoProjeto.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(dt);
            com.conexaoProjeto.Close();
            return dt;
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = 0;
            codigo = Convert.ToInt32(dgvFuncionario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            txtCodigo.Text = codigo.ToString();
            txtNome.Text = dgvFuncionario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtEmail.Text = dgvFuncionario.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtSenha.Text = dgvFuncionario.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            txtSalario.Text = dgvFuncionario.Rows[e.RowIndex].Cells["salario"].Value.ToString();
            cboCargo.Text = dgvFuncionario.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
            bool ativo = Convert.ToBoolean(dgvFuncionario.Rows[e.RowIndex].Cells["ativo"].Value);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("teste");
        }
    }
}
