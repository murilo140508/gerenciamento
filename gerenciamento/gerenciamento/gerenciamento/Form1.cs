using gerenciamento.Classe;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = Sessaofuncionario.funcionarioLogador;
            toolStripLabel2.Text = Sessaofuncionario.Cargofuncionario.ToString();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.MdiParent = this;
            funcionario.Show();
        }

        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFinanceiro financeiro = new FrmFinanceiro();
            financeiro.MdiParent = this;
            financeiro.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto produto = new FrmProduto();
            produto.MdiParent = this;
            produto.Show();
        }
    }
}
