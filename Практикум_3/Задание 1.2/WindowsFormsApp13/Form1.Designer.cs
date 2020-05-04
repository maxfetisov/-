namespace WindowsFormsApp13
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
            this.submit = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.NumericUpDown();
            this.output = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.input)).BeginInit();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(155, 106);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "Вычислить";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(79, 48);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(84, 13);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Введите число:";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(188, 46);
            this.input.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.input.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(120, 20);
            this.input.TabIndex = 2;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(82, 180);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(226, 20);
            this.output.TabIndex = 3;
            this.output.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 246);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.submit);
            this.MaximumSize = new System.Drawing.Size(389, 285);
            this.MinimumSize = new System.Drawing.Size(389, 285);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.NumericUpDown input;
        private System.Windows.Forms.TextBox output;
    }
}

