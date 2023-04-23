namespace PSM2
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.qpick = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gxpick = new System.Windows.Forms.NumericUpDown();
            this.gypick = new System.Windows.Forms.NumericUpDown();
            this.mpick = new System.Windows.Forms.NumericUpDown();
            this.dtpick = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SxPicker = new System.Windows.Forms.NumericUpDown();
            this.SyPicker = new System.Windows.Forms.NumericUpDown();
            this.VxPicker = new System.Windows.Forms.NumericUpDown();
            this.VyPicker = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qpick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gxpick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gypick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SxPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SyPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VxPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VyPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(867, 451);
            this.chart1.TabIndex = 0;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            this.chart1.Layout += new System.Windows.Forms.LayoutEventHandler(this.chart1_Layout);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(886, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // qpick
            // 
            this.qpick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qpick.DecimalPlaces = 2;
            this.qpick.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.qpick.Location = new System.Drawing.Point(899, 12);
            this.qpick.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qpick.Name = "qpick";
            this.qpick.Size = new System.Drawing.Size(120, 20);
            this.qpick.TabIndex = 2;
            this.qpick.ThousandsSeparator = true;
            this.qpick.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(880, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "q";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(880, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "gx";
            // 
            // gxpick
            // 
            this.gxpick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gxpick.DecimalPlaces = 2;
            this.gxpick.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.gxpick.Location = new System.Drawing.Point(899, 38);
            this.gxpick.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.gxpick.Name = "gxpick";
            this.gxpick.Size = new System.Drawing.Size(120, 20);
            this.gxpick.TabIndex = 5;
            // 
            // gypick
            // 
            this.gypick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gypick.DecimalPlaces = 2;
            this.gypick.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.gypick.Location = new System.Drawing.Point(899, 64);
            this.gypick.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.gypick.Name = "gypick";
            this.gypick.Size = new System.Drawing.Size(120, 20);
            this.gypick.TabIndex = 6;
            this.gypick.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // mpick
            // 
            this.mpick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mpick.DecimalPlaces = 2;
            this.mpick.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.mpick.Location = new System.Drawing.Point(899, 90);
            this.mpick.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mpick.Name = "mpick";
            this.mpick.Size = new System.Drawing.Size(120, 20);
            this.mpick.TabIndex = 7;
            this.mpick.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // dtpick
            // 
            this.dtpick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpick.DecimalPlaces = 4;
            this.dtpick.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.dtpick.Location = new System.Drawing.Point(899, 116);
            this.dtpick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.dtpick.Name = "dtpick";
            this.dtpick.Size = new System.Drawing.Size(120, 20);
            this.dtpick.TabIndex = 8;
            this.dtpick.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(880, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "gy";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(880, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "m";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(880, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "dt";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(886, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SxPicker
            // 
            this.SxPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SxPicker.DecimalPlaces = 3;
            this.SxPicker.Location = new System.Drawing.Point(899, 142);
            this.SxPicker.Name = "SxPicker";
            this.SxPicker.Size = new System.Drawing.Size(120, 20);
            this.SxPicker.TabIndex = 13;
            // 
            // SyPicker
            // 
            this.SyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SyPicker.DecimalPlaces = 3;
            this.SyPicker.Location = new System.Drawing.Point(899, 168);
            this.SyPicker.Name = "SyPicker";
            this.SyPicker.Size = new System.Drawing.Size(120, 20);
            this.SyPicker.TabIndex = 14;
            // 
            // VxPicker
            // 
            this.VxPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VxPicker.DecimalPlaces = 3;
            this.VxPicker.Location = new System.Drawing.Point(899, 194);
            this.VxPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.VxPicker.Name = "VxPicker";
            this.VxPicker.Size = new System.Drawing.Size(120, 20);
            this.VxPicker.TabIndex = 15;
            this.VxPicker.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // VyPicker
            // 
            this.VyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VyPicker.DecimalPlaces = 3;
            this.VyPicker.Location = new System.Drawing.Point(899, 220);
            this.VyPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.VyPicker.Name = "VyPicker";
            this.VyPicker.Size = new System.Drawing.Size(120, 20);
            this.VyPicker.TabIndex = 16;
            this.VyPicker.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(874, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sx";
            // 
            // asd
            // 
            this.asd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(874, 170);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(19, 13);
            this.asd.TabIndex = 19;
            this.asd.Text = "Sy";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(874, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Vx";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(874, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Vy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1031, 469);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VyPicker);
            this.Controls.Add(this.VxPicker);
            this.Controls.Add(this.SyPicker);
            this.Controls.Add(this.SxPicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpick);
            this.Controls.Add(this.mpick);
            this.Controls.Add(this.gypick);
            this.Controls.Add(this.gxpick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qpick);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "PSMchart";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qpick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gxpick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gypick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SxPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SyPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VxPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VyPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown qpick;
        public System.Windows.Forms.NumericUpDown gxpick;
        public System.Windows.Forms.NumericUpDown gypick;
        public System.Windows.Forms.NumericUpDown mpick;
        public System.Windows.Forms.NumericUpDown dtpick;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.NumericUpDown SxPicker;
        public System.Windows.Forms.NumericUpDown SyPicker;
        public System.Windows.Forms.NumericUpDown VxPicker;
        public System.Windows.Forms.NumericUpDown VyPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

