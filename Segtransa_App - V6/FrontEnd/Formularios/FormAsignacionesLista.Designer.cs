namespace FrontEnd.Formularios
{
    partial class FormAsignacionesLista
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtActivo = new System.Windows.Forms.TextBox();
            this.lblAsignacion = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.grpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpciones,
            this.mnuCerrar});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(980, 36);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuOpciones
            // 
            this.mnuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregar,
            this.mnuModificar,
            this.mnuEliminar});
            this.mnuOpciones.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuOpciones.Name = "mnuOpciones";
            this.mnuOpciones.Size = new System.Drawing.Size(106, 32);
            this.mnuOpciones.Text = "Opciones";
            // 
            // mnuAgregar
            // 
            this.mnuAgregar.Name = "mnuAgregar";
            this.mnuAgregar.Size = new System.Drawing.Size(502, 32);
            this.mnuAgregar.Text = "Agregar Nueva Asignacion por Usuario";
            this.mnuAgregar.Click += new System.EventHandler(this.mnuAgregar_Click);
            // 
            // mnuModificar
            // 
            this.mnuModificar.Name = "mnuModificar";
            this.mnuModificar.Size = new System.Drawing.Size(502, 32);
            this.mnuModificar.Text = "Modificar Asignacion por Usuario Seleccionada";
            this.mnuModificar.Click += new System.EventHandler(this.mnuModificar_Click);
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Name = "mnuEliminar";
            this.mnuEliminar.Size = new System.Drawing.Size(502, 32);
            this.mnuEliminar.Text = "Eliminar Asignacion por Usuario Seleccionada";
            this.mnuEliminar.Click += new System.EventHandler(this.mnuEliminar_Click);
            // 
            // mnuCerrar
            // 
            this.mnuCerrar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuCerrar.Name = "mnuCerrar";
            this.mnuCerrar.Size = new System.Drawing.Size(152, 32);
            this.mnuCerrar.Text = "Cerrar Ventana";
            this.mnuCerrar.Click += new System.EventHandler(this.mnuCerrar_Click);
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.txtUsuario);
            this.grpBuscar.Controls.Add(this.lblUsuario);
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Controls.Add(this.txtActivo);
            this.grpBuscar.Controls.Add(this.lblAsignacion);
            this.grpBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBuscar.Location = new System.Drawing.Point(17, 65);
            this.grpBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.grpBuscar.Size = new System.Drawing.Size(936, 93);
            this.grpBuscar.TabIndex = 16;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar Por:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(109, 39);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(251, 28);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(10, 40);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 24);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(754, 29);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 38);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtActivo
            // 
            this.txtActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivo.Location = new System.Drawing.Point(473, 39);
            this.txtActivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.Size = new System.Drawing.Size(208, 28);
            this.txtActivo.TabIndex = 2;
            // 
            // lblAsignacion
            // 
            this.lblAsignacion.AutoSize = true;
            this.lblAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignacion.Location = new System.Drawing.Point(383, 39);
            this.lblAsignacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsignacion.Name = "lblAsignacion";
            this.lblAsignacion.Size = new System.Drawing.Size(66, 24);
            this.lblAsignacion.TabIndex = 2;
            this.lblAsignacion.Text = "Activo:";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvLista.Location = new System.Drawing.Point(17, 185);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 50;
            this.dgvLista.RowTemplate.Height = 40;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(955, 260);
            this.dgvLista.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "IdAsignacion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Cedula";
            this.Column2.HeaderText = "Cédula Usuario";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "Usuario";
            this.Column3.HeaderText = "Nombre Usuario";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Codigo";
            this.Column4.HeaderText = "Código Activo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "Descripcion";
            this.Column5.HeaderText = "Descripcion Activo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "FechaInicialAsignacion ";
            this.Column6.HeaderText = "Fecha Inicial ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "FechafinalAsignacion ";
            this.Column7.HeaderText = "Fecha Final";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // FormAsignacionesLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAsignacionesLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Asignaciones por Usuario";
            this.Load += new System.EventHandler(this.FormAsignacionesLista_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregar;
        private System.Windows.Forms.ToolStripMenuItem mnuModificar;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
        private System.Windows.Forms.ToolStripMenuItem mnuCerrar;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtActivo;
        private System.Windows.Forms.Label lblAsignacion;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}