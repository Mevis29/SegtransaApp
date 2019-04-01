namespace FrontEnd.Formularios
{
    partial class FormInicial
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuCatalogo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActivos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAsignaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReparaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteAsignacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteReparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblDatosLogin = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCatalogo,
            this.mnuReportes,
            this.mnuSalir});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 28);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "Menu Principal ";
            // 
            // mnuCatalogo
            // 
            this.mnuCatalogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuario,
            this.mnuActivos,
            this.mnuAsignaciones,
            this.mnuReparaciones,
            this.mnuBitacora});
            this.mnuCatalogo.Name = "mnuCatalogo";
            this.mnuCatalogo.Size = new System.Drawing.Size(82, 24);
            this.mnuCatalogo.Text = "Catalogo";
            // 
            // mnuUsuario
            // 
            this.mnuUsuario.Name = "mnuUsuario";
            this.mnuUsuario.Size = new System.Drawing.Size(248, 26);
            this.mnuUsuario.Text = "Gestion de Usuario";
            // 
            // mnuActivos
            // 
            this.mnuActivos.Name = "mnuActivos";
            this.mnuActivos.Size = new System.Drawing.Size(248, 26);
            this.mnuActivos.Text = "Gestion de Activos";
            // 
            // mnuAsignaciones
            // 
            this.mnuAsignaciones.Name = "mnuAsignaciones";
            this.mnuAsignaciones.Size = new System.Drawing.Size(248, 26);
            this.mnuAsignaciones.Text = "Gestion de Asignaciones";
            // 
            // mnuReparaciones
            // 
            this.mnuReparaciones.Name = "mnuReparaciones";
            this.mnuReparaciones.Size = new System.Drawing.Size(248, 26);
            this.mnuReparaciones.Text = "Gestion de Reparaciones";
            // 
            // mnuBitacora
            // 
            this.mnuBitacora.Name = "mnuBitacora";
            this.mnuBitacora.Size = new System.Drawing.Size(248, 26);
            this.mnuBitacora.Text = "Bitacora";
            // 
            // mnuReportes
            // 
            this.mnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteUsuariosToolStripMenuItem,
            this.reporteActivosToolStripMenuItem,
            this.reporteAsignacionesToolStripMenuItem,
            this.reporteReparacionesToolStripMenuItem});
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(80, 24);
            this.mnuReportes.Text = "Reportes";
            // 
            // reporteUsuariosToolStripMenuItem
            // 
            this.reporteUsuariosToolStripMenuItem.Name = "reporteUsuariosToolStripMenuItem";
            this.reporteUsuariosToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.reporteUsuariosToolStripMenuItem.Text = "Reporte Usuarios";
            // 
            // reporteActivosToolStripMenuItem
            // 
            this.reporteActivosToolStripMenuItem.Name = "reporteActivosToolStripMenuItem";
            this.reporteActivosToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.reporteActivosToolStripMenuItem.Text = "Reporte Activos";
            // 
            // reporteAsignacionesToolStripMenuItem
            // 
            this.reporteAsignacionesToolStripMenuItem.Name = "reporteAsignacionesToolStripMenuItem";
            this.reporteAsignacionesToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.reporteAsignacionesToolStripMenuItem.Text = "Reporte Asignaciones";
            // 
            // reporteReparacionesToolStripMenuItem
            // 
            this.reporteReparacionesToolStripMenuItem.Name = "reporteReparacionesToolStripMenuItem";
            this.reporteReparacionesToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.reporteReparacionesToolStripMenuItem.Text = "Reporte Reparaciones";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(50, 24);
            this.mnuSalir.Text = "Salir";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(29, 412);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(115, 412);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(139, 20);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "NombreUsuario";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(487, 410);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(137, 20);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Último Ingreso:";
            // 
            // lblDatosLogin
            // 
            this.lblDatosLogin.AutoSize = true;
            this.lblDatosLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosLogin.Location = new System.Drawing.Point(630, 410);
            this.lblDatosLogin.Name = "lblDatosLogin";
            this.lblDatosLogin.Size = new System.Drawing.Size(105, 20);
            this.lblDatosLogin.TabIndex = 6;
            this.lblDatosLogin.Text = "DatosLogin";
            // 
            // FormInicial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::FrontEnd.Properties.Resources.logo3_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDatosLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.mnuPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal de Segtransa S.A";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalogo;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuActivos;
        private System.Windows.Forms.ToolStripMenuItem mnuAsignaciones;
        private System.Windows.Forms.ToolStripMenuItem mnuReparaciones;
        private System.Windows.Forms.ToolStripMenuItem mnuBitacora;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem reporteUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteAsignacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteReparacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblDatosLogin;
    }
}