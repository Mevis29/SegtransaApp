namespace FrontEnd
{
    partial class frmRepUsuario
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
            this.UsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SEGTRANSADataSetUsuarios = new FrontEnd.SEGTRANSADataSetUsuarios();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UsuariosTableAdapter = new FrontEnd.SEGTRANSADataSetUsuariosTableAdapters.UsuariosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEGTRANSADataSetUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariosBindingSource
            // 
            this.UsuariosBindingSource.DataMember = "Usuarios";
            this.UsuariosBindingSource.DataSource = this.SEGTRANSADataSetUsuarios;
            // 
            // SEGTRANSADataSetUsuarios
            // 
            this.SEGTRANSADataSetUsuarios.DataSetName = "SEGTRANSADataSetUsuarios";
            this.SEGTRANSADataSetUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSourceUsuario";
            reportDataSource1.Value = this.UsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rptUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(660, 377);
            this.reportViewer1.TabIndex = 0;
            // 
            // UsuariosTableAdapter
            // 
            this.UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRepUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Usuarios";
            this.Load += new System.EventHandler(this.frmRepUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEGTRANSADataSetUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UsuariosBindingSource;
        private SEGTRANSADataSetUsuarios SEGTRANSADataSetUsuarios;
        private SEGTRANSADataSetUsuariosTableAdapters.UsuariosTableAdapter UsuariosTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}