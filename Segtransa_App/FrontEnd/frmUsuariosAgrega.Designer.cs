﻿namespace FrontEnd
{
    partial class frmUsuariosAgrega
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
            this.grpBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.cmbBoxGeneros = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreUsu = new System.Windows.Forms.Label();
            this.grpBoxDatosContacto = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.grpBoxAcceso = new System.Windows.Forms.GroupBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.cmbBoxRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpBoxDatosPersonales.SuspendLayout();
            this.grpBoxDatosContacto.SuspendLayout();
            this.grpBoxAcceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxDatosPersonales
            // 
            this.grpBoxDatosPersonales.Controls.Add(this.cmbBoxGeneros);
            this.grpBoxDatosPersonales.Controls.Add(this.lblGenero);
            this.grpBoxDatosPersonales.Controls.Add(this.txtApellido2);
            this.grpBoxDatosPersonales.Controls.Add(this.lblApellido2);
            this.grpBoxDatosPersonales.Controls.Add(this.txtApellido1);
            this.grpBoxDatosPersonales.Controls.Add(this.lblApellido1);
            this.grpBoxDatosPersonales.Controls.Add(this.txtNombre);
            this.grpBoxDatosPersonales.Controls.Add(this.lblNombreUsu);
            this.grpBoxDatosPersonales.Location = new System.Drawing.Point(30, 27);
            this.grpBoxDatosPersonales.Name = "grpBoxDatosPersonales";
            this.grpBoxDatosPersonales.Size = new System.Drawing.Size(330, 226);
            this.grpBoxDatosPersonales.TabIndex = 0;
            this.grpBoxDatosPersonales.TabStop = false;
            this.grpBoxDatosPersonales.Text = "Datos Personales";
            // 
            // cmbBoxGeneros
            // 
            this.cmbBoxGeneros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGeneros.FormattingEnabled = true;
            this.cmbBoxGeneros.Items.AddRange(new object[] {
            "F",
            "M",
            "O"});
            this.cmbBoxGeneros.Location = new System.Drawing.Point(148, 167);
            this.cmbBoxGeneros.Name = "cmbBoxGeneros";
            this.cmbBoxGeneros.Size = new System.Drawing.Size(145, 21);
            this.cmbBoxGeneros.TabIndex = 7;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(27, 170);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Genero:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(148, 126);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(145, 20);
            this.txtApellido2.TabIndex = 5;
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(25, 129);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(93, 13);
            this.lblApellido2.TabIndex = 4;
            this.lblApellido2.Text = "Segundo Apellido:";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(148, 79);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(145, 20);
            this.txtApellido1.TabIndex = 3;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(25, 82);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(79, 13);
            this.lblApellido1.TabIndex = 2;
            this.lblApellido1.Text = "Primer Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(148, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombreUsu
            // 
            this.lblNombreUsu.AutoSize = true;
            this.lblNombreUsu.Location = new System.Drawing.Point(25, 35);
            this.lblNombreUsu.Name = "lblNombreUsu";
            this.lblNombreUsu.Size = new System.Drawing.Size(47, 13);
            this.lblNombreUsu.TabIndex = 0;
            this.lblNombreUsu.Text = "Nombre:";
            // 
            // grpBoxDatosContacto
            // 
            this.grpBoxDatosContacto.Controls.Add(this.txtDireccion);
            this.grpBoxDatosContacto.Controls.Add(this.lblDireccion);
            this.grpBoxDatosContacto.Controls.Add(this.txtEmail);
            this.grpBoxDatosContacto.Controls.Add(this.lblEmail);
            this.grpBoxDatosContacto.Controls.Add(this.txtTelefono);
            this.grpBoxDatosContacto.Controls.Add(this.lblTelefono);
            this.grpBoxDatosContacto.Location = new System.Drawing.Point(422, 27);
            this.grpBoxDatosContacto.Name = "grpBoxDatosContacto";
            this.grpBoxDatosContacto.Size = new System.Drawing.Size(330, 226);
            this.grpBoxDatosContacto.TabIndex = 1;
            this.grpBoxDatosContacto.TabStop = false;
            this.grpBoxDatosContacto.Text = "Datos de Contacto";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(139, 129);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(174, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(27, 129);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(139, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 81);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(97, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Correo Electronico:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(139, 32);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(174, 20);
            this.txtTelefono.TabIndex = 1;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(24, 35);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Telefono:";
            // 
            // grpBoxAcceso
            // 
            this.grpBoxAcceso.Controls.Add(this.txtContrasena);
            this.grpBoxAcceso.Controls.Add(this.lblContrasena);
            this.grpBoxAcceso.Controls.Add(this.cmbBoxRol);
            this.grpBoxAcceso.Controls.Add(this.lblRol);
            this.grpBoxAcceso.Location = new System.Drawing.Point(30, 284);
            this.grpBoxAcceso.Name = "grpBoxAcceso";
            this.grpBoxAcceso.Size = new System.Drawing.Size(330, 126);
            this.grpBoxAcceso.TabIndex = 2;
            this.grpBoxAcceso.TabStop = false;
            this.grpBoxAcceso.Text = "Acceso a la Aplicacion";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(148, 81);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(145, 20);
            this.txtContrasena.TabIndex = 3;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(28, 81);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(64, 13);
            this.lblContrasena.TabIndex = 2;
            this.lblContrasena.Text = "Contrasena:";
            // 
            // cmbBoxRol
            // 
            this.cmbBoxRol.FormattingEnabled = true;
            this.cmbBoxRol.Location = new System.Drawing.Point(148, 31);
            this.cmbBoxRol.Name = "cmbBoxRol";
            this.cmbBoxRol.Size = new System.Drawing.Size(145, 21);
            this.cmbBoxRol.TabIndex = 1;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(28, 31);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 13);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Rol:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(449, 304);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(111, 32);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Agregar";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(677, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmUsuariosAgrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.grpBoxAcceso);
            this.Controls.Add(this.grpBoxDatosContacto);
            this.Controls.Add(this.grpBoxDatosPersonales);
            this.Name = "frmUsuariosAgrega";
            this.Text = "Agregar Nuevo Usuario";
            this.Load += new System.EventHandler(this.frmUsuariosAgrega_Load);
            this.grpBoxDatosPersonales.ResumeLayout(false);
            this.grpBoxDatosPersonales.PerformLayout();
            this.grpBoxDatosContacto.ResumeLayout(false);
            this.grpBoxDatosContacto.PerformLayout();
            this.grpBoxAcceso.ResumeLayout(false);
            this.grpBoxAcceso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxDatosPersonales;
        private System.Windows.Forms.Label lblNombreUsu;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbBoxGeneros;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.GroupBox grpBoxDatosContacto;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox grpBoxAcceso;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.ComboBox cmbBoxRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnCancelar;
    }
}