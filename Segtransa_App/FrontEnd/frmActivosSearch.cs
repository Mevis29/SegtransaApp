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
    public partial class frmActivosSearch : Form
    {
        IActivosDAL activosDAL = new ActivosImplDAL();
        IProveedoresDAL proveedoresDAL = new ProveedoresImplDAL();
        IEstadoActivosDAL estadoActivosDAL = new EstadoActivosImplDAL();

        public frmActivosSearch(Form prvForm)
        {
            InitializeComponent();
            previousForm = prvForm;
        }
        Form previousForm;

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            populateFields(activosDAL.GetActivo(Int32.Parse(txtIdActivo.Text)));
        }

        private void populateFields(Activos activo)
        {
            try
            {
                int valProveedor = activo.idProveedor.Value;
                lblValNombre.Text = activo.nombreActivo;
                lblValPrcIni.Text = activo.precioInicial.ToString();
                lblValProveedor.Text = proveedoresDAL.GetProveedor(valProveedor).nombre;
                lblValDesc.Text = activo.descripcion;
                valProveedor = estadoActivosDAL.GetEstadoActivo(activo.idEstadoActivo.Value).idEstadoActivo;
                lblValStt.Text = estadoActivosDAL.GetEstadoActivo(valProveedor).nombreEstado;
                //activo.idProveedor int? to int, look for method to parse
            } catch (System.InvalidOperationException ) {
                MessageBox.Show("No se ha encontrado un activo con el identificador ingresado.");
            } catch (ArgumentNullException)
            {
                MessageBox.Show("Por favor ingrese el Id del activo");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            // Let the default behavior to happen.
            base.OnClosing(e);
            // Do not allow cancellation of the close operation.
            e.Cancel = false;
            //frmUsuariosAgrega frmUsuarios = new frmUsuariosAgrega();
            previousForm.Show();
        }
    }
}
