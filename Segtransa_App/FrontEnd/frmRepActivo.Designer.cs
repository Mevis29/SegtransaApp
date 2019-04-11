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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SEGTRANSADataSetActivo = new FrontEnd.SEGTRANSADataSetActivo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ActivosTableAdapter = new FrontEnd.SEGTRANSADataSetActivoTableAdapters.ActivosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.reportViewer1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSourceActivo";
            reportDataSource1.Value = this.ActivosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rptActivo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(671, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // ActivosTableAdapter
            // 
            this.ActivosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(590, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FrontEnd.Properties.Resources.logo3_01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(16, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 52);
            this.panel1.TabIndex = 17;
            // 
            // frmRepActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(711, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepActivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Panel panel1;
    }
}