namespace FrontEnd.Formularios
{
    partial class frmUsuarioModifica
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
            this.grbDatosAcceso = new System.Windows.Forms.GroupBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lsbEstado = new System.Windows.Forms.ListBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lsbRol = new System.Windows.Forms.ListBox();
            this.grbDatosIngreso = new System.Windows.Forms.GroupBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.grbDatosContacto = new System.Windows.Forms.GroupBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.grbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.dtpFechaCreacn = new System.Windows.Forms.DateTimePicker();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grbDatosAcceso.SuspendLayout();
            this.grbDatosIngreso.SuspendLayout();
            this.grbDatosContacto.SuspendLayout();
            this.grbDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosAcceso
            // 
            this.grbDatosAcceso.Controls.Add(this.lblRol);
            this.grbDatosAcceso.Controls.Add(this.lsbEstado);
            this.grbDatosAcceso.Controls.Add(this.lblEstado);
            this.grbDatosAcceso.Controls.Add(this.lsbRol);
            this.grbDatosAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosAcceso.Location = new System.Drawing.Point(29, 425);
            this.grbDatosAcceso.Name = "grbDatosAcceso";
            this.grbDatosAcceso.Size = new System.Drawing.Size(450, 155);
            this.grbDatosAcceso.TabIndex = 62;
            this.grbDatosAcceso.TabStop = false;
            this.grbDatosAcceso.Text = "Acceso de la Aplicación:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(250, 50);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(143, 24);
            this.lblRol.TabIndex = 32;
            this.lblRol.Text = "Rol del Usuario:";
            // 
            // lsbEstado
            // 
            this.lsbEstado.DisplayMember = "Nombre";
            this.lsbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbEstado.FormattingEnabled = true;
            this.lsbEstado.ItemHeight = 22;
            this.lsbEstado.Location = new System.Drawing.Point(30, 80);
            this.lsbEstado.Name = "lsbEstado";
            this.lsbEstado.Size = new System.Drawing.Size(170, 48);
            this.lsbEstado.TabIndex = 11;
            this.lsbEstado.ValueMember = "Id";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(30, 50);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(173, 24);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "Estado del Usuario:";
            // 
            // lsbRol
            // 
            this.lsbRol.DisplayMember = "Nombre";
            this.lsbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbRol.FormattingEnabled = true;
            this.lsbRol.ItemHeight = 22;
            this.lsbRol.Location = new System.Drawing.Point(250, 80);
            this.lsbRol.Name = "lsbRol";
            this.lsbRol.Size = new System.Drawing.Size(170, 48);
            this.lsbRol.TabIndex = 12;
            this.lsbRol.ValueMember = "Id";
            // 
            // grbDatosIngreso
            // 
            this.grbDatosIngreso.Controls.Add(this.lblContrasena);
            this.grbDatosIngreso.Controls.Add(this.txtContrasena);
            this.grbDatosIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosIngreso.Location = new System.Drawing.Point(499, 287);
            this.grbDatosIngreso.Name = "grbDatosIngreso";
            this.grbDatosIngreso.Size = new System.Drawing.Size(450, 110);
            this.grbDatosIngreso.TabIndex = 61;
            this.grbDatosIngreso.TabStop = false;
            this.grbDatosIngreso.Text = "Datos de Ingreso:";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(20, 50);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(111, 24);
            this.lblContrasena.TabIndex = 29;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(200, 50);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(220, 28);
            this.txtContrasena.TabIndex = 10;
            // 
            // grbDatosContacto
            // 
            this.grbDatosContacto.Controls.Add(this.lblCorreo);
            this.grbDatosContacto.Controls.Add(this.txtCorreo);
            this.grbDatosContacto.Controls.Add(this.txtDireccion);
            this.grbDatosContacto.Controls.Add(this.lblTelefono);
            this.grbDatosContacto.Controls.Add(this.txtTelefono);
            this.grbDatosContacto.Controls.Add(this.lblDireccion);
            this.grbDatosContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosContacto.Location = new System.Drawing.Point(499, 31);
            this.grbDatosContacto.Name = "grbDatosContacto";
            this.grbDatosContacto.Size = new System.Drawing.Size(450, 237);
            this.grbDatosContacto.TabIndex = 60;
            this.grbDatosContacto.TabStop = false;
            this.grbDatosContacto.Text = "Datos de Contacto:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(20, 64);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(173, 24);
            this.lblCorreo.TabIndex = 29;
            this.lblCorreo.Text = "Correo Electrónico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(200, 64);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(220, 28);
            this.txtCorreo.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(200, 180);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(220, 30);
            this.txtDireccion.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(20, 114);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 24);
            this.lblTelefono.TabIndex = 20;
            this.lblTelefono.Text = "Teléfono :";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(200, 114);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(220, 28);
            this.txtTelefono.TabIndex = 7;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(20, 180);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(149, 24);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Dirección Física:";
            // 
            // grbDatosPersonales
            // 
            this.grbDatosPersonales.Controls.Add(this.txtCedula);
            this.grbDatosPersonales.Controls.Add(this.dtpFechaCreacn);
            this.grbDatosPersonales.Controls.Add(this.lblApellido);
            this.grbDatosPersonales.Controls.Add(this.lblCedula);
            this.grbDatosPersonales.Controls.Add(this.lblIdUsuario);
            this.grbDatosPersonales.Controls.Add(this.lblNombre);
            this.grbDatosPersonales.Controls.Add(this.lblFechaCreacion);
            this.grbDatosPersonales.Controls.Add(this.txtApellido);
            this.grbDatosPersonales.Controls.Add(this.txtIdUsuario);
            this.grbDatosPersonales.Controls.Add(this.txtNombre);
            this.grbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosPersonales.Location = new System.Drawing.Point(29, 31);
            this.grbDatosPersonales.Name = "grbDatosPersonales";
            this.grbDatosPersonales.Size = new System.Drawing.Size(450, 366);
            this.grbDatosPersonales.TabIndex = 59;
            this.grbDatosPersonales.TabStop = false;
            this.grbDatosPersonales.Text = "Datos Personales:";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(200, 205);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(220, 28);
            this.txtCedula.TabIndex = 0;
            // 
            // dtpFechaCreacn
            // 
            this.dtpFechaCreacn.CustomFormat = "ddd dd-MMM-yyyy";
            this.dtpFechaCreacn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCreacn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCreacn.Location = new System.Drawing.Point(200, 280);
            this.dtpFechaCreacn.Name = "dtpFechaCreacn";
            this.dtpFechaCreacn.Size = new System.Drawing.Size(220, 28);
            this.dtpFechaCreacn.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(20, 161);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(84, 24);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(20, 205);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(137, 24);
            this.lblCedula.TabIndex = 33;
            this.lblCedula.Text = "No. de Cédula:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.Location = new System.Drawing.Point(20, 64);
            this.lblIdUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(94, 24);
            this.lblIdUsuario.TabIndex = 14;
            this.lblIdUsuario.Text = "IdUsuario:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 114);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(20, 280);
            this.lblFechaCreacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(150, 24);
            this.lblFechaCreacion.TabIndex = 30;
            this.lblFechaCreacion.Text = "Fecha Creacion:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(200, 161);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(220, 28);
            this.txtApellido.TabIndex = 3;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(200, 64);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(220, 28);
            this.txtIdUsuario.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(200, 114);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 28);
            this.txtNombre.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(795, 491);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 52);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAceptar.Location = new System.Drawing.Point(574, 491);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(118, 52);
            this.btnAceptar.TabIndex = 57;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // FormUsuarioModifica
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(978, 610);
            this.Controls.Add(this.grbDatosAcceso);
            this.Controls.Add(this.grbDatosIngreso);
            this.Controls.Add(this.grbDatosContacto);
            this.Controls.Add(this.grbDatosPersonales);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FormUsuarioModifica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuarioModifica";
            this.grbDatosAcceso.ResumeLayout(false);
            this.grbDatosAcceso.PerformLayout();
            this.grbDatosIngreso.ResumeLayout(false);
            this.grbDatosIngreso.PerformLayout();
            this.grbDatosContacto.ResumeLayout(false);
            this.grbDatosContacto.PerformLayout();
            this.grbDatosPersonales.ResumeLayout(false);
            this.grbDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosAcceso;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ListBox lsbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ListBox lsbRol;
        private System.Windows.Forms.GroupBox grbDatosIngreso;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.GroupBox grbDatosContacto;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.GroupBox grbDatosPersonales;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacn;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}