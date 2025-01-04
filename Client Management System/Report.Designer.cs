namespace Client_Management_System
{
    partial class Report
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
            this.customerDetails3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.static_Report = new Client_Management_System.Static_Report();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.customer_Details3TableAdapter = new Client_Management_System.Static_ReportTableAdapters.Customer_Details3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetails3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.static_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDetails3BindingSource
            // 
            this.customerDetails3BindingSource.DataMember = "Customer_Details3";
            this.customerDetails3BindingSource.DataSource = this.static_Report;
            // 
            // static_Report
            // 
            this.static_Report.DataSetName = "Static_Report";
            this.static_Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.customerDetails3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Client_Management_System.StaticReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(865, 418);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // customer_Details3TableAdapter
            // 
            this.customer_Details3TableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(871, 425);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDetails3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.static_Report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Static_Report static_Report;
        private System.Windows.Forms.BindingSource customerDetails3BindingSource;
        private Static_ReportTableAdapters.Customer_Details3TableAdapter customer_Details3TableAdapter;
    }
}