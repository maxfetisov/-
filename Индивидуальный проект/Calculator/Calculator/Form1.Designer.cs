namespace Calculator
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
            this.gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.warYear = new System.Windows.Forms.NumericUpDown();
            this.warMonth = new System.Windows.Forms.NumericUpDown();
            this.warDays = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.child = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.stash = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.coef = new System.Windows.Forms.TextBox();
            this.pensionOutput = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.child)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(345, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пол:";
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.gender.Location = new System.Drawing.Point(400, 38);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(172, 32);
            this.gender.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(249, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Год рождения:";
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year.Location = new System.Drawing.Point(400, 81);
            this.year.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(172, 29);
            this.year.TabIndex = 3;
            this.year.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(181, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Срок военной службы:";
            // 
            // warYear
            // 
            this.warYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warYear.Location = new System.Drawing.Point(400, 121);
            this.warYear.Name = "warYear";
            this.warYear.Size = new System.Drawing.Size(40, 29);
            this.warYear.TabIndex = 5;
            // 
            // warMonth
            // 
            this.warMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warMonth.Location = new System.Drawing.Point(465, 121);
            this.warMonth.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.warMonth.Name = "warMonth";
            this.warMonth.Size = new System.Drawing.Size(40, 29);
            this.warMonth.TabIndex = 6;
            // 
            // warDays
            // 
            this.warDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warDays.Location = new System.Drawing.Point(532, 121);
            this.warDays.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.warDays.Name = "warDays";
            this.warDays.Size = new System.Drawing.Size(40, 29);
            this.warDays.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(212, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество детей:";
            // 
            // child
            // 
            this.child.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.child.Location = new System.Drawing.Point(400, 165);
            this.child.Name = "child";
            this.child.Size = new System.Drawing.Size(172, 29);
            this.child.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(38, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Стаж в качестве наемного работника:";
            // 
            // stash
            // 
            this.stash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stash.Location = new System.Drawing.Point(400, 201);
            this.stash.Name = "stash";
            this.stash.Size = new System.Drawing.Size(172, 29);
            this.stash.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(168, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Официальная зарплата:";
            // 
            // money
            // 
            this.money.DecimalPlaces = 2;
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money.Location = new System.Drawing.Point(400, 238);
            this.money.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.money.Minimum = new decimal(new int[] {
            12130,
            0,
            0,
            0});
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(172, 29);
            this.money.TabIndex = 13;
            this.money.Value = new decimal(new int[] {
            12130,
            0,
            0,
            0});
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submit.Location = new System.Drawing.Point(245, 292);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(149, 38);
            this.submit.TabIndex = 14;
            this.submit.Text = "Рассчитать";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(214, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Страховая пенсия:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(387, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Количество пенсионных коэффициентов:";
            // 
            // coef
            // 
            this.coef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coef.Location = new System.Drawing.Point(400, 358);
            this.coef.Name = "coef";
            this.coef.ReadOnly = true;
            this.coef.Size = new System.Drawing.Size(172, 29);
            this.coef.TabIndex = 18;
            // 
            // pensionOutput
            // 
            this.pensionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pensionOutput.Location = new System.Drawing.Point(400, 401);
            this.pensionOutput.Name = "pensionOutput";
            this.pensionOutput.ReadOnly = true;
            this.pensionOutput.Size = new System.Drawing.Size(172, 29);
            this.pensionOutput.TabIndex = 19;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset.Location = new System.Drawing.Point(400, 292);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(152, 38);
            this.reset.TabIndex = 20;
            this.reset.Text = "Сброс";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 489);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.pensionOutput);
            this.Controls.Add(this.coef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.child);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.warDays);
            this.Controls.Add(this.warMonth);
            this.Controls.Add(this.warYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пенсионный калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.child)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown warYear;
        private System.Windows.Forms.NumericUpDown warMonth;
        private System.Windows.Forms.NumericUpDown warDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown child;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown stash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown money;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox coef;
        private System.Windows.Forms.TextBox pensionOutput;
        private System.Windows.Forms.Button reset;
    }
}

