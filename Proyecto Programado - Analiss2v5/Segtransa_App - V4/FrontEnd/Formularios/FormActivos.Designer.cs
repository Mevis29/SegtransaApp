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
            this.label1 = new System.Windows.Forms.Label();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarActivoSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaActivos = new System.Windows.Forms.DataGridView();
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
            this.idActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBuscar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrarActivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource2)).BeginInit();
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
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.txtCedula);
            this.grpBuscar.Controls.Add(this.lblCedula);
            this.grpBuscar.Controls.Add(this.button3);
            this.grpBuscar.Controls.Add(this.txtNombre);
            this.grpBuscar.Controls.Add(this.lblNombre);
            this.grpBuscar.Controls.Add(this.txtCorreo);
            this.grpBuscar.Controls.Add(this.lblCorreo);
            this.grpBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBuscar.Location = new System.Drawing.Point(26, 94);
            this.grpBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.grpBuscar.Size = new System.Drawing.Size(1071, 84);
            this.grpBuscar.TabIndex = 17;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar Por:";
            this.grpBuscar.Enter += new System.EventHandler(this.grpBuscar_Enter);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(122, 40);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(140, 28);
            this.txtCedula.TabIndex = 1;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(10, 40);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(76, 24);
            this.lblCedula.TabIndex = 6;
            this.lblCedula.Text = "IdActivo";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(951, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(370, 40);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 28);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(270, 40);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(711, 37);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(210, 28);
            this.txtCorreo.TabIndex = 3;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(600, 40);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(103, 24);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Proveedor:";
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
            // tablaActivos
            // 
            this.tablaActivos.AllowUserToOrderColumns = true;
            this.tablaActivos.AutoGenerateColumns = false;
            this.tablaActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.tablaActivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaActivos.RowHeadersVisible = false;
            this.tablaActivos.RowTemplate.Height = 24;
            this.tablaActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaActivos.Size = new System.Drawing.Size(1071, 275);
            this.tablaActivos.TabIndex = 19;
            this.tablaActivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.obtenerIDTabla);
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
            // idActivoDataGridViewTextBoxColumn
            // 
            this.idActivoDataGridViewTextBoxColumn.DataPropertyName = "IdActivo";
            this.idActivoDataGridViewTextBoxColumn.FillWeight = 70F;
            this.idActivoDataGridViewTextBoxColumn.HeaderText = "IdActivo";
            this.idActivoDataGridViewTextBoxColumn.Name = "idActivoDataGridViewTextBoxColumn";
            this.idActivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codActivoDataGridViewTextBoxColumn
            // 
            this.codActivoDataGridViewTextBoxColumn.DataPropertyName = "CodActivo";
            this.codActivoDataGridViewTextBoxColumn.HeaderText = "CodActivo";
            this.codActivoDataGridViewTextBoxColumn.Name = "codActivoDataGridViewTextBoxColumn";
            this.codActivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.FillWeight = 200F;
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioInicialDataGridViewTextBoxColumn
            // 
            this.precioInicialDataGridViewTextBoxColumn.DataPropertyName = "PrecioInicial";
            this.precioInicialDataGridViewTextBoxColumn.HeaderText = "PrecioInicial";
            this.precioInicialDataGridViewTextBoxColumn.Name = "precioInicialDataGridViewTextBoxColumn";
            this.precioInicialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioActualDataGridViewTextBoxColumn
            // 
            this.precioActualDataGridViewTextBoxColumn.DataPropertyName = "PrecioActual";
            this.precioActualDataGridViewTextBoxColumn.HeaderText = "PrecioActual";
            this.precioActualDataGridViewTextBoxColumn.Name = "precioActualDataGridViewTextBoxColumn";
            this.precioActualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            this.fechaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // garantiaDataGridViewTextBoxColumn
            // 
            this.garantiaDataGridViewTextBoxColumn.DataPropertyName = "Garantia";
            this.garantiaDataGridViewTextBoxColumn.HeaderText = "Garantia";
            this.garantiaDataGridViewTextBoxColumn.Name = "garantiaDataGridViewTextBoxColumn";
            this.garantiaDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrarActivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarActivoSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarVentanaToolStripMenuItem;
        private System.Windows.Forms.DataGridView tablaActivos;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantiaDataGridViewTextBoxColumn;
    }
}