namespace WindowsFormsApp14
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
            this.output = new System.Windows.Forms.RichTextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.NumericUpDown();
            this.b = new System.Windows.Forms.NumericUpDown();
            this.h = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(311, 12);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(225, 426);
            this.output.TabIndex = 0;
            this.output.Text = "";
            this.output.Visible = false;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(50, 123);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(61, 13);
            this.aLabel.TabIndex = 1;
            this.aLabel.Text = "Введите a:";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(50, 180);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(61, 13);
            this.bLabel.TabIndex = 2;
            this.bLabel.Text = "Введите b:";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(50, 235);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(61, 13);
            this.hLabel.TabIndex = 3;
            this.hLabel.Text = "Введите h:";
            // 
            // a
            // 
            this.a.DecimalPlaces = 2;
            this.a.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.a.Location = new System.Drawing.Point(128, 121);
            this.a.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.a.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(120, 20);
            this.a.TabIndex = 4;
            // 
            // b
            // 
            this.b.DecimalPlaces = 2;
            this.b.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.b.Location = new System.Drawing.Point(128, 178);
            this.b.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.b.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(120, 20);
            this.b.TabIndex = 5;
            // 
            // h
            // 
            this.h.DecimalPlaces = 2;
            this.h.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.h.Location = new System.Drawing.Point(128, 233);
            this.h.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.h.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(120, 20);
            this.h.TabIndex = 6;
            this.h.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(110, 294);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 7;
            this.submit.Text = "Вычислить";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.h);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.output);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.NumericUpDown a;
        private System.Windows.Forms.NumericUpDown b;
        private System.Windows.Forms.NumericUpDown h;
        private System.Windows.Forms.Button submit;
    }
}

