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
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(167, 330);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 28);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "Cerrar";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(268, 62);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdActivo
            // 
            this.txtIdActivo.Location = new System.Drawing.Point(127, 64);
            this.txtIdActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdActivo.Name = "txtIdActivo";
            this.txtIdActivo.Size = new System.Drawing.Size(115, 22);
            this.txtIdActivo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(121, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 29);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Buscar Activo";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(48, 242);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(86, 17);
            this.lblDesc.TabIndex = 12;
            this.lblDesc.Text = "Descripcion:";
            // 
            // lblStt
            // 
            this.lblStt.AutoSize = true;
            this.lblStt.Location = new System.Drawing.Point(48, 288);
            this.lblStt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStt.Name = "lblStt";
            this.lblStt.Size = new System.Drawing.Size(56, 17);
            this.lblStt.TabIndex = 11;
            this.lblStt.Text = "Estado:";
            // 
            // lblPrcIni
            // 
            this.lblPrcIni.AutoSize = true;
            this.lblPrcIni.Location = new System.Drawing.Point(48, 201);
            this.lblPrcIni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrcIni.Name = "lblPrcIni";
            this.lblPrcIni.Size = new System.Drawing.Size(91, 17);
            this.lblPrcIni.TabIndex = 10;
            this.lblPrcIni.Text = "Precio Inicial:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 159);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(48, 118);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(78, 17);
            this.lblProveedor.TabIndex = 8;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // lblValProveedor
            // 
            this.lblValProveedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblValProveedor.Location = new System.Drawing.Point(180, 113);
            this.lblValProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValProveedor.Name = "lblValProveedor";
            this.lblValProveedor.Size = new System.Drawing.Size(133, 26);
            this.lblValProveedor.TabIndex = 13;
            // 
            // lblValNombre
            // 
            this.lblValNombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblValNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValNombre.Location = new System.Drawing.Point(180, 156);
            this.lblValNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValNombre.Name = "lblValNombre";
            this.lblValNombre.Size = new System.Drawing.Size(133, 28);
            this.lblValNombre.TabIndex = 14;
            // 
            // lblValPrcIni
            // 
            this.lblValPrcIni.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblValPrcIni.Location = new System.Drawing.Point(180, 201);
            this.lblValPrcIni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValPrcIni.Name = "lblValPrcIni";
            this.lblValPrcIni.Size = new System.Drawing.Size(133, 27);
            this.lblValPrcIni.TabIndex = 15;
            // 
            // lblValDesc
            // 
            this.lblValDesc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblValDesc.Location = new System.Drawing.Point(180, 242);
            this.lblValDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValDesc.Name = "lblValDesc";
            this.lblValDesc.Size = new System.Drawing.Size(133, 27);
            this.lblValDesc.TabIndex = 16;
            // 
            // lblValStt
            // 
            this.lblValStt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblValStt.Location = new System.Drawing.Point(180, 284);
            this.lblValStt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValStt.Name = "lblValStt";
            this.lblValStt.Size = new System.Drawing.Size(133, 27);
            this.lblValStt.TabIndex = 17;
            // 
            // frmActivosSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 393);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmActivosSearch";
            this.Text = "frmBuscarActivo";
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
    }
}