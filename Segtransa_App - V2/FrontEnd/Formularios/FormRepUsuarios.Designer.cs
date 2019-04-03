namespace FrontEnd.Formularios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.UsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SEGTRANSADataSetUsuarios = new FrontEnd.SegtransaDataSetUsuarios();
            this.rpvListaUsuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UsuariosTableAdapter = new FrontEnd.SegtransaDataSetUsuariosTableAdapters.spUsuariosRetornaDatosIdTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cerrarVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpFiltrosReporte = new System.Windows.Forms.GroupBox();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEGTRANSADataSetUsuarios)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpFiltrosReporte.SuspendLayout();
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
            // rpvListaUsuarios
            // 
            reportDataSource2.Name = "DataSourceUsuario";
            reportDataSource2.Value = this.UsuariosBindingSource;
            this.rpvListaUsuarios.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvListaUsuarios.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rptUsuario.rdlc";
            this.rpvListaUsuarios.Location = new System.Drawing.Point(24, 125);
            this.rpvListaUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.rpvListaUsuarios.Name = "rpvListaUsuarios";
            this.rpvListaUsuarios.ServerReport.BearerToken = null;
            this.rpvListaUsuarios.Size = new System.Drawing.Size(1031, 416);
            this.rpvListaUsuarios.TabIndex = 0;
            // 
            // UsuariosTableAdapter
            // 
            this.UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarVentanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cerrarVentanaToolStripMenuItem
            // 
            this.cerrarVentanaToolStripMenuItem.Name = "cerrarVentanaToolStripMenuItem";
            this.cerrarVentanaToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.cerrarVentanaToolStripMenuItem.Text = "Cerrar Ventana";
            // 
            // grpFiltrosReporte
            // 
            this.grpFiltrosReporte.Controls.Add(this.txtCorreo);
            this.grpFiltrosReporte.Controls.Add(this.lblCorreo);
            this.grpFiltrosReporte.Controls.Add(this.btnVerReporte);
            this.grpFiltrosReporte.Controls.Add(this.txtCedula);
            this.grpFiltrosReporte.Controls.Add(this.lblCedula);
            this.grpFiltrosReporte.Controls.Add(this.txtNombre);
            this.grpFiltrosReporte.Controls.Add(this.lblUsuario);
            this.grpFiltrosReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltrosReporte.Location = new System.Drawing.Point(24, 31);
            this.grpFiltrosReporte.Name = "grpFiltrosReporte";
            this.grpFiltrosReporte.Size = new System.Drawing.Size(1031, 90);
            this.grpFiltrosReporte.TabIndex = 3;
            this.grpFiltrosReporte.TabStop = false;
            this.grpFiltrosReporte.Text = "Filtrar Reporte por:";
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Location = new System.Drawing.Point(883, 37);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(130, 33);
            this.btnVerReporte.TabIndex = 2;
            this.btnVerReporte.Text = "Ver Reporte";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(448, 40);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(145, 26);
            this.txtCedula.TabIndex = 1;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(376, 43);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(66, 20);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cedula:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(175, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(6, 43);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(159, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Nombre de Usuario:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(683, 40);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(194, 26);
            this.txtCorreo.TabIndex = 3;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(611, 43);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(65, 20);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo:";
            // 
            // frmRepUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpFiltrosReporte);
            this.Controls.Add(this.rpvListaUsuarios);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRepUsuario";
            this.Text = "Reporte de Usuarios";
            this.Load += new System.EventHandler(this.frmRepUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEGTRANSADataSetUsuarios)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpFiltrosReporte.ResumeLayout(false);
            this.grpFiltrosReporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvListaUsuarios;
        private System.Windows.Forms.BindingSource UsuariosBindingSource;
        private SegtransaDataSetUsuarios SEGTRANSADataSetUsuarios;
        private SegtransaDataSetUsuariosTableAdapters.spUsuariosRetornaDatosIdTableAdapter UsuariosTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarVentanaToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpFiltrosReporte;
        private System.Windows.Forms.Button btnVerReporte;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
    }
}