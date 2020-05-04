namespace WindowsFormsApp9
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.output = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(546, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(242, 198);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(67, 69);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(124, 13);
            this.xLabel.TabIndex = 1;
            this.xLabel.Text = "Введите координату x: ";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(67, 119);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(121, 13);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "Введите координату y:";
            // 
            // xNumericUpDown
            // 
            this.xNumericUpDown.DecimalPlaces = 2;
            this.xNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.xNumericUpDown.Location = new System.Drawing.Point(197, 67);
            this.xNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.xNumericUpDown.Name = "xNumericUpDown";
            this.xNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.xNumericUpDown.TabIndex = 3;
            // 
            // yNumericUpDown
            // 
            this.yNumericUpDown.DecimalPlaces = 2;
            this.yNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.yNumericUpDown.Location = new System.Drawing.Point(197, 117);
            this.yNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.yNumericUpDown.Name = "yNumericUpDown";
            this.yNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.yNumericUpDown.TabIndex = 4;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(319, 270);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(157, 20);
            this.output.TabIndex = 5;
            this.output.Visible = false;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(362, 217);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Вычислить";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 302);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.output);
            this.Controls.Add(this.yNumericUpDown);
            this.Controls.Add(this.xNumericUpDown);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.NumericUpDown xNumericUpDown;
        private System.Windows.Forms.NumericUpDown yNumericUpDown;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button submit;
    }
}

