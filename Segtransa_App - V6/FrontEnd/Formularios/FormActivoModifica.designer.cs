namespace FrontEnd
{
    partial class FrmActivosModificar
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
            this.TXTPRECIO_ = new System.Windows.Forms.TextBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.splistarProveedorPorIdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.segtransaDataSetListarProveedorPorId = new FrontEnd.SegtransaDataSetListarProveedorPorId();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.splistarCategoriaPorIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segtransaDataSetCategoriaPorId = new FrontEnd.SegtransaDataSetCategoriaPorId();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.splistarEstadoActivoPorIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segtransaDataSetEstadoActivoPorId = new FrontEnd.SegtransaDataSetEstadoActivoPorId();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbCalendario = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion_ = new System.Windows.Forms.TextBox();
            this.txtGarantia_ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCodActivo = new System.Windows.Forms.ComboBox();
            this.splistarCodActivoPorIdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.segtransaDataSet3 = new FrontEnd.SegtransaDataSet3();
            this.splistarCodActivoPorIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segtransaDataSet2 = new FrontEnd.SegtransaDataSet2();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbIdActivo = new System.Windows.Forms.ComboBox();
            this.activosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segtransaDataSet1 = new FrontEnd.SegtransaDataSet1();
            this.activosTableAdapter = new FrontEnd.SegtransaDataSet1TableAdapters.ActivosTableAdapter();
            this.sp_listarCodActivoPorIdTableAdapter = new FrontEnd.SegtransaDataSet2TableAdapters.sp_listarCodActivoPorIdTableAdapter();
            this.sp_listarCodActivoPorIdTableAdapter1 = new FrontEnd.SegtransaDataSet3TableAdapters.sp_listarCodActivoPorIdTableAdapter();
            this.sp_listarCategoriaPorIdTableAdapter = new FrontEnd.SegtransaDataSetCategoriaPorIdTableAdapters.sp_listarCategoriaPorIdTableAdapter();
            this.sp_listarProveedorPorIdTableAdapter = new FrontEnd.SegtransaDataSet4TableAdapters.sp_listarProveedorPorIdTableAdapter();
            this.sp_listarProveedorPorIdTableAdapter1 = new FrontEnd.SegtransaDataSetListarProveedorPorIdTableAdapters.sp_listarProveedorPorIdTableAdapter();
            this.sp_listarEstadoActivoPorIdTableAdapter = new FrontEnd.SegtransaDataSetEstadoActivoPorIdTableAdapters.sp_listarEstadoActivoPorIdTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splistarProveedorPorIdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSetListarProveedorPorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarCategoriaPorIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSetCategoriaPorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarEstadoActivoPorIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSetEstadoActivoPorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarCodActivoPorIdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarCodActivoPorIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTPRECIO_
            // 
            this.TXTPRECIO_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPRECIO_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TXTPRECIO_.Location = new System.Drawing.Point(563, 255);
            this.TXTPRECIO_.Name = "TXTPRECIO_";
            this.TXTPRECIO_.Size = new System.Drawing.Size(315, 30);
            this.TXTPRECIO_.TabIndex = 15;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DataSource = this.splistarProveedorPorIdBindingSource1;
            this.cmbProveedor.DisplayMember = "resultado";
            this.cmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(563, 303);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(315, 33);
            this.cmbProveedor.TabIndex = 16;
            this.cmbProveedor.ValueMember = "resultado";
            this.cmbProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProveedor_KeyPress);
            // 
            // splistarProveedorPorIdBindingSource1
            // 
            this.splistarProveedorPorIdBindingSource1.DataMember = "sp_listarProveedorPorId";
            this.splistarProveedorPorIdBindingSource1.DataSource = this.segtransaDataSetListarProveedorPorId;
            // 
            // segtransaDataSetListarProveedorPorId
            // 
            this.segtransaDataSetListarProveedorPorId.DataSetName = "SegtransaDataSetListarProveedorPorId";
            this.segtransaDataSetListarProveedorPorId.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(353, 393);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Garantia:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DataSource = this.splistarCategoriaPorIdBindingSource;
            this.cmbCategoria.DisplayMember = "resultado";
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(562, 172);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(316, 33);
            this.cmbCategoria.TabIndex = 13;
            this.cmbCategoria.ValueMember = "resultado";
            this.cmbCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCategoria_KeyPress);
            // 
            // splistarCategoriaPorIdBindingSource
            // 
            this.splistarCategoriaPorIdBindingSource.DataMember = "sp_listarCategoriaPorId";
            this.splistarCategoriaPorIdBindingSource.DataSource = this.segtransaDataSetCategoriaPorId;
            // 
            // segtransaDataSetCategoriaPorId
            // 
            this.segtransaDataSetCategoriaPorId.DataSetName = "SegtransaDataSetCategoriaPorId";
            this.segtransaDataSetCategoriaPorId.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Categoria:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DataSource = this.splistarEstadoActivoPorIdBindingSource;
            this.cmbEstado.DisplayMember = "resultado";
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(563, 343);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(315, 33);
            this.cmbEstado.TabIndex = 17;
            this.cmbEstado.ValueMember = "resultado";
            this.cmbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEstado_KeyPress);
            // 
            // splistarEstadoActivoPorIdBindingSource
            // 
            this.splistarEstadoActivoPorIdBindingSource.DataMember = "sp_listarEstadoActivoPorId";
            this.splistarEstadoActivoPorIdBindingSource.DataSource = this.segtransaDataSetEstadoActivoPorId;
            // 
            // segtransaDataSetEstadoActivoPorId
            // 
            this.segtransaDataSetEstadoActivoPorId.DataSetName = "SegtransaDataSetEstadoActivoPorId";
            this.segtransaDataSetEstadoActivoPorId.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(731, 449);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(607, 449);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Cancelar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbCalendario
            // 
            this.cmbCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalendario.Location = new System.Drawing.Point(562, 94);
            this.cmbCalendario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCalendario.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.cmbCalendario.Name = "cmbCalendario";
            this.cmbCalendario.Size = new System.Drawing.Size(316, 30);
            this.cmbCalendario.TabIndex = 11;
            // 
            // txtDescripcion_
            // 
            this.txtDescripcion_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescripcion_.Location = new System.Drawing.Point(562, 210);
            this.txtDescripcion_.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion_.Name = "txtDescripcion_";
            this.txtDescripcion_.Size = new System.Drawing.Size(316, 30);
            this.txtDescripcion_.TabIndex = 14;
            this.txtDescripcion_.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtGarantia_
            // 
            this.txtGarantia_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGarantia_.Location = new System.Drawing.Point(563, 390);
            this.txtGarantia_.Margin = new System.Windows.Forms.Padding(4);
            this.txtGarantia_.Name = "txtGarantia_";
            this.txtGarantia_.Size = new System.Drawing.Size(315, 30);
            this.txtGarantia_.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Proveedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(351, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha de Compra:";
            // 
            // cmbCodActivo
            // 
            this.cmbCodActivo.DataSource = this.splistarCodActivoPorIdBindingSource1;
            this.cmbCodActivo.DisplayMember = "resultado";
            this.cmbCodActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodActivo.FormattingEnabled = true;
            this.cmbCodActivo.Location = new System.Drawing.Point(562, 132);
            this.cmbCodActivo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCodActivo.Name = "cmbCodActivo";
            this.cmbCodActivo.Size = new System.Drawing.Size(316, 33);
            this.cmbCodActivo.TabIndex = 12;
            this.cmbCodActivo.ValueMember = "resultado";
            this.cmbCodActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCodActivo_KeyPress);
            // 
            // splistarCodActivoPorIdBindingSource1
            // 
            this.splistarCodActivoPorIdBindingSource1.DataMember = "sp_listarCodActivoPorId";
            this.splistarCodActivoPorIdBindingSource1.DataSource = this.segtransaDataSet3;
            // 
            // segtransaDataSet3
            // 
            this.segtransaDataSet3.DataSetName = "SegtransaDataSet3";
            this.segtransaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splistarCodActivoPorIdBindingSource
            // 
            this.splistarCodActivoPorIdBindingSource.DataMember = "sp_listarCodActivoPorId";
            this.splistarCodActivoPorIdBindingSource.DataSource = this.segtransaDataSet2;
            // 
            // segtransaDataSet2
            // 
            this.segtransaDataSet2.DataSetName = "SegtransaDataSet2";
            this.segtransaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(468, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Modificar Activo";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(353, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "CodActivo:";
            // 
            // cmbIdActivo
            // 
            this.cmbIdActivo.DataSource = this.activosBindingSource;
            this.cmbIdActivo.DisplayMember = "IdActivo";
            this.cmbIdActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdActivo.FormattingEnabled = true;
            this.cmbIdActivo.Location = new System.Drawing.Point(562, 55);
            this.cmbIdActivo.Name = "cmbIdActivo";
            this.cmbIdActivo.Size = new System.Drawing.Size(316, 33);
            this.cmbIdActivo.TabIndex = 10;
            this.cmbIdActivo.ValueMember = "IdActivo";
            this.cmbIdActivo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbIdActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbIdActivo_KeyPress);
            // 
            // activosBindingSource
            // 
            this.activosBindingSource.DataMember = "Activos";
            this.activosBindingSource.DataSource = this.segtransaDataSet1;
            // 
            // segtransaDataSet1
            // 
            this.segtransaDataSet1.DataSetName = "SegtransaDataSet1";
            this.segtransaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activosTableAdapter
            // 
            this.activosTableAdapter.ClearBeforeFill = true;
            // 
            // sp_listarCodActivoPorIdTableAdapter
            // 
            this.sp_listarCodActivoPorIdTableAdapter.ClearBeforeFill = true;
            // 
            // sp_listarCodActivoPorIdTableAdapter1
            // 
            this.sp_listarCodActivoPorIdTableAdapter1.ClearBeforeFill = true;
            // 
            // sp_listarCategoriaPorIdTableAdapter
            // 
            this.sp_listarCategoriaPorIdTableAdapter.ClearBeforeFill = true;
            // 
            // sp_listarProveedorPorIdTableAdapter
            // 
            this.sp_listarProveedorPorIdTableAdapter.ClearBeforeFill = true;
            // 
            // sp_listarProveedorPorIdTableAdapter1
            // 
            this.sp_listarProveedorPorIdTableAdapter1.ClearBeforeFill = true;
            // 
            // sp_listarEstadoActivoPorIdTableAdapter
            // 
            this.sp_listarEstadoActivoPorIdTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(351, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Activo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(879, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "colones";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(878, 403);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 44;
            this.label12.Text = "meses";
            // 
            // FrmActivosModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 491);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIdActivo);
            this.Controls.Add(this.TXTPRECIO_);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbCalendario);
            this.Controls.Add(this.txtDescripcion_);
            this.Controls.Add(this.txtGarantia_);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCodActivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmActivosModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Activo";
            this.Load += new System.EventHandler(this.FrmActivosModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splistarProveedorPorIdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSetListarProveedorPorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarCategoriaPorIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSetCategoriaPorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarEstadoActivoPorIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSetEstadoActivoPorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarCodActivoPorIdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarCodActivoPorIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTPRECIO_;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker cmbCalendario;
        private System.Windows.Forms.TextBox txtDescripcion_;
        private System.Windows.Forms.TextBox txtGarantia_;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCodActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbIdActivo;
        private SegtransaDataSet1 segtransaDataSet1;
        private System.Windows.Forms.BindingSource activosBindingSource;
        private SegtransaDataSet1TableAdapters.ActivosTableAdapter activosTableAdapter;
        private System.Windows.Forms.BindingSource splistarCodActivoPorIdBindingSource;
        private SegtransaDataSet2 segtransaDataSet2;
        private SegtransaDataSet2TableAdapters.sp_listarCodActivoPorIdTableAdapter sp_listarCodActivoPorIdTableAdapter;
        private System.Windows.Forms.BindingSource splistarCodActivoPorIdBindingSource1;
        private SegtransaDataSet3 segtransaDataSet3;
        private SegtransaDataSet3TableAdapters.sp_listarCodActivoPorIdTableAdapter sp_listarCodActivoPorIdTableAdapter1;
        private System.Windows.Forms.BindingSource splistarCategoriaPorIdBindingSource;
        private SegtransaDataSetCategoriaPorId segtransaDataSetCategoriaPorId;
        private SegtransaDataSetCategoriaPorIdTableAdapters.sp_listarCategoriaPorIdTableAdapter sp_listarCategoriaPorIdTableAdapter;
        private System.Windows.Forms.BindingSource splistarProveedorPorIdBindingSource1;
        private SegtransaDataSetListarProveedorPorId segtransaDataSetListarProveedorPorId;
        private SegtransaDataSet4TableAdapters.sp_listarProveedorPorIdTableAdapter sp_listarProveedorPorIdTableAdapter;
        private SegtransaDataSetListarProveedorPorIdTableAdapters.sp_listarProveedorPorIdTableAdapter sp_listarProveedorPorIdTableAdapter1;
        private System.Windows.Forms.BindingSource splistarEstadoActivoPorIdBindingSource;
        private SegtransaDataSetEstadoActivoPorId segtransaDataSetEstadoActivoPorId;
        private SegtransaDataSetEstadoActivoPorIdTableAdapters.sp_listarEstadoActivoPorIdTableAdapter sp_listarEstadoActivoPorIdTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
    }
}