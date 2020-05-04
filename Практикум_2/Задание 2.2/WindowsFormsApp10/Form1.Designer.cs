namespace WindowsFormsApp10
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
            this.input = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(177, 47);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(121, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Введите день недели: ";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(319, 44);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(144, 20);
            this.input.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(267, 100);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(128, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Узнать расписание";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(220, 148);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(215, 96);
            this.output.TabIndex = 3;
            this.output.Text = "";
            this.output.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 282);
            this.Controls.Add(this.output);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.input);
            this.Controls.Add(this.inputLabel);
            this.MaximumSize = new System.Drawing.Size(673, 321);
            this.MinimumSize = new System.Drawing.Size(673, 321);
            this.Name = "Form1";
            this.Text = "S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox output;
    }
}

