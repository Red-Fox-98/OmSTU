
namespace Lab5
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.chartKtt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartKij = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartKtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKij)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(12, 12);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(75, 23);
            this.buttonLaunch.TabIndex = 0;
            this.buttonLaunch.Text = "Launch";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // chartKtt
            // 
            chartArea1.Name = "ChartArea1";
            this.chartKtt.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartKtt.Legends.Add(legend1);
            this.chartKtt.Location = new System.Drawing.Point(93, 12);
            this.chartKtt.Name = "chartKtt";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "X1t";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "X2t";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "X3t";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "X4t";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "X5t";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "X6t";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "X7t";
            this.chartKtt.Series.Add(series1);
            this.chartKtt.Series.Add(series2);
            this.chartKtt.Series.Add(series3);
            this.chartKtt.Series.Add(series4);
            this.chartKtt.Series.Add(series5);
            this.chartKtt.Series.Add(series6);
            this.chartKtt.Series.Add(series7);
            this.chartKtt.Size = new System.Drawing.Size(1266, 300);
            this.chartKtt.TabIndex = 1;
            this.chartKtt.Text = "chart1";
            // 
            // chartMi
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMi.Legends.Add(legend2);
            this.chartMi.Location = new System.Drawing.Point(93, 318);
            this.chartMi.Name = "chartMi";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "M";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Legend = "Legend1";
            series9.Name = "Mi";
            this.chartMi.Series.Add(series8);
            this.chartMi.Series.Add(series9);
            this.chartMi.Size = new System.Drawing.Size(1266, 300);
            this.chartMi.TabIndex = 2;
            this.chartMi.Text = "chart1";
            // 
            // chartKij
            // 
            chartArea3.Name = "ChartArea1";
            this.chartKij.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartKij.Legends.Add(legend3);
            this.chartKij.Location = new System.Drawing.Point(93, 624);
            this.chartKij.Name = "chartKij";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Ktt";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series11.Legend = "Legend1";
            series11.Name = "Kij";
            this.chartKij.Series.Add(series10);
            this.chartKij.Series.Add(series11);
            this.chartKij.Size = new System.Drawing.Size(1266, 300);
            this.chartKij.TabIndex = 3;
            this.chartKij.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 1019);
            this.Controls.Add(this.chartKij);
            this.Controls.Add(this.chartMi);
            this.Controls.Add(this.chartKtt);
            this.Controls.Add(this.buttonLaunch);
            this.Name = "Form1";
            this.Text = "Lab5";
            ((System.ComponentModel.ISupportInitialize)(this.chartKtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKij)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKtt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKij;
    }
}

