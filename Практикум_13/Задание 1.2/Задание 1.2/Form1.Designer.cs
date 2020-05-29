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
            this.submit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(271, 502);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(168, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "Выбрать файл";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 12);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(677, 470);
            this.output.TabIndex = 1;
            this.output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 546);
            this.Controls.Add(this.output);
            this.Controls.Add(this.submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}

