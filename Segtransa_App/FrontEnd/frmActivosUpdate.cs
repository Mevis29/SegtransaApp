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
    public partial class frmActivosUpdate : Form
    {
        Form previousForm;
        IActivosDAL activosDAL = new ActivosImplDAL();
        IProveedoresDAL proveedores = new ProveedoresImplDAL();
        IEstadoActivosDAL estadoDAL = new EstadoActivosImplDAL();
        Activos activo = new Activos();

        public frmActivosUpdate(frmActivos prevFrm, Activos referenciaActivo)
        {
            InitializeComponent();
            previousForm = prevFrm;
            activo = referenciaActivo;
            cmbBoxPrvdr.DisplayMember = "nombre";
            cmbBoxPrvdr.ValueMember = "idProveedor";
            cmbBoxPrvdr.SelectedValue = activo.Proveedor;
            cmbBoxPrvdr.DataSource = proveedores.GetProveedores();
            cmbBoxStt.DisplayMember = "nombreEstado";
            cmbBoxStt.ValueMember = "idEstadoActivo";
            cmbBoxStt.SelectedValue = activo.EstadoActivo;
            cmbBoxStt.DataSource = estadoDAL.GetEstadoActivos();

            activo = referenciaActivo;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                activo.CodActivo = txtNombre.Text;
                activo.Descripcion = txtBxDesc.Text;
                activo.PrecioInicial = decimal.Parse(txtPrcIni.Text);
                activo.FechaCompra = dateCompra.Value.Date;
                activo.Proveedor = Convert.ToInt32(cmbBoxPrvdr.SelectedValue.ToString());
                activo.EstadoActivo = Convert.ToInt32(cmbBoxStt.SelectedValue.ToString());
                activosDAL.Update(activo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
 
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
    }
}
