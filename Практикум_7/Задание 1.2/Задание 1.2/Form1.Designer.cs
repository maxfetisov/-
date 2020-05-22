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
            this.input = new System.Windows.Forms.RichTextBox();
            this.imLabel = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(33, 50);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(524, 237);
            this.input.TabIndex = 0;
            this.input.Text = "";
            // 
            // imLabel
            // 
            this.imLabel.AutoSize = true;
            this.imLabel.Location = new System.Drawing.Point(30, 24);
            this.imLabel.Name = "imLabel";
            this.imLabel.Size = new System.Drawing.Size(89, 13);
            this.imLabel.TabIndex = 1;
            this.imLabel.Text = "Введите строку:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(248, 315);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Проверить";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(33, 412);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(524, 20);
            this.output.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 487);
            this.Controls.Add(this.output);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.imLabel);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.Label imLabel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox output;
    }
}

