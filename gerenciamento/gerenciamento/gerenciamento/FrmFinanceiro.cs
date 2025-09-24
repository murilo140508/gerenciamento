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
    public partial class FrmFinanceiro : Form
    {

        public FrmFinanceiro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            con.getConexao();
            //chamando o objeto financeiro
            financeiro fin = new financeiro();
            //populando as informações
            fin.data_lancamento = dtpData.Value;
            fin.descricao = txtDescricao.Text;
            fin.servico = cboServico.Text;
            fin.valor = decimal.Parse(txtValor.Text);
            fin.tipo = cboTipo.Text;
            fin.pgto = chkPagamento.Checked;
            if (fin.cadastrar(con) == true)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            conexao com = new conexao();
            financeiro financeiro = new financeiro();
            financeiro.id = Convert.ToInt32(txtCodigo.Text);
            financeiro.descricao = txtDescricao.Text;
            financeiro.servico = cboServico.Text;
            financeiro.tipo = cboTipo.Text;
            financeiro.valor = decimal.Parse(txtValor.Text);
            financeiro.pgto = chkPagamento.Checked;
            financeiro.data_lancamento = dtpData.Value;
            if (financeiro.editar(com) == true)
            {
                MessageBox.Show("Editado com sucesso!");
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void FrmFinanceiro_Load(object sender, EventArgs e)
        {
            conexao com = new conexao();
            com.getConexao();
            dgvFinanceiro.DataSource = com.obterdados("select * from financeiro");
            cboServico.Items.Add("Salário");
            cboServico.Items.Add("despesas");
            cboTipo.Items.Add("Entrada");
            cboTipo.Items.Add("Saída");
        }
    }
}


