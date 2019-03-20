namespace FrontEnd
{
    partial class frmActivosAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxPrvdr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxDesc = new System.Windows.Forms.TextBox();
            this.txtPrc = new System.Windows.Forms.TextBox();
            this.txtNmbr = new System.Windows.Forms.TextBox();
            this.dateCompra = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbBoxStt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agregar Activo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio Inicial:";
            // 
            // cmbBoxPrvdr
            // 
            this.cmbBoxPrvdr.FormattingEnabled = true;
            this.cmbBoxPrvdr.Location = new System.Drawing.Point(122, 125);
            this.cmbBoxPrvdr.Name = "cmbBoxPrvdr";
            this.cmbBoxPrvdr.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxPrvdr.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de Compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descripcion:";
            // 
            // txtBxDesc
            // 
            this.txtBxDesc.Location = new System.Drawing.Point(122, 234);
            this.txtBxDesc.Name = "txtBxDesc";
            this.txtBxDesc.Size = new System.Drawing.Size(121, 20);
            this.txtBxDesc.TabIndex = 8;
            // 
            // txtPrc
            // 
            this.txtPrc.Location = new System.Drawing.Point(122, 199);
            this.txtPrc.Name = "txtPrc";
            this.txtPrc.Size = new System.Drawing.Size(121, 20);
            this.txtPrc.TabIndex = 10;
            // 
            // txtNmbr
            // 
            this.txtNmbr.Location = new System.Drawing.Point(122, 161);
            this.txtNmbr.Name = "txtNmbr";
            this.txtNmbr.Size = new System.Drawing.Size(121, 20);
            this.txtNmbr.TabIndex = 11;
            // 
            // dateCompra
            // 
            this.dateCompra.Location = new System.Drawing.Point(33, 85);
            this.dateCompra.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateCompra.Name = "dateCompra";
            this.dateCompra.Size = new System.Drawing.Size(200, 20);
            this.dateCompra.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(168, 320);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Cancelar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAddActivo_Click);
            // 
            // cmbBoxStt
            // 
            this.cmbBoxStt.FormattingEnabled = true;
            this.cmbBoxStt.Location = new System.Drawing.Point(122, 274);
            this.cmbBoxStt.Name = "cmbBoxStt";
            this.cmbBoxStt.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxStt.TabIndex = 15;
            // 
            // frmActivosAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 515);
            this.Controls.Add(this.cmbBoxStt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dateCompra);
            this.Controls.Add(this.txtNmbr);
            this.Controls.Add(this.txtPrc);
            this.Controls.Add(this.txtBxDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBoxPrvdr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmActivosAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddActivo";
            this.Load += new System.EventHandler(this.frmActivosAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoxPrvdr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBxDesc;
        private System.Windows.Forms.TextBox txtPrc;
        private System.Windows.Forms.TextBox txtNmbr;
        private System.Windows.Forms.DateTimePicker dateCompra;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbBoxStt;
    }
}