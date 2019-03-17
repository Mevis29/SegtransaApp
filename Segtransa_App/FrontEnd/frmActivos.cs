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
    public partial class frmActivos : Form
    {
        IActivosDAL activosDAL;
        IEstadoActivosDAL estadosActivosDAL;
        public frmActivos()
        {
            InitializeComponent();
        }

        public frmActivos(Form prevForm)
        {
            InitializeComponent();
            activosDAL = new ActivosImplDAL();
            estadosActivosDAL = new EstadoActivosImplDAL();
            cargaListaActivos();
            previousForm = prevForm;
        }

        Form previousForm;
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmActivosAdd frm_AddActivo = new frmActivosAdd(this);
            frm_AddActivo.Show(this);
            this.Hide();
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmActivosSearch frm_GetActivo = new frmActivosSearch(this);
            frm_GetActivo.Show(this);
            this.Hide();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    Activos activo = activosDAL.GetActivo(Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                    List<EstadoActivos> listaEstadosActivos = estadosActivosDAL.GetEstadoActivos();
                    activo.EstadoActivos = estadosActivosDAL.GetEstadoActivo(2);
                    activo.idEstadoActivo = estadosActivosDAL.GetEstadoActivo(2).idEstadoActivo;
                    activosDAL.Update(activo);
                    MessageBox.Show("Activo #" + activo.idActivo + " desactivado.");
                } else
                {
                    MessageBox.Show("Por favor seleccionar activo a desabilitar!");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Por favor seleccione un activo de la lista");
            }
        }

        private void btnUpdate_Click()
        {
            try
            {
                frmActivosUpdate activosUpdate = new frmActivosUpdate(this, activosDAL.GetActivo(Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text)));
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Por favor seleccione un activo de la lista");
            }
        }


        private void cargaListaActivos()
        {
            List<Activos> listaActivos = activosDAL.GetActivos();
            string nombreActivo, descripcionActivo, precio, fechaCompra, idAct, proveedor, estado;
            foreach (var item in listaActivos)
            {
                nombreActivo = activosDAL.GetActivo(item.idActivo).nombreActivo;
                estado = activosDAL.GetActivo(item.idActivo).EstadoActivos.nombreEstado;
                descripcionActivo = activosDAL.GetActivo(item.idActivo).descripcion;
                fechaCompra = activosDAL.GetActivo(item.idActivo).fechaCompra.ToString();
                precio = activosDAL.GetActivo(item.idActivo).precioInicial.ToString(); 
                idAct = activosDAL.GetActivo(item.idActivo).idActivo.ToString();
                proveedor = activosDAL.GetActivo(item.idActivo).Proveedores.nombre;
                ListViewItem viewItem = new ListViewItem(idAct);
                viewItem.SubItems.Add(nombreActivo);
                viewItem.SubItems.Add(descripcionActivo);
                viewItem.SubItems.Add(precio);
                viewItem.SubItems.Add(fechaCompra);
                viewItem.SubItems.Add(proveedor);
                viewItem.SubItems.Add(estado);
                listView1.Items.Add(viewItem);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            cargaListaActivos();
        }
    }
}
