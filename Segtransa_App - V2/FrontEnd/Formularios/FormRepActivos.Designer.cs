namespace FrontEnd
{
    partial class frmRepActivo
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
            this.ActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SEGTRANSADataSetActivo = new FrontEnd.SEGTRANSADataSetActivo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ActivosTableAdapter = new FrontEnd.SEGTRANSADataSetActivoTableAdapters.ActivosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEGTRANSADataSetActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivosBindingSource
            // 
            this.ActivosBindingSource.DataMember = "Activos";
            this.ActivosBindingSource.DataSource = this.SEGTRANSADataSetActivo;
            // 
            // SEGTRANSADataSetActivo
            // 
            this.SEGTRANSADataSetActivo.DataSetName = "SEGTRANSADataSetActivo";
            this.SEGTRANSADataSetActivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSourceActivo";
            reportDataSource2.Value = this.ActivosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rptActivo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 15);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(704, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // ActivosTableAdapter
            // 
            this.ActivosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRepActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepActivo";
            this.Text = "Reporte de Activos";
            this.Load += new System.EventHandler(this.frmRepActivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEGTRANSADataSetActivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ActivosBindingSource;
        private SEGTRANSADataSetActivo SEGTRANSADataSetActivo;
        private SEGTRANSADataSetActivoTableAdapters.ActivosTableAdapter ActivosTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}