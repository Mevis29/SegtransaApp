namespace FrontEnd
{
    partial class frmRepProveedor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SEGTRANSADataSetProveedor = new FrontEnd.SEGTRANSADataSetProveedor();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProveedoresTableAdapter = new FrontEnd.SEGTRANSADataSetProveedorTableAdapters.ProveedoresTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEGTRANSADataSetProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // ProveedoresBindingSource
            // 
            this.ProveedoresBindingSource.DataMember = "Proveedores";
            this.ProveedoresBindingSource.DataSource = this.SEGTRANSADataSetProveedor;
            // 
            // SEGTRANSADataSetProveedor
            // 
            this.SEGTRANSADataSetProveedor.DataSetName = "SEGTRANSADataSetProveedor";
            this.SEGTRANSADataSetProveedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSourceProveedor";
            reportDataSource2.Value = this.ProveedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rptProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(669, 297);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProveedoresTableAdapter
            // 
            this.ProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRepProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepProveedor";
            this.Text = "Reporte de Proveedores";
            this.Load += new System.EventHandler(this.frmRepProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEGTRANSADataSetProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProveedoresBindingSource;
        private SEGTRANSADataSetProveedor SEGTRANSADataSetProveedor;
        private SEGTRANSADataSetProveedorTableAdapters.ProveedoresTableAdapter ProveedoresTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}