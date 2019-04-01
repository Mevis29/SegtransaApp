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
        int idAct;
        private IActivosDAL activosDAL = new ActivosDALImpl();


        public frmActivos()
        {
            InitializeComponent();
        }

        private void cargarActivos()
        {
             this.tablaActivos.DataSource = null;
            this.tablaActivos.DataSource = activosDAL.obtenerActivos();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmActivos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet1.sp_mostrarActivo' Puede moverla o quitarla según sea necesario.
            this.sp_mostrarActivoTableAdapter.Fill(this.inventarioActivosDataSet1.sp_mostrarActivo);
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet.Activos' Puede moverla o quitarla según sea necesario.
            this.activosTableAdapter.Fill(this.inventarioActivosDataSet.Activos);
            cargarActivos();
        }

        int idP;
        private void obtenerIDTabla(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idP = Int32.Parse(tablaActivos.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }


            private void agregarActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmActivosInsertar form = new FrmActivosInsertar())
                {
                    form.ShowDialog(this);
                    cargarActivos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void grpBuscar_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                activosDAL.eliminarActivo(this.idP);
                MessageBox.Show("Producto eliminado");
                cargarActivos();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void eliminarActivoSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                activosDAL.eliminarActivo(this.idP);
                MessageBox.Show("Activo eliminado");
                cargarActivos();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void cerrarVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
