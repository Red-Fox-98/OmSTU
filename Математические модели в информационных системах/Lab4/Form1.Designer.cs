
namespace Lab4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.calculationXY = new System.Windows.Forms.Button();
            this.chartXY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartXY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = " Коэффициент корреляции";
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(206, 9);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 22);
            this.textBoxR.TabIndex = 1;
            // 
            // calculationXY
            // 
            this.calculationXY.Location = new System.Drawing.Point(231, 37);
            this.calculationXY.Name = "calculationXY";
            this.calculationXY.Size = new System.Drawing.Size(75, 23);
            this.calculationXY.TabIndex = 3;
            this.calculationXY.Text = "XY";
            this.calculationXY.UseVisualStyleBackColor = true;
            this.calculationXY.Click += new System.EventHandler(this.calculationXY_Click);
            // 
            // chartXY
            // 
            chartArea2.Name = "ChartArea1";
            this.chartXY.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartXY.Legends.Add(legend2);
            this.chartXY.Location = new System.Drawing.Point(312, 9);
            this.chartXY.Name = "chartXY";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "XY";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartXY.Series.Add(series2);
            this.chartXY.Size = new System.Drawing.Size(476, 429);
            this.chartXY.TabIndex = 4;
            this.chartXY.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartXY);
            this.Controls.Add(this.calculationXY);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Двумерная случайная величина";
            ((System.ComponentModel.ISupportInitialize)(this.chartXY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Button calculationXY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartXY;
    }
}

