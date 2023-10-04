namespace Veri_Tabanılı_Parti_Seçim_Grafik_İstatistik
{
    partial class frmgrafikler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBLA = new System.Windows.Forms.Label();
            this.LBLB = new System.Windows.Forms.Label();
            this.LBLC = new System.Windows.Forms.Label();
            this.LBLD = new System.Windows.Forms.Label();
            this.LBLE = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRAFİKLER";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 27);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "partiler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(624, 259);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.LBLE);
            this.groupBox2.Controls.Add(this.LBLD);
            this.groupBox2.Controls.Add(this.LBLC);
            this.groupBox2.Controls.Add(this.LBLB);
            this.groupBox2.Controls.Add(this.LBLA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İLÇE DEĞERLERİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlce Seçin:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "B PARTİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "C PARTİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "D PARTİ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "E PARTİ:";
            // 
            // LBLA
            // 
            this.LBLA.AutoSize = true;
            this.LBLA.Location = new System.Drawing.Point(459, 69);
            this.LBLA.Name = "LBLA";
            this.LBLA.Size = new System.Drawing.Size(24, 25);
            this.LBLA.TabIndex = 12;
            this.LBLA.Text = "0";
            // 
            // LBLB
            // 
            this.LBLB.AutoSize = true;
            this.LBLB.Location = new System.Drawing.Point(459, 109);
            this.LBLB.Name = "LBLB";
            this.LBLB.Size = new System.Drawing.Size(24, 25);
            this.LBLB.TabIndex = 13;
            this.LBLB.Text = "0";
            // 
            // LBLC
            // 
            this.LBLC.AutoSize = true;
            this.LBLC.Location = new System.Drawing.Point(458, 146);
            this.LBLC.Name = "LBLC";
            this.LBLC.Size = new System.Drawing.Size(24, 25);
            this.LBLC.TabIndex = 14;
            this.LBLC.Text = "0";
            // 
            // LBLD
            // 
            this.LBLD.AutoSize = true;
            this.LBLD.Location = new System.Drawing.Point(459, 183);
            this.LBLD.Name = "LBLD";
            this.LBLD.Size = new System.Drawing.Size(24, 25);
            this.LBLD.TabIndex = 15;
            this.LBLD.Text = "0";
            // 
            // LBLE
            // 
            this.LBLE.AutoSize = true;
            this.LBLE.Location = new System.Drawing.Point(458, 220);
            this.LBLE.Name = "LBLE";
            this.LBLE.Size = new System.Drawing.Size(24, 25);
            this.LBLE.TabIndex = 16;
            this.LBLE.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(127, 69);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(326, 31);
            this.progressBar1.TabIndex = 17;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(127, 106);
            this.progressBar2.Maximum = 200;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(326, 31);
            this.progressBar2.TabIndex = 18;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(128, 143);
            this.progressBar3.Maximum = 200;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(326, 31);
            this.progressBar3.TabIndex = 19;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(127, 180);
            this.progressBar4.Maximum = 200;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(326, 31);
            this.progressBar4.TabIndex = 20;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(128, 217);
            this.progressBar5.Maximum = 200;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(326, 31);
            this.progressBar5.TabIndex = 21;
            // 
            // frmgrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmgrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmgrafikler";
            this.Load += new System.EventHandler(this.frmgrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LBLE;
        private System.Windows.Forms.Label LBLD;
        private System.Windows.Forms.Label LBLC;
        private System.Windows.Forms.Label LBLB;
        private System.Windows.Forms.Label LBLA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar5;
    }
}