using Backend.DAL;

namespace FrontEnd
{
    partial class frmActivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarActivoSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioActivosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioActivosDataSet = new FrontEnd.InventarioActivosDataSet();
            this.spBuscarActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BuscarActivosTableAdapter = new FrontEnd.InventarioActivosDataSetTableAdapters.sp_BuscarActivosTableAdapter();
            this.activosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activosTableAdapter = new FrontEnd.InventarioActivosDataSetTableAdapters.ActivosTableAdapter();
            this.activosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioActivosDataSet1 = new FrontEnd.InventarioActivosDataSet1();
            this.spmostrarActivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_mostrarActivoTableAdapter = new FrontEnd.InventarioActivosDataSet1TableAdapters.sp_mostrarActivoTableAdapter();
            this.activosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.garantiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaActivos = new System.Windows.Forms.DataGridView();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrarActivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaActivos)).BeginInit();
            this.grpBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Activos";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtBusqueda.Location = new System.Drawing.Point(8, 35);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(355, 30);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.cerrarVentanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarActivoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarActivoSeleccionadoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // agregarActivoToolStripMenuItem
            // 
            this.agregarActivoToolStripMenuItem.Name = "agregarActivoToolStripMenuItem";
            this.agregarActivoToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.agregarActivoToolStripMenuItem.Text = "Agregar Nuevo Activo";
            this.agregarActivoToolStripMenuItem.Click += new System.EventHandler(this.agregarActivoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.modificarToolStripMenuItem.Text = "Modificar Activo Seleccionado";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarActivoSeleccionadoToolStripMenuItem
            // 
            this.eliminarActivoSeleccionadoToolStripMenuItem.Name = "eliminarActivoSeleccionadoToolStripMenuItem";
            this.eliminarActivoSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.eliminarActivoSeleccionadoToolStripMenuItem.Text = "Eliminar Activo Seleccionado";
            this.eliminarActivoSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.eliminarActivoSeleccionadoToolStripMenuItem_Click);
            // 
            // cerrarVentanaToolStripMenuItem
            // 
            this.cerrarVentanaToolStripMenuItem.Name = "cerrarVentanaToolStripMenuItem";
            this.cerrarVentanaToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.cerrarVentanaToolStripMenuItem.Text = "Cerrar Ventana";
            this.cerrarVentanaToolStripMenuItem.Click += new System.EventHandler(this.cerrarVentanaToolStripMenuItem_Click);
            // 
            // activosBindingSource3
            // 
            this.activosBindingSource3.DataMember = "Activos";
            this.activosBindingSource3.DataSource = this.inventarioActivosDataSetBindingSource;
            // 
            // inventarioActivosDataSetBindingSource
            // 
            this.inventarioActivosDataSetBindingSource.DataSource = this.inventarioActivosDataSet;
            this.inventarioActivosDataSetBindingSource.Position = 0;
            // 
            // inventarioActivosDataSet
            // 
            this.inventarioActivosDataSet.DataSetName = "InventarioActivosDataSet";
            this.inventarioActivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spBuscarActivosBindingSource
            // 
            this.spBuscarActivosBindingSource.DataMember = "sp_BuscarActivos";
            this.spBuscarActivosBindingSource.DataSource = this.inventarioActivosDataSetBindingSource;
            // 
            // sp_BuscarActivosTableAdapter
            // 
            this.sp_BuscarActivosTableAdapter.ClearBeforeFill = true;
            // 
            // activosBindingSource
            // 
            this.activosBindingSource.DataMember = "Activos";
            this.activosBindingSource.DataSource = this.inventarioActivosDataSetBindingSource;
            // 
            // activosTableAdapter
            // 
            this.activosTableAdapter.ClearBeforeFill = true;
            // 
            // activosBindingSource1
            // 
            this.activosBindingSource1.DataMember = "Activos";
            this.activosBindingSource1.DataSource = this.inventarioActivosDataSetBindingSource;
            // 
            // inventarioActivosDataSet1
            // 
            this.inventarioActivosDataSet1.DataSetName = "InventarioActivosDataSet1";
            this.inventarioActivosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spmostrarActivoBindingSource
            // 
            this.spmostrarActivoBindingSource.DataMember = "sp_mostrarActivo";
            this.spmostrarActivoBindingSource.DataSource = this.inventarioActivosDataSet1;
            // 
            // sp_mostrarActivoTableAdapter
            // 
            this.sp_mostrarActivoTableAdapter.ClearBeforeFill = true;
            // 
            // activosBindingSource2
            // 
            this.activosBindingSource2.DataMember = "Activos";
            this.activosBindingSource2.DataSource = this.inventarioActivosDataSetBindingSource;
            // 
            // garantiaDataGridViewTextBoxColumn
            // 
            this.garantiaDataGridViewTextBoxColumn.DataPropertyName = "Garantia";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.garantiaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.garantiaDataGridViewTextBoxColumn.HeaderText = "Garantia";
            this.garantiaDataGridViewTextBoxColumn.Name = "garantiaDataGridViewTextBoxColumn";
            this.garantiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.garantiaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.garantiaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "FechaCompra";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaCompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            this.fechaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCompraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechaCompraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // precioActualDataGridViewTextBoxColumn
            // 
            this.precioActualDataGridViewTextBoxColumn.DataPropertyName = "PrecioActual";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.precioActualDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle23;
            this.precioActualDataGridViewTextBoxColumn.HeaderText = "PrecioActual";
            this.precioActualDataGridViewTextBoxColumn.Name = "precioActualDataGridViewTextBoxColumn";
            this.precioActualDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioActualDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioActualDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // precioInicialDataGridViewTextBoxColumn
            // 
            this.precioInicialDataGridViewTextBoxColumn.DataPropertyName = "PrecioInicial";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.precioInicialDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.precioInicialDataGridViewTextBoxColumn.HeaderText = "PrecioInicial";
            this.precioInicialDataGridViewTextBoxColumn.Name = "precioInicialDataGridViewTextBoxColumn";
            this.precioInicialDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioInicialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioInicialDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.descripcionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.descripcionDataGridViewTextBoxColumn.FillWeight = 200F;
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descripcionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // codActivoDataGridViewTextBoxColumn
            // 
            this.codActivoDataGridViewTextBoxColumn.DataPropertyName = "CodActivo";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codActivoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle26;
            this.codActivoDataGridViewTextBoxColumn.HeaderText = "CodActivo";
            this.codActivoDataGridViewTextBoxColumn.Name = "codActivoDataGridViewTextBoxColumn";
            this.codActivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codActivoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codActivoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idActivoDataGridViewTextBoxColumn
            // 
            this.idActivoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idActivoDataGridViewTextBoxColumn.DataPropertyName = "IdActivo";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idActivoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle27;
            this.idActivoDataGridViewTextBoxColumn.FillWeight = 70F;
            this.idActivoDataGridViewTextBoxColumn.HeaderText = "IdActivo";
            this.idActivoDataGridViewTextBoxColumn.Name = "idActivoDataGridViewTextBoxColumn";
            this.idActivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idActivoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idActivoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tablaActivos
            // 
            this.tablaActivos.AllowUserToAddRows = false;
            this.tablaActivos.AllowUserToDeleteRows = false;
            this.tablaActivos.AllowUserToResizeColumns = false;
            this.tablaActivos.AllowUserToResizeRows = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaActivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.tablaActivos.AutoGenerateColumns = false;
            this.tablaActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.tablaActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActivoDataGridViewTextBoxColumn,
            this.codActivoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioInicialDataGridViewTextBoxColumn,
            this.precioActualDataGridViewTextBoxColumn,
            this.fechaCompraDataGridViewTextBoxColumn,
            this.garantiaDataGridViewTextBoxColumn});
            this.tablaActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaActivos.DataSource = this.activosBindingSource3;
            this.tablaActivos.EnableHeadersVisualStyles = false;
            this.tablaActivos.Location = new System.Drawing.Point(26, 202);
            this.tablaActivos.Name = "tablaActivos";
            this.tablaActivos.ReadOnly = true;
            this.tablaActivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaActivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.tablaActivos.RowHeadersVisible = false;
            this.tablaActivos.RowTemplate.Height = 24;
            this.tablaActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaActivos.Size = new System.Drawing.Size(1071, 275);
            this.tablaActivos.TabIndex = 19;
            this.tablaActivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.obtenerIDTabla);
            this.tablaActivos.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.tablaActivos_ColumnAdded);
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.txtBusqueda);
            this.grpBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBuscar.Location = new System.Drawing.Point(26, 111);
            this.grpBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.grpBuscar.Size = new System.Drawing.Size(386, 84);
            this.grpBuscar.TabIndex = 17;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar:";
            this.grpBuscar.Enter += new System.EventHandler(this.grpBuscar_Enter);
            // 
            // frmActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 538);
            this.Controls.Add(this.tablaActivos);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Activos";
            this.Load += new System.EventHandler(this.frmActivos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrarActivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaActivos)).EndInit();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarActivoSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarVentanaToolStripMenuItem;
        private System.Windows.Forms.BindingSource inventarioActivosDataSetBindingSource;
        private InventarioActivosDataSet inventarioActivosDataSet;
        private System.Windows.Forms.BindingSource spBuscarActivosBindingSource;
        private InventarioActivosDataSetTableAdapters.sp_BuscarActivosTableAdapter sp_BuscarActivosTableAdapter;
        private System.Windows.Forms.BindingSource activosBindingSource;
        private InventarioActivosDataSetTableAdapters.ActivosTableAdapter activosTableAdapter;
        private System.Windows.Forms.BindingSource activosBindingSource1;
        private InventarioActivosDataSet1 inventarioActivosDataSet1;
        private System.Windows.Forms.BindingSource spmostrarActivoBindingSource;
        private InventarioActivosDataSet1TableAdapters.sp_mostrarActivoTableAdapter sp_mostrarActivoTableAdapter;
        private System.Windows.Forms.BindingSource activosBindingSource3;
        private System.Windows.Forms.BindingSource activosBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView tablaActivos;
        private System.Windows.Forms.GroupBox grpBuscar;
    }
}