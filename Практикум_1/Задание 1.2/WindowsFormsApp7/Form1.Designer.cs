namespace WindowsFormsApp7
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.l)).BeginInit();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(149, 36);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(147, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Введите длину окружности:";
            // 
            // l
            // 
            this.l.DecimalPlaces = 2;
            this.l.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.l.Location = new System.Drawing.Point(302, 34);
            this.l.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(90, 20);
            this.l.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(237, 93);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Посчитать";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(193, 157);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 215);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.l);
            this.Controls.Add(this.inputLabel);
            this.MaximumSize = new System.Drawing.Size(566, 254);
            this.MinimumSize = new System.Drawing.Size(566, 254);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.l)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.NumericUpDown l;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label outputLabel;
    }
}

