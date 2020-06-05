namespace Общежитие
{
    partial class Otchet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ОбщежитиеDataSet = new Общежитие.ОбщежитиеDataSet();
            this.StudentsTableAdapter = new Общежитие.ОбщежитиеDataSetTableAdapters.StudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ОбщежитиеDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StudentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Общежитие.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(985, 514);
            this.reportViewer1.TabIndex = 0;
            // 
            // StudentsBindingSource
            // 
            this.StudentsBindingSource.DataMember = "Students";
            this.StudentsBindingSource.DataSource = this.ОбщежитиеDataSet;
            // 
            // ОбщежитиеDataSet
            // 
            this.ОбщежитиеDataSet.DataSetName = "ОбщежитиеDataSet";
            this.ОбщежитиеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentsTableAdapter
            // 
            this.StudentsTableAdapter.ClearBeforeFill = true;
            // 
            // Otchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 512);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Otchet";
            this.Text = "Otchet";
            this.Load += new System.EventHandler(this.Otchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ОбщежитиеDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StudentsBindingSource;
        private ОбщежитиеDataSet ОбщежитиеDataSet;
        private ОбщежитиеDataSetTableAdapters.StudentsTableAdapter StudentsTableAdapter;
    }
}