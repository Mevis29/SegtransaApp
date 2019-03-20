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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(571, 436);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 32);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Atras";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRepActivo
            // 
            this.btnRepActivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepActivo.Location = new System.Drawing.Point(180, 153);
            this.btnRepActivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepActivo.Name = "btnRepActivo";
            this.btnRepActivo.Size = new System.Drawing.Size(136, 40);
            this.btnRepActivo.TabIndex = 1;
            this.btnRepActivo.Text = "Activos";
            this.btnRepActivo.UseVisualStyleBackColor = true;
            this.btnRepActivo.Click += new System.EventHandler(this.btnRepActivo_Click);
            // 
            // btnRepBitacora
            // 
            this.btnRepBitacora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepBitacora.Location = new System.Drawing.Point(180, 226);
            this.btnRepBitacora.Name = "btnRepBitacora";
            this.btnRepBitacora.Size = new System.Drawing.Size(136, 47);
            this.btnRepBitacora.TabIndex = 2;
            this.btnRepBitacora.Text = "Bitácora";
            this.btnRepBitacora.UseVisualStyleBackColor = true;
            this.btnRepBitacora.Click += new System.EventHandler(this.btnRepBitacora_Click);
            // 
            // btnRepProveedor
            // 
            this.btnRepProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepProveedor.Location = new System.Drawing.Point(383, 153);
            this.btnRepProveedor.Name = "btnRepProveedor";
            this.btnRepProveedor.Size = new System.Drawing.Size(135, 40);
            this.btnRepProveedor.TabIndex = 3;
            this.btnRepProveedor.Text = "Proveedores";
            this.btnRepProveedor.UseVisualStyleBackColor = true;
            this.btnRepProveedor.Click += new System.EventHandler(this.btnRepProveedor_Click);
            // 
            // btnRepRolUsuario
            // 
            this.btnRepRolUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepRolUsuario.Location = new System.Drawing.Point(383, 226);
            this.btnRepRolUsuario.Name = "btnRepRolUsuario";
            this.btnRepRolUsuario.Size = new System.Drawing.Size(135, 47);
            this.btnRepRolUsuario.TabIndex = 4;
            this.btnRepRolUsuario.Text = "Roles";
            this.btnRepRolUsuario.UseVisualStyleBackColor = true;
            this.btnRepRolUsuario.Click += new System.EventHandler(this.btnRepRolUsuario_Click);
            // 
            // btnRepUsuario
            // 
            this.btnRepUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepUsuario.Location = new System.Drawing.Point(290, 314);
            this.btnRepUsuario.Name = "btnRepUsuario";
            this.btnRepUsuario.Size = new System.Drawing.Size(115, 49);
            this.btnRepUsuario.TabIndex = 5;
            this.btnRepUsuario.Text = "Usuarios";
            this.btnRepUsuario.UseVisualStyleBackColor = true;
            this.btnRepUsuario.Click += new System.EventHandler(this.btnRepUsuario_Click);
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
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(711, 515);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Panel panel1;
    }
}