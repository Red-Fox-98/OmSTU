namespace SalaryApp
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
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBusiness = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.buttonEngineer = new System.Windows.Forms.Button();
            this.buttonWorker = new System.Windows.Forms.Button();
            this.buttonManager = new System.Windows.Forms.Button();
            this.labelFullName = new System.Windows.Forms.Label();
            this.textBoxPremium = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(96, 10);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(96, 38);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(96, 66);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(100, 22);
            this.textBoxPatronymic.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Количество сделок:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Отработанные часы:";
            // 
            // textBoxBusiness
            // 
            this.textBoxBusiness.Location = new System.Drawing.Point(523, 99);
            this.textBoxBusiness.Name = "textBoxBusiness";
            this.textBoxBusiness.Size = new System.Drawing.Size(48, 22);
            this.textBoxBusiness.TabIndex = 11;
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(305, 99);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(48, 22);
            this.textBoxHours.TabIndex = 10;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(251, 41);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(252, 16);
            this.labelSalary.TabIndex = 17;
            this.labelSalary.Text = "___________________________________";
            // 
            // buttonEngineer
            // 
            this.buttonEngineer.Location = new System.Drawing.Point(16, 129);
            this.buttonEngineer.Name = "buttonEngineer";
            this.buttonEngineer.Size = new System.Drawing.Size(104, 33);
            this.buttonEngineer.TabIndex = 18;
            this.buttonEngineer.Text = "Инженер";
            this.buttonEngineer.UseVisualStyleBackColor = true;
            this.buttonEngineer.Click += new System.EventHandler(this.buttonEngineer_Click);
            // 
            // buttonWorker
            // 
            this.buttonWorker.Location = new System.Drawing.Point(160, 129);
            this.buttonWorker.Name = "buttonWorker";
            this.buttonWorker.Size = new System.Drawing.Size(104, 33);
            this.buttonWorker.TabIndex = 19;
            this.buttonWorker.Text = "Рабочий";
            this.buttonWorker.UseVisualStyleBackColor = true;
            this.buttonWorker.Click += new System.EventHandler(this.buttonWorker_Click);
            // 
            // buttonManager
            // 
            this.buttonManager.Location = new System.Drawing.Point(383, 129);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(104, 33);
            this.buttonManager.TabIndex = 20;
            this.buttonManager.Text = "Менеджер";
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(251, 16);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(252, 16);
            this.labelFullName.TabIndex = 22;
            this.labelFullName.Text = "___________________________________";
            // 
            // textBoxPremium
            // 
            this.textBoxPremium.Location = new System.Drawing.Point(16, 99);
            this.textBoxPremium.Name = "textBoxPremium";
            this.textBoxPremium.Size = new System.Drawing.Size(48, 22);
            this.textBoxPremium.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 174);
            this.Controls.Add(this.textBoxPremium);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.buttonManager);
            this.Controls.Add(this.buttonWorker);
            this.Controls.Add(this.buttonEngineer);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxBusiness);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxSurname);
            this.Name = "Form1";
            this.Text = "Salary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBusiness;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Button buttonEngineer;
        private System.Windows.Forms.Button buttonWorker;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox textBoxPremium;
    }
}

