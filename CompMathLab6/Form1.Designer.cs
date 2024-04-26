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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXn)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(939, 613);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CompMathLab6.Properties.Resources.Lab6;
            this.pictureBox1.Location = new System.Drawing.Point(957, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 62);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDownX0
            // 
            this.numericUpDownX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownX0.Location = new System.Drawing.Point(1000, 79);
            this.numericUpDownX0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownX0.Name = "numericUpDownX0";
            this.numericUpDownX0.Size = new System.Drawing.Size(132, 34);
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
            this.label1.Location = new System.Drawing.Point(957, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "X0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(957, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(957, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xn";
            // 
            // numericUpDownY0
            // 
            this.numericUpDownY0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownY0.Location = new System.Drawing.Point(1000, 119);
            this.numericUpDownY0.Name = "numericUpDownY0";
            this.numericUpDownY0.Size = new System.Drawing.Size(132, 34);
            this.numericUpDownY0.TabIndex = 6;
            // 
            // numericUpDownXn
            // 
            this.numericUpDownXn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownXn.Location = new System.Drawing.Point(1000, 159);
            this.numericUpDownXn.Name = "numericUpDownXn";
            this.numericUpDownXn.Size = new System.Drawing.Size(132, 34);
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
            "метод Эйлера,",
            "метод Рунге–Кутты–Мерсона",
            "Исправленный Эйлера",
            "Адамса 5-го порядка"});
            this.comboBoxMethods.Location = new System.Drawing.Point(1139, 12);
            this.comboBoxMethods.Name = "comboBoxMethods";
            this.comboBoxMethods.Size = new System.Drawing.Size(386, 37);
            this.comboBoxMethods.TabIndex = 8;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDraw.Location = new System.Drawing.Point(1139, 55);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(386, 65);
            this.buttonDraw.TabIndex = 9;
            this.buttonDraw.Text = "Построить";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonClear.Location = new System.Drawing.Point(1138, 128);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(387, 65);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Отчистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1531, 637);
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
            this.Name = "Form1";
            this.Text = "РЕШЕНИЕ ДИФФЕРЕНЦИАЛЬНЫХ УРАВНЕНИЙ";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXn)).EndInit();
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
    }
}

