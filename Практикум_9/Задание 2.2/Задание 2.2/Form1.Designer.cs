namespace Задание_2._2
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
            this.submit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.n)).BeginInit();
            this.SuspendLayout();
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(196, 36);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(84, 13);
            this.nLabel.TabIndex = 0;
            this.nLabel.Text = "Введите длину:";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(310, 34);
            this.n.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(120, 20);
            this.n.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(264, 80);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Вычислить";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 133);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(599, 481);
            this.output.TabIndex = 3;
            this.output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 626);
            this.Controls.Add(this.output);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.n);
            this.Controls.Add(this.nLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.n)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.NumericUpDown n;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox output;
    }
}

