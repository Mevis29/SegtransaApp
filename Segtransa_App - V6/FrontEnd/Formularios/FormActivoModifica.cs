using Backend.DAL;
using Backend.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class FrmActivosModificar : Form
    {

        private IActivosDAL activosDAL = new ActivosDALImpl();
        private IProveedoresDAL proveedoresDAL = new ProveedoresDALImpl();
        private IEstadoActivosDAL estadosDAL = new EstadoActivosDALImpl();
        private ICategoriasDAL categoriasDAL = new CategoriaDALImpl();
        BDContext context;
        Activos activo;


        public FrmActivosModificar()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cmbIdActivo.Text;
            this.sp_listarCodActivoPorIdTableAdapter1.Fill(segtransaDataSet3.sp_listarCodActivoPorId, id);
            this.sp_listarCategoriaPorIdTableAdapter.Fill(segtransaDataSetCategoriaPorId.sp_listarCategoriaPorId, id);
            this.sp_listarProveedorPorIdTableAdapter1.Fill(segtransaDataSetListarProveedorPorId.sp_listarProveedorPorId, id);
            this.sp_listarEstadoActivoPorIdTableAdapter.Fill(segtransaDataSetEstadoActivoPorId.sp_listarEstadoActivoPorId, id);

            int id2 = Convert.ToInt32(id);
            activo = activosDAL.mostrarActivo(id2);
            txtDescripcion_.Text = activo.Descripcion;
            txtGarantia_.Text = activo.Garantia.ToString();
            TXTPRECIO_.Text = activo.PrecioInicial.ToString();
            cmbCalendario.Text = activo.FechaCompra.ToString();

        }



        private void FrmActivosModificar_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'segtransaDataSet1.Activos' Puede moverla o quitarla según sea necesario.
            this.activosTableAdapter.Fill(this.segtransaDataSet1.Activos);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDescripcion_.Text) ||
                    string.IsNullOrEmpty(TXTPRECIO_.Text) ||
                    string.IsNullOrEmpty(txtGarantia_.Text) ||
                    string.IsNullOrEmpty(cmbCodActivo.Text) ||
                    string.IsNullOrEmpty(cmbCategoria.Text) ||
                    string.IsNullOrEmpty(cmbProveedor.Text) ||
                    string.IsNullOrEmpty(cmbEstado.Text))
                {
                    MessageBox.Show("Debes ingresar todos los campos del activo para actualizarlo");

                    return;
                }
                else
                {
                    Activos activos = new Activos();
                    Categorias categorias = new Categorias();
                    Proveedores proveedores = new Proveedores();
                    EstadoActivos estadoActivos = new EstadoActivos();


                    string nombrecategoria = cmbCategoria.SelectedValue.ToString();
                    string nombreProveedor = cmbProveedor.SelectedValue.ToString();
                    string nombreEstado = cmbEstado.SelectedValue.ToString();



                    int? idCategoria;
                    int? idProveedor;
                    int? idEstado;

                    using (context = new BDContext())
                    {
                        idCategoria = Convert.ToInt32(context.sp_IdCategoriaporNombreCategoria(nombrecategoria).FirstOrDefault() ?? -1);
                        idProveedor = Convert.ToInt32(context.sp_IdProveedorporNombreProveedor(nombreProveedor).FirstOrDefault() ?? -1);
                        idEstado = Convert.ToInt32(context.sp_IdEstadoActivoEstadoActivo(nombreEstado).FirstOrDefault() ?? -1);

                    }


                    activos.CodActivo = cmbCodActivo.SelectedValue.ToString();
                    activos.IdActivo = Convert.ToInt32(cmbIdActivo.SelectedValue);
                    activos.PrecioInicial = Convert.ToDecimal(TXTPRECIO_.Text);
                    activos.PrecioActual = Convert.ToDecimal(TXTPRECIO_.Text);
                    activos.Categoria = idCategoria;
                    activos.Descripcion = txtDescripcion_.Text;
                    activos.FechaCompra = cmbCalendario.Value;
                    activos.Proveedor = idProveedor;
                    activos.EstadoActivo = idEstado;
                    activos.Garantia = Convert.ToInt32(txtGarantia_.Text);

                    activosDAL.actualizarActivo(activos);
                    MessageBox.Show("Activo modificado");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                throw;
            }

        }

        private void cmbIdActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbCodActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }



}

