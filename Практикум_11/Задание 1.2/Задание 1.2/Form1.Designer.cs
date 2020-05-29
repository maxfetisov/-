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
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.NumericUpDown();
            this.b = new System.Windows.Forms.NumericUpDown();
            this.c = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(251, 37);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(104, 13);
            this.aLabel.TabIndex = 0;
            this.aLabel.Text = "Введите сторону a:";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(251, 86);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(104, 13);
            this.bLabel.TabIndex = 1;
            this.bLabel.Text = "Введите сторону b:";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(251, 135);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(104, 13);
            this.cLabel.TabIndex = 2;
            this.cLabel.Text = "Введите сторону c:";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(377, 35);
            this.a.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.a.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(120, 20);
            this.a.TabIndex = 3;
            this.a.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(377, 84);
            this.b.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.b.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(120, 20);
            this.b.TabIndex = 4;
            this.b.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(377, 133);
            this.c.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.c.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(120, 20);
            this.c.TabIndex = 5;
            this.c.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(303, 185);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(144, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Узнать информацию";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 229);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(726, 355);
            this.output.TabIndex = 7;
            this.output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 596);
            this.Controls.Add(this.output);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.NumericUpDown a;
        private System.Windows.Forms.NumericUpDown b;
        private System.Windows.Forms.NumericUpDown c;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox output;
    }
}

