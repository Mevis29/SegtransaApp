namespace FrontEnd
{
    partial class frmActivosSearch
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdActivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblStt = new System.Windows.Forms.Label();
            this.lblPrcIni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblValProveedor = new System.Windows.Forms.Label();
            this.lblValNombre = new System.Windows.Forms.Label();
            this.lblValPrcIni = new System.Windows.Forms.Label();
            this.lblValDesc = new System.Windows.Forms.Label();
            this.lblValStt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(572, 448);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(102, 34);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "Cerrar";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(470, 150);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 29);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdActivo
            // 
            this.txtIdActivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdActivo.Location = new System.Drawing.Point(272, 155);
            this.txtIdActivo.Name = "txtIdActivo";
            this.txtIdActivo.Size = new System.Drawing.Size(97, 23);
            this.txtIdActivo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(21, 101);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 23);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Buscar Activo";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(129, 338);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(104, 19);
            this.lblDesc.TabIndex = 12;
            this.lblDesc.Text = "Descripcion:";
            // 
            // lblStt
            // 
            this.lblStt.AutoSize = true;
            this.lblStt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStt.ForeColor = System.Drawing.Color.White;
            this.lblStt.Location = new System.Drawing.Point(129, 381);
            this.lblStt.Name = "lblStt";
            this.lblStt.Size = new System.Drawing.Size(63, 19);
            this.lblStt.TabIndex = 11;
            this.lblStt.Text = "Estado:";
            // 
            // lblPrcIni
            // 
            this.lblPrcIni.AutoSize = true;
            this.lblPrcIni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrcIni.ForeColor = System.Drawing.Color.White;
            this.lblPrcIni.Location = new System.Drawing.Point(129, 296);
            this.lblPrcIni.Name = "lblPrcIni";
            this.lblPrcIni.Size = new System.Drawing.Size(112, 19);
            this.lblPrcIni.TabIndex = 10;
            this.lblPrcIni.Text = "Precio Inicial:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(129, 253);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 19);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.White;
            this.lblProveedor.Location = new System.Drawing.Point(129, 212);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(92, 19);
            this.lblProveedor.TabIndex = 8;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // lblValProveedor
            // 
            this.lblValProveedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblValProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValProveedor.Location = new System.Drawing.Point(269, 204);
            this.lblValProveedor.Name = "lblValProveedor";
            this.lblValProveedor.Size = new System.Drawing.Size(299, 27);
            this.lblValProveedor.TabIndex = 13;
            // 
            // lblValNombre
            // 
            this.lblValNombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblValNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValNombre.Location = new System.Drawing.Point(269, 249);
            this.lblValNombre.Name = "lblValNombre";
            this.lblValNombre.Size = new System.Drawing.Size(299, 23);
            this.lblValNombre.TabIndex = 14;
            // 
            // lblValPrcIni
            // 
            this.lblValPrcIni.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblValPrcIni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValPrcIni.Location = new System.Drawing.Point(269, 289);
            this.lblValPrcIni.Name = "lblValPrcIni";
            this.lblValPrcIni.Size = new System.Drawing.Size(299, 26);
            this.lblValPrcIni.TabIndex = 15;
            // 
            // lblValDesc
            // 
            this.lblValDesc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblValDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValDesc.Location = new System.Drawing.Point(269, 332);
            this.lblValDesc.Name = "lblValDesc";
            this.lblValDesc.Size = new System.Drawing.Size(299, 25);
            this.lblValDesc.TabIndex = 16;
            // 
            // lblValStt
            // 
            this.lblValStt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblValStt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValStt.Location = new System.Drawing.Point(269, 378);
            this.lblValStt.Name = "lblValStt";
            this.lblValStt.Size = new System.Drawing.Size(299, 22);
            this.lblValStt.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FrontEnd.Properties.Resources.logo3_01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(16, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 52);
            this.panel1.TabIndex = 18;
            // 
            // frmActivosSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(711, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblValStt);
            this.Controls.Add(this.lblValDesc);
            this.Controls.Add(this.lblValPrcIni);
            this.Controls.Add(this.lblValNombre);
            this.Controls.Add(this.lblValProveedor);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblStt);
            this.Controls.Add(this.lblPrcIni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdActivo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAtras);
            this.Name = "frmActivosSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Activo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdActivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblStt;
        private System.Windows.Forms.Label lblPrcIni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblValProveedor;
        private System.Windows.Forms.Label lblValNombre;
        private System.Windows.Forms.Label lblValPrcIni;
        private System.Windows.Forms.Label lblValDesc;
        private System.Windows.Forms.Label lblValStt;
        private System.Windows.Forms.Panel panel1;
    }
}