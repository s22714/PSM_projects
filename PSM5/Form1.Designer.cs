namespace PSM5
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartButton = new System.Windows.Forms.Button();
            this.AllT = new System.Windows.Forms.NumericUpDown();
            this.T = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScalePick = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GalChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScalePick)).BeginInit();
            this.SuspendLayout();
            // 
            // GalChart
            // 
            this.GalChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.GalChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.GalChart.Legends.Add(legend6);
            this.GalChart.Location = new System.Drawing.Point(12, 12);
            this.GalChart.Name = "GalChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.GalChart.Series.Add(series6);
            this.GalChart.Size = new System.Drawing.Size(731, 522);
            this.GalChart.TabIndex = 0;
            this.GalChart.Text = "chart1";
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(750, 102);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(139, 90);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "CALC";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // AllT
            // 
            this.AllT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AllT.DecimalPlaces = 2;
            this.AllT.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AllT.Location = new System.Drawing.Point(769, 30);
            this.AllT.Maximum = new decimal(new int[] {
            1565880362,
            2,
            0,
            131072});
            this.AllT.Name = "AllT";
            this.AllT.Size = new System.Drawing.Size(120, 20);
            this.AllT.TabIndex = 2;
            this.AllT.Value = new decimal(new int[] {
            -1031152342,
            0,
            0,
            131072});
            // 
            // T
            // 
            this.T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.T.AutoSize = true;
            this.T.Location = new System.Drawing.Point(766, 14);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(14, 13);
            this.T.TabIndex = 5;
            this.T.Text = "T";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "SCALE";
            // 
            // ScalePick
            // 
            this.ScalePick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScalePick.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ScalePick.Location = new System.Drawing.Point(769, 76);
            this.ScalePick.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ScalePick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScalePick.Name = "ScalePick";
            this.ScalePick.Size = new System.Drawing.Size(120, 20);
            this.ScalePick.TabIndex = 6;
            this.ScalePick.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScalePick);
            this.Controls.Add(this.T);
            this.Controls.Add(this.AllT);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GalChart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GalChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScalePick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GalChart;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown AllT;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ScalePick;
    }
}

