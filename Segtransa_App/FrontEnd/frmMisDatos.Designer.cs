namespace FrontEnd
{
    partial class frmMisDatos
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
            this.btnActualizarClave = new System.Windows.Forms.Button();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.lvMisDatos = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(601, 451);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 38);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Atras";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnActualizarClave
            // 
            this.btnActualizarClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarClave.Location = new System.Drawing.Point(287, 444);
            this.btnActualizarClave.Name = "btnActualizarClave";
            this.btnActualizarClave.Size = new System.Drawing.Size(154, 23);
            this.btnActualizarClave.TabIndex = 10;
            this.btnActualizarClave.Text = "Actualizar Clave";
            this.btnActualizarClave.UseVisualStyleBackColor = true;
            this.btnActualizarClave.Click += new System.EventHandler(this.btnActualizarClave_Click);
            // 
            // txbClave
            // 
            this.txbClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClave.Location = new System.Drawing.Point(44, 444);
            this.txbClave.Name = "txbClave";
            this.txbClave.PasswordChar = '@';
            this.txbClave.Size = new System.Drawing.Size(185, 23);
            this.txbClave.TabIndex = 11;
            // 
            // lvMisDatos
            // 
            this.lvMisDatos.AllowColumnReorder = true;
            this.lvMisDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMisDatos.GridLines = true;
            this.lvMisDatos.HoverSelection = true;
            this.lvMisDatos.Location = new System.Drawing.Point(16, 93);
            this.lvMisDatos.Name = "lvMisDatos";
            this.lvMisDatos.Size = new System.Drawing.Size(675, 320);
            this.lvMisDatos.TabIndex = 9;
            this.lvMisDatos.UseCompatibleStateImageBehavior = false;
            this.lvMisDatos.View = System.Windows.Forms.View.Details;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ingrese su nueva clave";
            // 
            // frmMisDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(711, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.btnActualizarClave);
            this.Controls.Add(this.lvMisDatos);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMisDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mis Datos";
            this.Load += new System.EventHandler(this.frmMisDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnActualizarClave;
        private System.Windows.Forms.TextBox txbClave;
        private System.Windows.Forms.ListView lvMisDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}