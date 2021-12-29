
namespace Lab2
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.LambdaTextBox = new System.Windows.Forms.TextBox();
            this.SigmaTextBox = new System.Windows.Forms.TextBox();
            this.chartU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.chartY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "N =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "c =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "a =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "lambda =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "sigma =";
            // 
            // NTextBox
            // 
            this.NTextBox.Location = new System.Drawing.Point(99, 12);
            this.NTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(100, 22);
            this.NTextBox.TabIndex = 5;
            // 
            // CTextBox
            // 
            this.CTextBox.Location = new System.Drawing.Point(99, 42);
            this.CTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(100, 22);
            this.CTextBox.TabIndex = 6;
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(99, 70);
            this.ATextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(100, 22);
            this.ATextBox.TabIndex = 7;
            // 
            // LambdaTextBox
            // 
            this.LambdaTextBox.Location = new System.Drawing.Point(99, 98);
            this.LambdaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LambdaTextBox.Name = "LambdaTextBox";
            this.LambdaTextBox.Size = new System.Drawing.Size(100, 22);
            this.LambdaTextBox.TabIndex = 8;
            // 
            // SigmaTextBox
            // 
            this.SigmaTextBox.Location = new System.Drawing.Point(99, 128);
            this.SigmaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SigmaTextBox.Name = "SigmaTextBox";
            this.SigmaTextBox.Size = new System.Drawing.Size(100, 22);
            this.SigmaTextBox.TabIndex = 9;
            // 
            // chartU
            // 
            chartArea1.Name = "ChartArea1";
            this.chartU.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartU.Legends.Add(legend1);
            this.chartU.Location = new System.Drawing.Point(12, 184);
            this.chartU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartU.Name = "chartU";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "U";
            this.chartU.Series.Add(series1);
            this.chartU.Size = new System.Drawing.Size(545, 391);
            this.chartU.TabIndex = 10;
            this.chartU.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Равномерное распределение U = x / N";
            this.chartU.Titles.Add(title1);
            // 
            // chartX
            // 
            chartArea2.Name = "ChartArea1";
            this.chartX.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartX.Legends.Add(legend2);
            this.chartX.Location = new System.Drawing.Point(586, 184);
            this.chartX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartX.Name = "chartX";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "X";
            this.chartX.Series.Add(series2);
            this.chartX.Size = new System.Drawing.Size(545, 391);
            this.chartX.TabIndex = 11;
            this.chartX.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Показательное распределение случайной величины X";
            this.chartX.Titles.Add(title2);
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(252, 11);
            this.buttonU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(75, 23);
            this.buttonU.TabIndex = 13;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.buttonU_Click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(252, 41);
            this.buttonX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(75, 23);
            this.buttonX.TabIndex = 14;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // chartY
            // 
            chartArea3.Name = "ChartArea1";
            this.chartY.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartY.Legends.Add(legend3);
            this.chartY.Location = new System.Drawing.Point(1164, 184);
            this.chartY.Name = "chartY";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Y";
            this.chartY.Series.Add(series3);
            this.chartY.Size = new System.Drawing.Size(545, 391);
            this.chartY.TabIndex = 15;
            this.chartY.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Нормальное распределение случайной велечины Y";
            this.chartY.Titles.Add(title3);
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(252, 69);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(75, 23);
            this.buttonY.TabIndex = 16;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 616);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.chartY);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.chartX);
            this.Controls.Add(this.chartU);
            this.Controls.Add(this.SigmaTextBox);
            this.Controls.Add(this.LambdaTextBox);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.CTextBox);
            this.Controls.Add(this.NTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.TextBox CTextBox;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox LambdaTextBox;
        private System.Windows.Forms.TextBox SigmaTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartX;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartY;
        private System.Windows.Forms.Button buttonY;
    }
}

