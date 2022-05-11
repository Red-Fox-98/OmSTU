namespace LR8
{
    partial class LR8
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
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartXTk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRtk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSigma0 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartXTk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRtk)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(349, 270);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(350, 175);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 22);
            this.textBoxN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "n = ";
            // 
            // chartXTk
            // 
            chartArea1.Name = "ChartArea1";
            this.chartXTk.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartXTk.Legends.Add(legend1);
            this.chartXTk.Location = new System.Drawing.Point(12, 479);
            this.chartXTk.Name = "chartXTk";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "4";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "5";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "6";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "7";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "8";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "9";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "10";
            this.chartXTk.Series.Add(series1);
            this.chartXTk.Series.Add(series2);
            this.chartXTk.Series.Add(series3);
            this.chartXTk.Series.Add(series4);
            this.chartXTk.Series.Add(series5);
            this.chartXTk.Series.Add(series6);
            this.chartXTk.Series.Add(series7);
            this.chartXTk.Series.Add(series8);
            this.chartXTk.Series.Add(series9);
            this.chartXTk.Series.Add(series10);
            this.chartXTk.Size = new System.Drawing.Size(802, 461);
            this.chartXTk.TabIndex = 3;
            this.chartXTk.Text = "chart1";
            // 
            // chartDt
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDt.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDt.Legends.Add(legend2);
            this.chartDt.Location = new System.Drawing.Point(820, 12);
            this.chartDt.Name = "chartDt";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Эмпирическая дисперсия";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Теоретическая дисперсия";
            this.chartDt.Series.Add(series11);
            this.chartDt.Series.Add(series12);
            this.chartDt.Size = new System.Drawing.Size(802, 461);
            this.chartDt.TabIndex = 4;
            this.chartDt.Text = "chart1";
            // 
            // chartRtk
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRtk.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRtk.Legends.Add(legend3);
            this.chartRtk.Location = new System.Drawing.Point(820, 479);
            this.chartRtk.Name = "chartRtk";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Эмпирический коэффициент корреляции";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "Теоретический коэффициент корреляции";
            this.chartRtk.Series.Add(series13);
            this.chartRtk.Series.Add(series14);
            this.chartRtk.Size = new System.Drawing.Size(802, 461);
            this.chartRtk.TabIndex = 5;
            this.chartRtk.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "H = ";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(349, 203);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 22);
            this.textBoxH.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sigma_0 = ";
            // 
            // textBoxSigma0
            // 
            this.textBoxSigma0.Location = new System.Drawing.Point(394, 231);
            this.textBoxSigma0.Name = "textBoxSigma0";
            this.textBoxSigma0.Size = new System.Drawing.Size(54, 22);
            this.textBoxSigma0.TabIndex = 8;
            // 
            // LR8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 960);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSigma0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.chartRtk);
            this.Controls.Add(this.chartDt);
            this.Controls.Add(this.chartXTk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.buttonStart);
            this.Name = "LR8";
            this.Text = "LR_8";
            ((System.ComponentModel.ISupportInitialize)(this.chartXTk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRtk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartXTk;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRtk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSigma0;
    }
}

