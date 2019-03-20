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
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(529, 181);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 24);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Atras";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnActualizarClave
            // 
            this.btnActualizarClave.Location = new System.Drawing.Point(148, 181);
            this.btnActualizarClave.Name = "btnActualizarClave";
            this.btnActualizarClave.Size = new System.Drawing.Size(113, 23);
            this.btnActualizarClave.TabIndex = 10;
            this.btnActualizarClave.Text = "Actualizar Clave";
            this.btnActualizarClave.UseVisualStyleBackColor = true;
            this.btnActualizarClave.Click += new System.EventHandler(this.btnActualizarClave_Click);
            // 
            // txbClave
            // 
            this.txbClave.Location = new System.Drawing.Point(13, 181);
            this.txbClave.Name = "txbClave";
            this.txbClave.PasswordChar = '@';
            this.txbClave.Size = new System.Drawing.Size(129, 20);
            this.txbClave.TabIndex = 11;
            // 
            // lvMisDatos
            // 
            this.lvMisDatos.AllowColumnReorder = true;
            this.lvMisDatos.GridLines = true;
            this.lvMisDatos.HoverSelection = true;
            this.lvMisDatos.Location = new System.Drawing.Point(12, 12);
            this.lvMisDatos.Name = "lvMisDatos";
            this.lvMisDatos.Size = new System.Drawing.Size(575, 160);
            this.lvMisDatos.TabIndex = 9;
            this.lvMisDatos.UseCompatibleStateImageBehavior = false;
            this.lvMisDatos.View = System.Windows.Forms.View.Details;
            // 
            // frmMisDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 515);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.btnActualizarClave);
            this.Controls.Add(this.lvMisDatos);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMisDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MisDatos";
            this.Load += new System.EventHandler(this.frmMisDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnActualizarClave;
        private System.Windows.Forms.TextBox txbClave;
        private System.Windows.Forms.ListView lvMisDatos;
    }
}