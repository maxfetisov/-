namespace WindowsFormsApp11
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
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.aNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.output = new System.Windows.Forms.RichTextBox();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(231, 20);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(62, 13);
            this.aLabel.TabIndex = 0;
            this.aLabel.Text = "Введите A:";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(231, 66);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(62, 13);
            this.bLabel.TabIndex = 1;
            this.bLabel.Text = "Введите B:";
            // 
            // aNumericUpDown
            // 
            this.aNumericUpDown.DecimalPlaces = 2;
            this.aNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.aNumericUpDown.Location = new System.Drawing.Point(299, 18);
            this.aNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.aNumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.aNumericUpDown.Name = "aNumericUpDown";
            this.aNumericUpDown.Size = new System.Drawing.Size(106, 20);
            this.aNumericUpDown.TabIndex = 2;
            // 
            // bNumericUpDown
            // 
            this.bNumericUpDown.DecimalPlaces = 2;
            this.bNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.bNumericUpDown.Location = new System.Drawing.Point(299, 64);
            this.bNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.bNumericUpDown.Name = "bNumericUpDown";
            this.bNumericUpDown.Size = new System.Drawing.Size(106, 20);
            this.bNumericUpDown.TabIndex = 3;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(46, 166);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(564, 96);
            this.output.TabIndex = 4;
            this.output.Text = "";
            this.output.Visible = false;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(278, 114);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 5;
            this.submit.Text = "Посчитать";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 299);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.output);
            this.Controls.Add(this.bNumericUpDown);
            this.Controls.Add(this.aNumericUpDown);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.MaximumSize = new System.Drawing.Size(665, 338);
            this.MinimumSize = new System.Drawing.Size(665, 338);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.NumericUpDown aNumericUpDown;
        private System.Windows.Forms.NumericUpDown bNumericUpDown;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button submit;
    }
}

