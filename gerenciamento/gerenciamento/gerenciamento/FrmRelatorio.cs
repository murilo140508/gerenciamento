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
using System.Windows.Forms.DataVisualization.Charting;
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
        DataTable dtMovimentaçoes;
        conexao com = new conexao();
        public FrmRelatorio()
        {
            InitializeComponent();
            configurarChart();
        }
        private void configurarChart()
        {
            Chart chartFluxoCaixa = new Chart();
            fluxoCaixa.Titles.Clear();
            fluxoCaixa.Series.Clear();
            fluxoCaixa.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea("MainArea");
            fluxoCaixa.ChartAreas.Add(chartArea);
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGreen;
            chartArea.AxisY.LabelStyle.Format = "C2";
            chartArea.AxisY.Title = "valor(R$)";
            chartArea.AxisX.Title = "Periodo";

            Series seriesEntrada = new Series("Entrada");
            seriesEntrada.ChartType = SeriesChartType.Column;
            seriesEntrada.Color = Color.Green;
            seriesEntrada.IsValueShownAsLabel = true;
            seriesEntrada.LabelFormat = "C2";
            fluxoCaixa.Series.Add(seriesEntrada);

            Series seriesSaida = new Series("Saida");
            seriesSaida.ChartType = SeriesChartType.Column;
            seriesSaida.Color = Color.Red;
            seriesSaida.IsValueShownAsLabel = true;
            seriesSaida.LabelFormat = "C2";
            fluxoCaixa.Series.Add(seriesSaida);

            Series seriesSaldo = new Series("Saldo");
            seriesSaldo.ChartType = SeriesChartType.Line;
            seriesSaldo.Color = Color.Blue;
            seriesSaldo.BorderWidth = 3;
            seriesSaida.IsValueShownAsLabel = true;
            seriesSaida.LabelFormat = "C2";
            fluxoCaixa.Series.Add(seriesSaldo);
        }
        private void GerarRelatorio()
        {
            DataTable dtMovimentacao= new DataTable();
            com.getConexao();
            try
            {
                com.getConexao();
                string query = "Select data_lancamento AS Data, valor, tipo from financeiro";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, com.conexaoProjeto);
                adapter.Fill(dtMovimentacao);
                ProcessarDadosparaGraficos(dtMovimentacao);
                MessageBox.Show("Relatorio gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar: {ex.Message}","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProcessarDadosparaGraficos(DataTable dados)
        {
            foreach (var series in fluxoCaixa.Series)
            {
                series.Points.Clear();
            }
            decimal totalEntradasGeral = 0;
            decimal totalSaidasGeral = 0;
            // Agrupa os dados por dia ou mês
            var grupos = dados.AsEnumerable().GroupBy(row =>
            {
                DateTime data = row.Field<DateTime>("Data");
                return data.Date; // Agrupa por dia
            })
            .OrderBy(g => g.Key); // Ordena os grupos pela data
            foreach (var grupo in grupos)
            {
                string label;
                label = grupo.Key.ToString("dd/MM"); // Ex: 01/07
                decimal entradas = grupo.Where(r => r.Field<string>
                ("Tipo") == "Entrada").Sum(r => r.Field<decimal>
                ("Valor"));
                decimal saidas = grupo.Where(r => r.Field<string>
                ("Tipo") == "Saida").Sum(r => r.Field<decimal>
                ("Valor"));
                decimal saldo = entradas - saidas;
                fluxoCaixa.Series["Entradas"].Points.AddXY(label,
                entradas);
                fluxoCaixa.Series["Saídas"].Points.AddXY(label,
                saidas);
                fluxoCaixa.Series["Saldo"].Points.AddXY(label, saldo);
                totalEntradasGeral += entradas;
                totalSaidasGeral += saidas;
            }
            string tituloGrafico = "Fluxo de Caixa Diario";
            fluxoCaixa.Titles.Clear();  
            fluxoCaixa.Titles.Add(tituloGrafico);
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

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            GerarRelatorio();
        }
    }
}


        
      


            
    


