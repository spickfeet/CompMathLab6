namespace CompMathLab6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDownX0 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownY0 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXn = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMethods = new System.Windows.Forms.ComboBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.numericUpDownStep = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMaxY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownMinY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAccuracy = new System.Windows.Forms.NumericUpDown();
            this.labelAccuracy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccuracy)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(9, 10);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "EulerDiffEquation";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "UpgradeEulerDiffEquation";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "RungeKuttyMerson";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(704, 498);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CompMathLab6.Properties.Resources.Lab6;
            this.pictureBox1.Location = new System.Drawing.Point(718, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 60);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDownX0
            // 
            this.numericUpDownX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownX0.Location = new System.Drawing.Point(749, 72);
            this.numericUpDownX0.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownX0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownX0.Name = "numericUpDownX0";
            this.numericUpDownX0.Size = new System.Drawing.Size(142, 29);
            this.numericUpDownX0.TabIndex = 2;
            this.numericUpDownX0.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(717, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "X0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(717, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(717, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xn";
            // 
            // numericUpDownY0
            // 
            this.numericUpDownY0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownY0.Location = new System.Drawing.Point(749, 105);
            this.numericUpDownY0.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownY0.Name = "numericUpDownY0";
            this.numericUpDownY0.Size = new System.Drawing.Size(142, 29);
            this.numericUpDownY0.TabIndex = 6;
            // 
            // numericUpDownXn
            // 
            this.numericUpDownXn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownXn.Location = new System.Drawing.Point(749, 137);
            this.numericUpDownXn.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownXn.Name = "numericUpDownXn";
            this.numericUpDownXn.Size = new System.Drawing.Size(142, 29);
            this.numericUpDownXn.TabIndex = 7;
            this.numericUpDownXn.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // comboBoxMethods
            // 
            this.comboBoxMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxMethods.FormattingEnabled = true;
            this.comboBoxMethods.Items.AddRange(new object[] {
            "метод Эйлера",
            "Исправленный Эйлера",
            "метод Рунге–Кутты–Мерсона",
            "Адамса 5-го порядка"});
            this.comboBoxMethods.Location = new System.Drawing.Point(899, 41);
            this.comboBoxMethods.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMethods.Name = "comboBoxMethods";
            this.comboBoxMethods.Size = new System.Drawing.Size(290, 32);
            this.comboBoxMethods.TabIndex = 8;
            this.comboBoxMethods.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethods_SelectedIndexChanged);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDraw.Location = new System.Drawing.Point(899, 77);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(290, 47);
            this.buttonDraw.TabIndex = 9;
            this.buttonDraw.Text = "Построить";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonClear.Location = new System.Drawing.Point(899, 128);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(290, 38);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Отчистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // numericUpDownStep
            // 
            this.numericUpDownStep.DecimalPlaces = 5;
            this.numericUpDownStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownStep.Location = new System.Drawing.Point(942, 8);
            this.numericUpDownStep.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownStep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownStep.Name = "numericUpDownStep";
            this.numericUpDownStep.Size = new System.Drawing.Size(142, 29);
            this.numericUpDownStep.TabIndex = 12;
            this.numericUpDownStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(895, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Шаг";
            // 
            // numericUpDownMaxY
            // 
            this.numericUpDownMaxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownMaxY.Location = new System.Drawing.Point(1049, 382);
            this.numericUpDownMaxY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxY.Name = "numericUpDownMaxY";
            this.numericUpDownMaxY.Size = new System.Drawing.Size(140, 29);
            this.numericUpDownMaxY.TabIndex = 13;
            this.numericUpDownMaxY.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(971, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Макс У";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(971, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Мин Х";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(971, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Макс Х";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(971, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Мин У";
            // 
            // numericUpDownMinY
            // 
            this.numericUpDownMinY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownMinY.Location = new System.Drawing.Point(1049, 417);
            this.numericUpDownMinY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownMinY.Name = "numericUpDownMinY";
            this.numericUpDownMinY.Size = new System.Drawing.Size(140, 29);
            this.numericUpDownMinY.TabIndex = 22;
            // 
            // numericUpDownMaxX
            // 
            this.numericUpDownMaxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownMaxX.Location = new System.Drawing.Point(1049, 452);
            this.numericUpDownMaxX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxX.Name = "numericUpDownMaxX";
            this.numericUpDownMaxX.Size = new System.Drawing.Size(140, 29);
            this.numericUpDownMaxX.TabIndex = 23;
            this.numericUpDownMaxX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownMinX
            // 
            this.numericUpDownMinX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownMinX.Location = new System.Drawing.Point(1049, 487);
            this.numericUpDownMinX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownMinX.Name = "numericUpDownMinX";
            this.numericUpDownMinX.Size = new System.Drawing.Size(140, 29);
            this.numericUpDownMinX.TabIndex = 24;
            this.numericUpDownMinX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownAccuracy
            // 
            this.numericUpDownAccuracy.DecimalPlaces = 10;
            this.numericUpDownAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownAccuracy.Location = new System.Drawing.Point(997, 173);
            this.numericUpDownAccuracy.Name = "numericUpDownAccuracy";
            this.numericUpDownAccuracy.Size = new System.Drawing.Size(192, 29);
            this.numericUpDownAccuracy.TabIndex = 25;
            this.numericUpDownAccuracy.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownAccuracy.Visible = false;
            // 
            // labelAccuracy
            // 
            this.labelAccuracy.AutoSize = true;
            this.labelAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelAccuracy.Location = new System.Drawing.Point(895, 173);
            this.labelAccuracy.Name = "labelAccuracy";
            this.labelAccuracy.Size = new System.Drawing.Size(96, 24);
            this.labelAccuracy.TabIndex = 26;
            this.labelAccuracy.Text = "Точность";
            this.labelAccuracy.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1201, 528);
            this.Controls.Add(this.labelAccuracy);
            this.Controls.Add(this.numericUpDownAccuracy);
            this.Controls.Add(this.numericUpDownMinX);
            this.Controls.Add(this.numericUpDownMaxX);
            this.Controls.Add(this.numericUpDownMinY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownMaxY);
            this.Controls.Add(this.numericUpDownStep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.comboBoxMethods);
            this.Controls.Add(this.numericUpDownXn);
            this.Controls.Add(this.numericUpDownY0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownX0);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "РЕШЕНИЕ ДИФФЕРЕНЦИАЛЬНЫХ УРАВНЕНИЙ";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccuracy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownX0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownY0;
        private System.Windows.Forms.NumericUpDown numericUpDownXn;
        private System.Windows.Forms.ComboBox comboBoxMethods;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.NumericUpDown numericUpDownStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownMinY;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxX;
        private System.Windows.Forms.NumericUpDown numericUpDownMinX;
        private System.Windows.Forms.NumericUpDown numericUpDownAccuracy;
        private System.Windows.Forms.Label labelAccuracy;
    }
}

