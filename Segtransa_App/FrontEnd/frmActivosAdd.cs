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
    public partial class frmActivosAdd : Form
    {
        IActivosDAL activosDAL;
        IProveedoresDAL proveedoresDAL;
        IEstadoActivosDAL estadosDAL;
        Activos activo;

        public frmActivosAdd(Form prevForm)
        {
            previousForm = prevForm;
            activosDAL = new ActivosImplDAL();
            proveedoresDAL = new ProveedoresImplDAL();
            estadosDAL = new EstadoActivosImplDAL();
            activo = new Activos();
            InitializeComponent();
        }

        Form previousForm;

        private void btnBack_click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void cargaCombo()
        {
            cmbBoxPrvdr.DisplayMember = "nombre";
            cmbBoxPrvdr.ValueMember = "idProveedor";
            List<Proveedores> proveedor = proveedoresDAL.GetProveedores();

            cmbBoxStt.DisplayMember = "nombreEstado";
            cmbBoxStt.ValueMember = "idEstadoActivo";
            List<EstadoActivos> estadosActivos = estadosDAL.GetEstadoActivos();

            cmbBoxPrvdr.DataSource = proveedor;
            cmbBoxStt.DataSource = estadosActivos;
        }

        private void btnAddActivo_Click(object sender, EventArgs e)
        {
            try
            {
                activo = new Activos();
                activo.IdActivo = activosDAL.getNextId();
                activo.CodActivo = txtNmbr.Text;
                activo.Descripcion = txtBxDesc.Text;
                activo.PrecioInicial = decimal.Parse(txtPrc.Text);
                activo.FechaCompra = dateCompra.Value.Date;
                activo.Proveedor = (int)cmbBoxPrvdr.SelectedValue;
                activo.EstadoActivo = (int)cmbBoxStt.SelectedValue;
                activosDAL.Add(activo);
                MessageBox.Show("Activo agregado!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex.ToString());
            }
        }

        private void frmActivosAdd_Load(object sender, EventArgs e)
        {
            cargaCombo();
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
