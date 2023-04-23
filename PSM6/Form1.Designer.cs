namespace PSM6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.EulerString = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LPick = new System.Windows.Forms.NumericUpDown();
            this.NPick = new System.Windows.Forms.NumericUpDown();
            this.DtPick = new System.Windows.Forms.NumericUpDown();
            this.LpowPick = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.EulerEnergy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BetterEulerEnergy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BetterEulerString = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.EulerString)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LPick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtPick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LpowPick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EulerEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetterEulerEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetterEulerString)).BeginInit();
            this.SuspendLayout();
            // 
            // EulerString
            // 
            chartArea1.Name = "ChartArea1";
            this.EulerString.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.EulerString.Legends.Add(legend1);
            this.EulerString.Location = new System.Drawing.Point(13, 13);
            this.EulerString.Name = "EulerString";
            this.EulerString.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.EulerString.Series.Add(series1);
            this.EulerString.Size = new System.Drawing.Size(608, 425);
            this.EulerString.TabIndex = 0;
            this.EulerString.Text = "chart1";
            // 
            // LPick
            // 
            this.LPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LPick.DecimalPlaces = 30;
            this.LPick.Location = new System.Drawing.Point(1288, 13);
            this.LPick.Name = "LPick";
            this.LPick.Size = new System.Drawing.Size(120, 20);
            this.LPick.TabIndex = 1;
            // 
            // NPick
            // 
            this.NPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NPick.Location = new System.Drawing.Point(1288, 39);
            this.NPick.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NPick.Name = "NPick";
            this.NPick.Size = new System.Drawing.Size(120, 20);
            this.NPick.TabIndex = 2;
            this.NPick.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // DtPick
            // 
            this.DtPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtPick.DecimalPlaces = 5;
            this.DtPick.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.DtPick.Location = new System.Drawing.Point(1288, 65);
            this.DtPick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.DtPick.Name = "DtPick";
            this.DtPick.Size = new System.Drawing.Size(120, 20);
            this.DtPick.TabIndex = 3;
            this.DtPick.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // LpowPick
            // 
            this.LpowPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LpowPick.Location = new System.Drawing.Point(1288, 91);
            this.LpowPick.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LpowPick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LpowPick.Name = "LpowPick";
            this.LpowPick.Size = new System.Drawing.Size(120, 20);
            this.LpowPick.TabIndex = 4;
            this.LpowPick.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1247, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "L";
            // 
            // N
            // 
            this.N.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(1247, 41);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(13, 13);
            this.N.TabIndex = 6;
            this.N.Text = "n";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1247, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "dt";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1247, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "l pow";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.Location = new System.Drawing.Point(1250, 118);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(157, 47);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // EulerEnergy
            // 
            chartArea2.Name = "ChartArea1";
            this.EulerEnergy.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.EulerEnergy.Legends.Add(legend2);
            this.EulerEnergy.Location = new System.Drawing.Point(627, 12);
            this.EulerEnergy.Name = "EulerEnergy";
            this.EulerEnergy.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.EulerEnergy.Series.Add(series2);
            this.EulerEnergy.Size = new System.Drawing.Size(608, 425);
            this.EulerEnergy.TabIndex = 10;
            this.EulerEnergy.Text = "chart2";
            // 
            // BetterEulerEnergy
            // 
            chartArea3.Name = "ChartArea1";
            this.BetterEulerEnergy.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.BetterEulerEnergy.Legends.Add(legend3);
            this.BetterEulerEnergy.Location = new System.Drawing.Point(627, 443);
            this.BetterEulerEnergy.Name = "BetterEulerEnergy";
            this.BetterEulerEnergy.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.BetterEulerEnergy.Series.Add(series3);
            this.BetterEulerEnergy.Size = new System.Drawing.Size(608, 425);
            this.BetterEulerEnergy.TabIndex = 12;
            this.BetterEulerEnergy.Text = "chart3";
            // 
            // BetterEulerString
            // 
            chartArea4.Name = "ChartArea1";
            this.BetterEulerString.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.BetterEulerString.Legends.Add(legend4);
            this.BetterEulerString.Location = new System.Drawing.Point(13, 444);
            this.BetterEulerString.Name = "BetterEulerString";
            this.BetterEulerString.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.BetterEulerString.Series.Add(series4);
            this.BetterEulerString.Size = new System.Drawing.Size(608, 425);
            this.BetterEulerString.TabIndex = 11;
            this.BetterEulerString.Text = "chart4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 883);
            this.Controls.Add(this.BetterEulerEnergy);
            this.Controls.Add(this.BetterEulerString);
            this.Controls.Add(this.EulerEnergy);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.N);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LpowPick);
            this.Controls.Add(this.DtPick);
            this.Controls.Add(this.NPick);
            this.Controls.Add(this.LPick);
            this.Controls.Add(this.EulerString);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EulerString)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LPick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtPick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LpowPick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EulerEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetterEulerEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetterEulerString)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart EulerString;
        private System.Windows.Forms.NumericUpDown LPick;
        private System.Windows.Forms.NumericUpDown NPick;
        private System.Windows.Forms.NumericUpDown DtPick;
        private System.Windows.Forms.NumericUpDown LpowPick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart EulerEnergy;
        private System.Windows.Forms.DataVisualization.Charting.Chart BetterEulerEnergy;
        private System.Windows.Forms.DataVisualization.Charting.Chart BetterEulerString;
    }
}

