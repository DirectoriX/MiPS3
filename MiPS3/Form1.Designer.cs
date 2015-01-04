namespace MiPS3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Modules = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Functions = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxBroken = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.Models = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ResLabel = new System.Windows.Forms.Label();
            this.Stud = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Modules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Functions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBroken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Models)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stud)).BeginInit();
            this.SuspendLayout();
            // 
            // Modules
            // 
            this.Modules.Location = new System.Drawing.Point(144, 12);
            this.Modules.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Modules.Name = "Modules";
            this.Modules.Size = new System.Drawing.Size(48, 20);
            this.Modules.TabIndex = 0;
            this.Modules.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Modules.ValueChanged += new System.EventHandler(this.Modules_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество модулей, m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество функций, n";
            // 
            // Functions
            // 
            this.Functions.Location = new System.Drawing.Point(144, 38);
            this.Functions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Functions.Name = "Functions";
            this.Functions.Size = new System.Drawing.Size(48, 20);
            this.Functions.TabIndex = 3;
            this.Functions.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Предельное количество нерабочих модулей, d";
            // 
            // MaxBroken
            // 
            this.MaxBroken.Location = new System.Drawing.Point(447, 12);
            this.MaxBroken.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxBroken.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxBroken.Name = "MaxBroken";
            this.MaxBroken.Size = new System.Drawing.Size(48, 20);
            this.MaxBroken.TabIndex = 5;
            this.MaxBroken.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Запустить моделирование!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Models
            // 
            this.Models.Location = new System.Drawing.Point(447, 38);
            this.Models.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Models.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Models.Name = "Models";
            this.Models.Size = new System.Drawing.Size(48, 20);
            this.Models.TabIndex = 7;
            this.Models.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество испытаний";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(180, 261);
            this.textBox1.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(201, 64);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series2";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.Legend = "Legend1";
            series2.Name = "Коэффициент сохранения эффективности";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(677, 261);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // ResLabel
            // 
            this.ResLabel.AutoSize = true;
            this.ResLabel.Location = new System.Drawing.Point(675, 14);
            this.ResLabel.Name = "ResLabel";
            this.ResLabel.Size = new System.Drawing.Size(106, 13);
            this.ResLabel.TabIndex = 11;
            this.ResLabel.Text = "Средняя наработка";
            this.ResLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stud
            // 
            this.Stud.DecimalPlaces = 3;
            this.Stud.Location = new System.Drawing.Point(248, 38);
            this.Stud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Stud.Name = "Stud";
            this.Stud.Size = new System.Drawing.Size(63, 20);
            this.Stud.TabIndex = 12;
            this.Stud.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 337);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Stud);
            this.Controls.Add(this.ResLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Models);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MaxBroken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Functions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Modules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "МиПС3";
            ((System.ComponentModel.ISupportInitialize)(this.Modules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Functions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBroken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Models)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Modules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Functions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MaxBroken;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown Models;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label ResLabel;
        private System.Windows.Forms.NumericUpDown Stud;
        private System.Windows.Forms.Label label6;
    }
}

