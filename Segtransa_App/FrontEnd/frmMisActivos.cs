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
    public partial class frmMisActivos : Form
    {
        public frmMisActivos()
        {
            InitializeComponent();
        }
        public frmMisActivos(int idUsuario, Form prevForm)
        {
            InitializeComponent();
            previousForm = prevForm;
            id = idUsuario;
        }

        static Form previousForm;
        IAsignacionesDAL asignacionesDAL = new AsignacionesImplDAL();
        IActivosDAL activosDAL = new ActivosImplDAL();
        int id;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
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

        private void frmMisActivos_Load(object sender, EventArgs e)
        {
            List<THAsignaciones> asignacionesUsuario = asignacionesDAL.GetAsignaciones(id);
            List<Activos> activosUsuario = new List<Activos>();
            lvMisActivos.View = View.Details;
            lvMisActivos.Columns.Add("Id");
            lvMisActivos.Columns.Add("Activo");
            lvMisActivos.Columns.Add("Descripcion");
            lvMisActivos.Columns.Add("Fecha de Compra");
            lvMisActivos.Columns.Add("Estado");
            lvMisActivos.Columns.Add("Proveedor");
            lvMisActivos.Columns[1].Width = -2;
            lvMisActivos.Columns[2].Width = -2;
            lvMisActivos.Columns[3].Width = -2;
            lvMisActivos.Columns[4].Width = -2;
            lvMisActivos.Columns[5].Width = -2;
            lvMisActivos.Columns[0].Width = -2;
            string activo, nombreEstado, descripcion, fechaCompra, idAct, proveedor; 
            foreach (var item in asignacionesUsuario)
            {
                activo = activosDAL.GetActivo(item.IdActivo ?? default(int)).CodActivo;
                nombreEstado = activosDAL.GetActivo(item.IdActivo ?? default(int)).EstadoActivos.NombreEstado;
                descripcion = activosDAL.GetActivo(item.IdActivo ?? default(int)).Descripcion;
                fechaCompra = activosDAL.GetActivo(item.IdActivo ?? default(int)).FechaCompra.ToString();
                idAct = activosDAL.GetActivo(item.IdActivo ?? default(int)).IdActivo.ToString();
                proveedor = activosDAL.GetActivo(item.IdActivo ?? default(int)).Proveedores.NombreProveedor;
                string[] listS = { idAct, activo, descripcion, fechaCompra, nombreEstado, proveedor };
                lvMisActivos.Items.Add(new ListViewItem(listS));
            }
        }
    }
}
