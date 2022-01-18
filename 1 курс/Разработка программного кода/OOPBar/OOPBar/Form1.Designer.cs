namespace OOPBar
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDrinks = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBoxDrinks = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxIngredients = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Напиток:";
            // 
            // comboBoxDrinks
            // 
            this.comboBoxDrinks.FormattingEnabled = true;
            this.comboBoxDrinks.Items.AddRange(new object[] {
            "Вино",
            "Текила",
            "Виски",
            "Ром",
            "Сок",
            "Кола",
            "Вода"});
            this.comboBoxDrinks.Location = new System.Drawing.Point(84, 6);
            this.comboBoxDrinks.Name = "comboBoxDrinks";
            this.comboBoxDrinks.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDrinks.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стоимость:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(382, 33);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(140, 16);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "___________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ингредиенты:";
            // 
            // checkedListBoxDrinks
            // 
            this.checkedListBoxDrinks.FormattingEnabled = true;
            this.checkedListBoxDrinks.Items.AddRange(new object[] {
            "Вино",
            "Текила",
            "Виски",
            "Ром",
            "Сок",
            "Кола",
            "Вода"});
            this.checkedListBoxDrinks.Location = new System.Drawing.Point(15, 58);
            this.checkedListBoxDrinks.Name = "checkedListBoxDrinks";
            this.checkedListBoxDrinks.Size = new System.Drawing.Size(133, 123);
            this.checkedListBoxDrinks.TabIndex = 6;
            // 
            // checkedListBoxIngredients
            // 
            this.checkedListBoxIngredients.FormattingEnabled = true;
            this.checkedListBoxIngredients.Items.AddRange(new object[] {
            "Лёд",
            "Мята",
            "Лайм"});
            this.checkedListBoxIngredients.Location = new System.Drawing.Point(154, 58);
            this.checkedListBoxIngredients.Name = "checkedListBoxIngredients";
            this.checkedListBoxIngredients.Size = new System.Drawing.Size(135, 123);
            this.checkedListBoxIngredients.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Коктейль:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(211, 6);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(48, 22);
            this.textBoxValue.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "мл";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 189);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBoxIngredients);
            this.Controls.Add(this.checkedListBoxDrinks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDrinks);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDrinks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBoxDrinks;
        private System.Windows.Forms.CheckedListBox checkedListBoxIngredients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label5;
    }
}

