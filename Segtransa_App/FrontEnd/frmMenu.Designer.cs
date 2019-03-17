using System;

namespace FrontEnd
{
    partial class frmMenuReporte
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
            this.btnMisActivos = new System.Windows.Forms.Button();
            this.btnMisDatos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnActivos = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMisActivos
            // 
            this.btnMisActivos.Location = new System.Drawing.Point(12, 17);
            this.btnMisActivos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMisActivos.Name = "btnMisActivos";
            this.btnMisActivos.Size = new System.Drawing.Size(73, 19);
            this.btnMisActivos.TabIndex = 0;
            this.btnMisActivos.Text = "Mis Activos";
            this.btnMisActivos.UseVisualStyleBackColor = true;
            this.btnMisActivos.Click += new System.EventHandler(this.btnMisActivos_Click);
            // 
            // btnMisDatos
            // 
            this.btnMisDatos.Location = new System.Drawing.Point(12, 41);
            this.btnMisDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMisDatos.Name = "btnMisDatos";
            this.btnMisDatos.Size = new System.Drawing.Size(73, 19);
            this.btnMisDatos.TabIndex = 1;
            this.btnMisDatos.Text = "Mis Datos";
            this.btnMisDatos.UseVisualStyleBackColor = true;
            this.btnMisDatos.Click += new System.EventHandler(this.btnMisDatos_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(12, 65);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(150, 28);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(89, 17);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(73, 19);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnActivos
            // 
            this.btnActivos.Location = new System.Drawing.Point(89, 41);
            this.btnActivos.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivos.Name = "btnActivos";
            this.btnActivos.Size = new System.Drawing.Size(73, 19);
            this.btnActivos.TabIndex = 4;
            this.btnActivos.Text = "Activos";
            this.btnActivos.UseVisualStyleBackColor = true;
            this.btnActivos.Click += new System.EventHandler(this.btnActivos_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(14, 207);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(61, 24);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Salir";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(131, 207);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 24);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Atras";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(14, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(176, 81);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bienvenido";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(102, 15);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(4, 41);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMisActivos);
            this.groupBox2.Controls.Add(this.btnMisDatos);
            this.groupBox2.Controls.Add(this.btnReportes);
            this.groupBox2.Controls.Add(this.btnUsuarios);
            this.groupBox2.Controls.Add(this.btnActivos);
            this.groupBox2.Location = new System.Drawing.Point(14, 105);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(176, 98);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 250);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMisActivos;
        private System.Windows.Forms.Button btnMisDatos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnActivos;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}