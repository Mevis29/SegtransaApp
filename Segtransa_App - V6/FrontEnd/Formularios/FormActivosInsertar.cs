using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.DAL;
using Backend.Entities;

namespace FrontEnd
{
    public partial class FrmActivosInsertar : Form
    {
        private IActivosDAL activosDAL = new ActivosDALImpl();
        private IProveedoresDAL proveedoresDAL = new ProveedoresDALImpl();
        private IEstadoActivosDAL estadosDAL = new EstadoActivosDALImpl();
        private ICategoriasDAL categoriasDAL = new CategoriaDALImpl();
        Activos activo;

        public FrmActivosInsertar()
        {
            InitializeComponent();

            CargarCombo();
        }

        public void CargarCombo()
        {
            try
            {


                //cargar Categorias al combo
                var dataSource2 = new List<Categorias>();
                dataSource2 = categoriasDAL.obtenerCategorias();
                this.cmbCategoria.DataSource = null;
                this.cmbCategoria.Items.Clear();
                this.cmbCategoria.DataSource = dataSource2;
                this.cmbCategoria.DisplayMember = "Descripcion";
                this.cmbCategoria.ValueMember = "IdCategoria";
                this.cmbCategoria.Refresh();

                //cargar Proveedor al combo
                var dataSource3 = new List<Proveedores>();
                dataSource3 = proveedoresDAL.obtenerProveedores();
                this.cmbProveedor.DataSource = null;
                this.cmbProveedor.Items.Clear();
                this.cmbProveedor.DataSource = dataSource3;
                this.cmbProveedor.DisplayMember = "NombreProveedor";
                this.cmbProveedor.ValueMember = "IdProveedor";
                this.cmbProveedor.Refresh();

                //cargar Estado delActivo al combo
                var dataSource4 = new List<EstadoActivos>();
                dataSource4 = estadosDAL.obtenerEstadoActivos();
                this.cmbEstado.DataSource = null;
                this.cmbEstado.Items.Clear();
                this.cmbEstado.DataSource = dataSource4;
                this.cmbEstado.DisplayMember = "NombreEstado";
                this.cmbEstado.ValueMember = "IdEstadoActivo";
                this.cmbEstado.Refresh();
                                                          

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (string.IsNullOrEmpty(txtDescripcion.Text) ||
                        string.IsNullOrEmpty(txtGarantia.Text) ||
                       string.IsNullOrEmpty(TXTPRECIO.Text)
                        )
                    {

                        MessageBox.Show("Debe completar toda la informacion");

                        return;

                    }
                    else
                    {
                        Activos activo = new Activos();
                        Categorias categorias = new Categorias();
                        Proveedores proveedores = new Proveedores();
                        EstadoActivos estadoActivos = new EstadoActivos();

                        if ((Categorias)cmbCategoria.SelectedItem != null)

                        {
                            string codAct = cmbCodActivo.Text;
                            categorias = (Categorias)cmbCategoria.SelectedItem;
                            proveedores = (Proveedores)cmbProveedor.SelectedItem;
                            estadoActivos = (EstadoActivos)cmbEstado.SelectedItem;
                            activo.PrecioInicial = Convert.ToDecimal(TXTPRECIO.Text);
                            activo.PrecioActual = Convert.ToDecimal(TXTPRECIO.Text);
                            activo.CodActivo = codAct.ToString();
                            activo.Categoria = categorias.IdCategoria;
                            activo.Descripcion = txtDescripcion.Text;
                            activo.FechaCompra = cmbCalendario.Value;
                            activo.Proveedor = proveedores.IdProveedor;
                            activo.EstadoActivo = estadoActivos.IdEstadoActivo;
                            activo.Garantia = Convert.ToInt32(txtGarantia.Text);


                            activosDAL.agregarActivo(activo);
                            MessageBox.Show("Activo agregado");
                            this.Close();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe completar toda la informacion");
                }

            }


        }





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmActivosInsertar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'segtransaDataSet.sp_mostrarCodActivoDiferentes' Puede moverla o quitarla según sea necesario.
            this.sp_mostrarCodActivoDiferentesTableAdapter.Fill(this.segtransaDataSet.sp_mostrarCodActivoDiferentes);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXTPRECIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmbCodActivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripcion del activo")
            {
                txtDescripcion.Text = "";

                txtDescripcion.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripcion del activo";

                txtDescripcion.ForeColor = Color.Silver;
            }

        }

        private void TXTPRECIO_Enter(object sender, EventArgs e)
        {
            if (TXTPRECIO.Text == "Precio(colones)")
            {
                TXTPRECIO.Text = "";

                TXTPRECIO.ForeColor = Color.Black;
            }

        }

        private void TXTPRECIO_Leave(object sender, EventArgs e)
        {
            if (TXTPRECIO.Text == "")
            {
                TXTPRECIO.Text = "Precio(colones)";

                TXTPRECIO.ForeColor = Color.Silver;
            }

        }

        private void txtGarantia_Enter(object sender, EventArgs e)
        {
            if (txtGarantia.Text == "Garantia(meses)")
            {
                txtGarantia.Text = "";

                txtGarantia.ForeColor = Color.Black;
            }

        }

        private void txtGarantia_Leave(object sender, EventArgs e)
        {
            if (txtGarantia.Text == "")
            {
                txtGarantia.Text = "Garantia(meses)";

                txtGarantia.ForeColor = Color.Silver;
            }


        }

        private void TXTPRECIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCodActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }



        private void cmbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
