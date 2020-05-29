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
            this.strLabel = new System.Windows.Forms.Label();
            this.scalLabel = new System.Windows.Forms.Label();
            this.scal = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.str = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scal)).BeginInit();
            this.SuspendLayout();
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Location = new System.Drawing.Point(269, 37);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(89, 13);
            this.strLabel.TabIndex = 0;
            this.strLabel.Text = "Введите строку:";
            // 
            // scalLabel
            // 
            this.scalLabel.AutoSize = true;
            this.scalLabel.Location = new System.Drawing.Point(269, 86);
            this.scalLabel.Name = "scalLabel";
            this.scalLabel.Size = new System.Drawing.Size(91, 13);
            this.scalLabel.TabIndex = 1;
            this.scalLabel.Text = "Введите скаляр:";
            // 
            // scal
            // 
            this.scal.Location = new System.Drawing.Point(377, 84);
            this.scal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.scal.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.scal.Name = "scal";
            this.scal.Size = new System.Drawing.Size(120, 20);
            this.scal.TabIndex = 4;
            this.scal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(311, 132);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(144, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Узнать информацию";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 184);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(726, 400);
            this.output.TabIndex = 7;
            this.output.Text = "";
            // 
            // str
            // 
            this.str.Location = new System.Drawing.Point(377, 34);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(120, 20);
            this.str.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 596);
            this.Controls.Add(this.str);
            this.Controls.Add(this.output);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.scal);
            this.Controls.Add(this.scalLabel);
            this.Controls.Add(this.strLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.scal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.Label scalLabel;
        private System.Windows.Forms.NumericUpDown scal;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.TextBox str;
    }
}

