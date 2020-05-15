namespace Задание_1._2
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
            this.nLabel = new System.Windows.Forms.Label();
            this.array = new System.Windows.Forms.GroupBox();
            this.array2 = new System.Windows.Forms.RadioButton();
            this.array1 = new System.Windows.Forms.RadioButton();
            this.n = new System.Windows.Forms.NumericUpDown();
            this.mLabel = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.NumericUpDown();
            this.random = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.kLabel = new System.Windows.Forms.Label();
            this.k = new System.Windows.Forms.NumericUpDown();
            this.inOut = new System.Windows.Forms.RichTextBox();
            this.array.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k)).BeginInit();
            this.SuspendLayout();
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(197, 43);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(61, 13);
            this.nLabel.TabIndex = 0;
            this.nLabel.Text = "Введите n:";
            // 
            // array
            // 
            this.array.Controls.Add(this.array2);
            this.array.Controls.Add(this.array1);
            this.array.Location = new System.Drawing.Point(22, 14);
            this.array.Name = "array";
            this.array.Size = new System.Drawing.Size(145, 72);
            this.array.TabIndex = 1;
            this.array.TabStop = false;
            this.array.Text = "Выбор массива";
            // 
            // array2
            // 
            this.array2.AutoSize = true;
            this.array2.Location = new System.Drawing.Point(6, 43);
            this.array2.Name = "array2";
            this.array2.Size = new System.Drawing.Size(126, 17);
            this.array2.TabIndex = 1;
            this.array2.TabStop = true;
            this.array2.Text = "Двумерный массив";
            this.array2.UseVisualStyleBackColor = true;
            // 
            // array1
            // 
            this.array1.AutoSize = true;
            this.array1.Location = new System.Drawing.Point(6, 19);
            this.array1.Name = "array1";
            this.array1.Size = new System.Drawing.Size(132, 17);
            this.array1.TabIndex = 0;
            this.array1.TabStop = true;
            this.array1.Text = "Одномерный массив";
            this.array1.UseVisualStyleBackColor = true;
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(283, 43);
            this.n.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.n.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(120, 20);
            this.n.TabIndex = 2;
            this.n.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(197, 69);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(63, 13);
            this.mLabel.TabIndex = 3;
            this.mLabel.Text = "Введите m:";
            this.mLabel.Visible = false;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(283, 69);
            this.m.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.m.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(120, 20);
            this.m.TabIndex = 4;
            this.m.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m.Visible = false;
            // 
            // random
            // 
            this.random.AutoSize = true;
            this.random.Checked = true;
            this.random.CheckState = System.Windows.Forms.CheckState.Checked;
            this.random.Location = new System.Drawing.Point(200, 14);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(195, 17);
            this.random.TabIndex = 5;
            this.random.Text = "Заполнить рандомными числами";
            this.random.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(208, 339);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Вычислить";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(158, 115);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(84, 13);
            this.kLabel.TabIndex = 7;
            this.kLabel.Text = "Введите число:";
            // 
            // k
            // 
            this.k.Location = new System.Drawing.Point(248, 113);
            this.k.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.k.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(120, 20);
            this.k.TabIndex = 8;
            // 
            // inOut
            // 
            this.inOut.Location = new System.Drawing.Point(33, 143);
            this.inOut.Name = "inOut";
            this.inOut.ReadOnly = true;
            this.inOut.Size = new System.Drawing.Size(436, 149);
            this.inOut.TabIndex = 9;
            this.inOut.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 374);
            this.Controls.Add(this.inOut);
            this.Controls.Add(this.k);
            this.Controls.Add(this.kLabel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.random);
            this.Controls.Add(this.m);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.n);
            this.Controls.Add(this.array);
            this.Controls.Add(this.nLabel);
            this.MaximumSize = new System.Drawing.Size(526, 413);
            this.MinimumSize = new System.Drawing.Size(526, 413);
            this.Name = "Form1";
            this.Text = "Form1";
            this.array.ResumeLayout(false);
            this.array.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.GroupBox array;
        private System.Windows.Forms.RadioButton array2;
        private System.Windows.Forms.RadioButton array1;
        private System.Windows.Forms.NumericUpDown n;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.NumericUpDown m;
        private System.Windows.Forms.CheckBox random;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.NumericUpDown k;
        private System.Windows.Forms.RichTextBox inOut;
    }
}

