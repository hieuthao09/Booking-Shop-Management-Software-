namespace QL_NhaSach
{
    partial class InHoaDon
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
            this.QL_NhaSachDataSet = new QL_NhaSach.QL_NhaSachDataSet();
            this.chitiethoadon_InBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chitiethoadon_InTableAdapter = new QL_NhaSach.QL_NhaSachDataSetTableAdapters.chitiethoadon_InTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_NhaSachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethoadon_InBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.chitiethoadon_InBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_NhaSach.InHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1014, 665);
            this.reportViewer1.TabIndex = 0;
            // 
            // QL_NhaSachDataSet
            // 
            this.QL_NhaSachDataSet.DataSetName = "QL_NhaSachDataSet";
            this.QL_NhaSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chitiethoadon_InBindingSource
            // 
            this.chitiethoadon_InBindingSource.DataMember = "chitiethoadon_In";
            this.chitiethoadon_InBindingSource.DataSource = this.QL_NhaSachDataSet;
            // 
            // chitiethoadon_InTableAdapter
            // 
            this.chitiethoadon_InTableAdapter.ClearBeforeFill = true;
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 665);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InHoaDon";
            this.Text = "InHoaDon";
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_NhaSachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethoadon_InBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource chitiethoadon_InBindingSource;
        private QL_NhaSachDataSet QL_NhaSachDataSet;
        private QL_NhaSachDataSetTableAdapters.chitiethoadon_InTableAdapter chitiethoadon_InTableAdapter;
    }
}