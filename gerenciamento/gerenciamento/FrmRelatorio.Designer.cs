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
            btnExel = new Button();
            btnPDF = new Button();
            SuspendLayout();
            // 
            // btnExel
            // 
            btnExel.Location = new Point(221, 91);
            btnExel.Name = "btnExel";
            btnExel.Size = new Size(94, 29);
            btnExel.TabIndex = 0;
            btnExel.Text = "Exel";
            btnExel.UseVisualStyleBackColor = true;
            btnExel.Click += btnExel_Click;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(354, 91);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(94, 29);
            btnPDF.TabIndex = 1;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // FrmRelatorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPDF);
            Controls.Add(btnExel);
            Name = "FrmRelatorio";
            Text = "FrmRelatorio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExel;
        private Button btnPDF;
    }
}