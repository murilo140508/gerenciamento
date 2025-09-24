namespace gerenciamento
{
    partial class FrmRelatorio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnExel = new Button();
            btnPDF = new Button();
            fluxoCaixa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)fluxoCaixa).BeginInit();
            SuspendLayout();
            // 
            // btnExel
            // 
            btnExel.Location = new Point(617, 47);
            btnExel.Name = "btnExel";
            btnExel.Size = new Size(94, 29);
            btnExel.TabIndex = 0;
            btnExel.Text = "Exel";
            btnExel.UseVisualStyleBackColor = true;
            btnExel.Click += btnExel_Click;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(617, 93);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(94, 29);
            btnPDF.TabIndex = 1;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // fluxoCaixa
            // 
            chartArea1.Name = "ChartArea1";
            fluxoCaixa.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            fluxoCaixa.Legends.Add(legend1);
            fluxoCaixa.Location = new Point(185, 47);
            fluxoCaixa.Name = "fluxoCaixa";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            fluxoCaixa.Series.Add(series1);
            fluxoCaixa.Size = new Size(375, 375);
            fluxoCaixa.TabIndex = 2;
            fluxoCaixa.Text = "chart1";
            // 
            // FrmRelatorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fluxoCaixa);
            Controls.Add(btnPDF);
            Controls.Add(btnExel);
            Name = "FrmRelatorio";
            Text = "FrmRelatorio";
            Load += FrmRelatorio_Load;
            ((System.ComponentModel.ISupportInitialize)fluxoCaixa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExel;
        private Button btnPDF;
        private System.Windows.Forms.DataVisualization.Charting.Chart fluxoCaixa;
    }
}