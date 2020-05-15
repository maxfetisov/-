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
            this.n = new System.Windows.Forms.NumericUpDown();
            this.random = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.inOut = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.n)).BeginInit();
            this.SuspendLayout();
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(150, 83);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(61, 13);
            this.nLabel.TabIndex = 0;
            this.nLabel.Text = "Введите n:";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(236, 83);
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
            // random
            // 
            this.random.AutoSize = true;
            this.random.Checked = true;
            this.random.CheckState = System.Windows.Forms.CheckState.Checked;
            this.random.Location = new System.Drawing.Point(153, 54);
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
            // inOut
            // 
            this.inOut.Location = new System.Drawing.Point(33, 128);
            this.inOut.Name = "inOut";
            this.inOut.ReadOnly = true;
            this.inOut.Size = new System.Drawing.Size(436, 164);
            this.inOut.TabIndex = 9;
            this.inOut.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 374);
            this.Controls.Add(this.inOut);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.random);
            this.Controls.Add(this.n);
            this.Controls.Add(this.nLabel);
            this.MaximumSize = new System.Drawing.Size(526, 413);
            this.MinimumSize = new System.Drawing.Size(526, 413);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.n)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.NumericUpDown n;
        private System.Windows.Forms.CheckBox random;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox inOut;
    }
}

