namespace FrontEnd
{
    partial class frmReportes
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRepActivo = new System.Windows.Forms.Button();
            this.btnRepBitacora = new System.Windows.Forms.Button();
            this.btnRepProveedor = new System.Windows.Forms.Button();
            this.btnRepRolUsuario = new System.Windows.Forms.Button();
            this.btnRepUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(206, 211);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 24);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Atras";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRepActivo
            // 
            this.btnRepActivo.Location = new System.Drawing.Point(54, 33);
            this.btnRepActivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepActivo.Name = "btnRepActivo";
            this.btnRepActivo.Size = new System.Drawing.Size(75, 23);
            this.btnRepActivo.TabIndex = 1;
            this.btnRepActivo.Text = "Activos";
            this.btnRepActivo.UseVisualStyleBackColor = true;
            this.btnRepActivo.Click += new System.EventHandler(this.btnRepActivo_Click);
            // 
            // btnRepBitacora
            // 
            this.btnRepBitacora.Location = new System.Drawing.Point(54, 77);
            this.btnRepBitacora.Name = "btnRepBitacora";
            this.btnRepBitacora.Size = new System.Drawing.Size(75, 23);
            this.btnRepBitacora.TabIndex = 2;
            this.btnRepBitacora.Text = "Bitácora";
            this.btnRepBitacora.UseVisualStyleBackColor = true;
            this.btnRepBitacora.Click += new System.EventHandler(this.btnRepBitacora_Click);
            // 
            // btnRepProveedor
            // 
            this.btnRepProveedor.Location = new System.Drawing.Point(54, 119);
            this.btnRepProveedor.Name = "btnRepProveedor";
            this.btnRepProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnRepProveedor.TabIndex = 3;
            this.btnRepProveedor.Text = "Proveedores";
            this.btnRepProveedor.UseVisualStyleBackColor = true;
            this.btnRepProveedor.Click += new System.EventHandler(this.btnRepProveedor_Click);
            // 
            // btnRepRolUsuario
            // 
            this.btnRepRolUsuario.Location = new System.Drawing.Point(54, 163);
            this.btnRepRolUsuario.Name = "btnRepRolUsuario";
            this.btnRepRolUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnRepRolUsuario.TabIndex = 4;
            this.btnRepRolUsuario.Text = "Roles";
            this.btnRepRolUsuario.UseVisualStyleBackColor = true;
            this.btnRepRolUsuario.Click += new System.EventHandler(this.btnRepRolUsuario_Click);
            // 
            // btnRepUsuario
            // 
            this.btnRepUsuario.Location = new System.Drawing.Point(54, 211);
            this.btnRepUsuario.Name = "btnRepUsuario";
            this.btnRepUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnRepUsuario.TabIndex = 5;
            this.btnRepUsuario.Text = "Usuarios";
            this.btnRepUsuario.UseVisualStyleBackColor = true;
            this.btnRepUsuario.Click += new System.EventHandler(this.btnRepUsuario_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 515);
            this.Controls.Add(this.btnRepUsuario);
            this.Controls.Add(this.btnRepRolUsuario);
            this.Controls.Add(this.btnRepProveedor);
            this.Controls.Add(this.btnRepBitacora);
            this.Controls.Add(this.btnRepActivo);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRepActivo;
        private System.Windows.Forms.Button btnRepBitacora;
        private System.Windows.Forms.Button btnRepProveedor;
        private System.Windows.Forms.Button btnRepRolUsuario;
        private System.Windows.Forms.Button btnRepUsuario;
    }
}