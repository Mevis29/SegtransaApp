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
        BDContext context;
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

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmActivosModificar form = new FrmActivosModificar())
                {
                    form.ShowDialog(this);
                }
            }
            catch (Exception)
            {

                try
                {
                    using (FrmActivosInsertar form = new FrmActivosInsertar())
                    {
                        //form.ShowDialog(this);
                        cargarActivos();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void tablaActivos_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            tablaActivos.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = txtBusqueda.Text;
                using (context = new BDContext())
                {
                    context.sp_BuscarActivosPorIdYNombre(busqueda);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

       
      

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                tablaActivos.CurrentCell = null;
                foreach (DataGridViewRow r in tablaActivos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in tablaActivos.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString()).ToUpper().IndexOf(txtBusqueda.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }

            }
            else
            {
                cargarActivos();
            }
        }
    }
}
