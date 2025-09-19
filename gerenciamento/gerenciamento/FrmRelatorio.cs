using gerenciamento.Classe;
using MySql.Data.MySqlClient;
using iTextSharp;
using PadeSize = iTextSharp.text.PageSize;
using Font = System.Drawing.Font;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;
using Document = iTextSharp.text.Document;
using System.Diagnostics;
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
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void btnExel_Click(object sender, EventArgs e)
        {
            string endereco = "RelatorioExcel.csv";
            string pastadestino = Path.Combine(Application.StartupPath, "Relatorio");
            if (!Directory.Exists(pastadestino))
            {
                //cria o diretorio se nao existir
                Directory.CreateDirectory(pastadestino);
            }
            //combinar o arquivo com a pasta
            string caminhodestino = Path.Combine(pastadestino, endereco);
            using (StreamWriter writer = new StreamWriter
            (caminhodestino, false, Encoding.GetEncoding
            ("iso-8859-15")))
            {
                conexao comexao = new conexao();
                MySqlConnection con = comexao.getConexao();
                writer.WriteLine("Relatório Financeiro");
                writer.WriteLine("Data;Valor;Tipo");
                string entrada = @"select data_lancamento,valor,tipo from financeiro";
                MySqlCommand cmd = new MySqlCommand(entrada, con);
                con.Open();
                using (IDataReader reader = cmd.ExecuteReader())
                {
                    //enquanto tiver linha
                    while (reader.Read())
                    {
                        writer.WriteLine(Convert.ToString(reader
                        ["data_lancamento"]) + ";"
                        + Convert.ToString(reader["valor"] + ";"
                        + Convert.ToString(reader["tipo"]))
                        );
                    }
                }
                con.Close();
                MessageBox.Show("Relatorio gerado com sucesso.",
                "atenção");
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            string destinoPDF = Path.Combine(Application.StartupPath, "pdf");
            if (!Directory.Exists(destinoPDF))
            {
                Directory.CreateDirectory(destinoPDF);
            }
            string caminhoPDf = Path.Combine(destinoPDF,
            "relatorioCliente.pdf");
            Document doc = new Document(PageSize.A4);
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new
                FileStream(caminhoPDf, FileMode.Create));
                doc.Open();
                Font fonte = new Font("microsoft sans serif", 9f);
                Paragraph titulo = new Paragraph("Relatorio Financeiro");
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(""));
                conexao com = new conexao();
                com.getConexao();
                DataTable cliente = new DataTable();
                cliente = com.obterdados("select * from financeiro ");
                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 40F, 15F, 20f, 25f, 15f });
                table.AddCell(new Phrase("descrição"));
                table.AddCell(new Phrase("valor"));
                table.AddCell(new Phrase("tipo"));
                table.AddCell(new Phrase("data lancamento"));
                table.AddCell(new Phrase("pgo"));
                for (int i = 0; i < cliente.Rows.Count; i++)
                {
                    table.AddCell(new Phrase(cliente.Rows[i]
                    [1].ToString()));
                    table.AddCell(new Phrase(cliente.Rows[i]
                    [2].ToString()));
                    table.AddCell(new Phrase(cliente.Rows[i]
                    [3].ToString()));
                    table.AddCell(new Phrase(cliente.Rows[i]
                    [5].ToString()));
                    table.AddCell(new Phrase(cliente.Rows[i]
                    [6].ToString()));
                }
                doc.Add(table);
                doc.Close();
                MessageBox.Show("Relatorio foi gerado com sucesso");
                Process.Start(caminhoPDf);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o PDF", ex.Message);
            }
        }
    }
}


        
      


            
    


