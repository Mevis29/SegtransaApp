namespace FrontEnd
{
    partial class frmRepRolUsuario
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
            this.Rol_UsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SEGTRANSADataSetRolUsuario = new FrontEnd.SEGTRANSADataSetRolUsuario();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Rol_UsuariosTableAdapter = new FrontEnd.SEGTRANSADataSetRolUsuarioTableAdapters.Rol_UsuariosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Rol_UsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEGTRANSADataSetRolUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // Rol_UsuariosBindingSource
            // 
            this.Rol_UsuariosBindingSource.DataMember = "Rol_Usuarios";
            this.Rol_UsuariosBindingSource.DataSource = this.SEGTRANSADataSetRolUsuario;
            // 
            // SEGTRANSADataSetRolUsuario
            // 
            this.SEGTRANSADataSetRolUsuario.DataSetName = "SEGTRANSADataSetRolUsuario";
            this.SEGTRANSADataSetRolUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSourceRolUsuario";
            reportDataSource2.Value = this.Rol_UsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rptRolUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(675, 332);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Rol_UsuariosTableAdapter
            // 
            this.Rol_UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
            // frmRepRolUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(711, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepRolUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Roles de Usuario";
            this.Load += new System.EventHandler(this.frmRepRolUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rol_UsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEGTRANSADataSetRolUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Rol_UsuariosBindingSource;
        private SEGTRANSADataSetRolUsuario SEGTRANSADataSetRolUsuario;
        private SEGTRANSADataSetRolUsuarioTableAdapters.Rol_UsuariosTableAdapter Rol_UsuariosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}