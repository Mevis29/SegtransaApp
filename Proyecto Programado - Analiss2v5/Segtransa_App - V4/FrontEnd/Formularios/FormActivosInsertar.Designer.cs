namespace FrontEnd
{
    partial class FrmActivosInsertar
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCodActivo = new System.Windows.Forms.ComboBox();
            this.spmostrarCodActivoDiferentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segtransaDataSet = new FrontEnd.SegtransaDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbCalendario = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.TXTPRECIO = new System.Windows.Forms.TextBox();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.sp_mostrarCodActivoDiferentesTableAdapter = new FrontEnd.SegtransaDataSetTableAdapters.sp_mostrarCodActivoDiferentesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrarCodActivoDiferentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CodActivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(530, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agregar Activo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbCodActivo
            // 
            this.cmbCodActivo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.spmostrarCodActivoDiferentesBindingSource, "codActivo", true));
            this.cmbCodActivo.DataSource = this.spmostrarCodActivoDiferentesBindingSource;
            this.cmbCodActivo.DisplayMember = "codActivo";
            this.cmbCodActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodActivo.FormattingEnabled = true;
            this.cmbCodActivo.Location = new System.Drawing.Point(530, 129);
            this.cmbCodActivo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCodActivo.Name = "cmbCodActivo";
            this.cmbCodActivo.Size = new System.Drawing.Size(316, 33);
            this.cmbCodActivo.TabIndex = 4;
            this.cmbCodActivo.ValueMember = "codActivo";
            this.cmbCodActivo.SelectedIndexChanged += new System.EventHandler(this.cmbCodActivo_SelectedIndexChanged);
            // 
            // spmostrarCodActivoDiferentesBindingSource
            // 
            this.spmostrarCodActivoDiferentesBindingSource.DataMember = "sp_mostrarCodActivoDiferentes";
            this.spmostrarCodActivoDiferentesBindingSource.DataSource = this.segtransaDataSet;
            // 
            // segtransaDataSet
            // 
            this.segtransaDataSet.DataSetName = "SegtransaDataSet";
            this.segtransaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(319, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de Compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(321, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Proveedor:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDescripcion.Location = new System.Drawing.Point(530, 207);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(316, 30);
            this.txtDescripcion.TabIndex = 11;
            this.txtDescripcion.Text = "Descripcion del activo";
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // cmbCalendario
            // 
            this.cmbCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalendario.Location = new System.Drawing.Point(530, 91);
            this.cmbCalendario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCalendario.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.cmbCalendario.Name = "cmbCalendario";
            this.cmbCalendario.Size = new System.Drawing.Size(316, 30);
            this.cmbCalendario.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(552, 450);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Cancelar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 450);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(531, 340);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(315, 33);
            this.cmbEstado.TabIndex = 15;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(530, 169);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(316, 33);
            this.cmbCategoria.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(322, 169);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Categoria:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(321, 390);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Garantia:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(531, 300);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(315, 33);
            this.cmbProveedor.TabIndex = 20;
            // 
            // TXTPRECIO
            // 
            this.TXTPRECIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPRECIO.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXTPRECIO.Location = new System.Drawing.Point(531, 252);
            this.TXTPRECIO.Name = "TXTPRECIO";
            this.TXTPRECIO.Size = new System.Drawing.Size(315, 30);
            this.TXTPRECIO.TabIndex = 21;
            this.TXTPRECIO.Text = "Precio(colones)";
            this.TXTPRECIO.TextChanged += new System.EventHandler(this.TXTPRECIO_TextChanged);
            this.TXTPRECIO.Enter += new System.EventHandler(this.TXTPRECIO_Enter);
            this.TXTPRECIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTPRECIO_KeyPress);
            this.TXTPRECIO.Leave += new System.EventHandler(this.TXTPRECIO_Leave);
            // 
            // txtGarantia
            // 
            this.txtGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGarantia.Location = new System.Drawing.Point(531, 387);
            this.txtGarantia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(315, 30);
            this.txtGarantia.TabIndex = 8;
            this.txtGarantia.Text = "Garantia(meses)";
            this.txtGarantia.Enter += new System.EventHandler(this.txtGarantia_Enter);
            this.txtGarantia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGarantia_KeyPress);
            this.txtGarantia.Leave += new System.EventHandler(this.txtGarantia_Leave);
            // 
            // sp_mostrarCodActivoDiferentesTableAdapter
            // 
            this.sp_mostrarCodActivoDiferentesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmActivosInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 491);
            this.ControlBox = false;
            this.Controls.Add(this.TXTPRECIO);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbCalendario);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCodActivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmActivosInsertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Activos";
            this.Load += new System.EventHandler(this.FrmActivosInsertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spmostrarCodActivoDiferentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCodActivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker cmbCalendario;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.TextBox TXTPRECIO;
        private System.Windows.Forms.TextBox txtGarantia;
        private SegtransaDataSet segtransaDataSet;
        private System.Windows.Forms.BindingSource spmostrarCodActivoDiferentesBindingSource;
        private SegtransaDataSetTableAdapters.sp_mostrarCodActivoDiferentesTableAdapter sp_mostrarCodActivoDiferentesTableAdapter;
    }
}