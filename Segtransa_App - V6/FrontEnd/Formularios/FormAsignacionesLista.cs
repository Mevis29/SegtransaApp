using Backend.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Formularios
{
    public partial class FormAsignacionesLista : Form
    {
        public FormAsignacionesLista()
        {
            InitializeComponent();
        }

        #region evento mnuCerrar
        //salir del form
        private void mnuCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region cargar formAsignacionesLista
        //invocar mètodo CD
        private void FormAsignacionesLista_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }
      
        #endregion

        #region botòn Buscar
        //invoca mètodo CD
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.CargarDatos();
        }
        #endregion

        #region Mètodo CargarDatos
        /// <summary>
        /// Carga los datos del Stored Procedure en el DGV
        /// </summary>
        void CargarDatos()
        {
            /// Objeto de la instancia del Mètodo
            AsignacionesImplDAL datos = new AsignacionesImplDAL();
            //Mètodo pr retornar list completa de asignacions x Usuario
            this.dgvLista.DataSource = datos.retornaListaAsignUsuario(this.txtUsuario.Text, this.txtActivo.Text);
        }
        #endregion

        #region Mètodo RetornarIdSeleccionado
        /// <summary>
        /// Retorna el valor del Id seleccionado en el DGV
        /// </summary>
        int RetornarIdSeleccionado()
        {
            int resultado = -1;

            try
            {
                //selecciona los datos de la fila cn color pr ser tratados
                int filaSeleccionada = this.dgvLista.CurrentCell.RowIndex;
                resultado = Convert.ToInt16(this.dgvLista[0, filaSeleccionada].Value);
            }
            catch (Exception)
            {
                throw;
            }

            return resultado;
        }
        #endregion

        #region evento mnuAgregar
        private void mnuAgregar_Click(object sender, EventArgs e)
        {
            ///al agregar, cargar y muestra los datos en el dgv
            FormAsignacionesInsertar formInsertarAsignacion = new FormAsignacionesInsertar();
            formInsertarAsignacion.ShowDialog();
            this.CargarDatos();
        }
        #endregion

        #region evento mnuModificar
        private void mnuModificar_Click(object sender, EventArgs e)
        {
            int valorSeleccionado = this.RetornarIdSeleccionado(); //retorna el valor del id seleccdo en el dgv

            if (valorSeleccionado > -1)
            {
                //mostrar el formulario enviando como valor lo seleccionado en el DGV
                FormAsignacionesModifica formModificarAsignacion = new FormAsignacionesModifica(valorSeleccionado);
                formModificarAsignacion.ShowDialog();
                this.CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila válida",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region evento
        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            int valorSeleccionado = this.RetornarIdSeleccionado(); //retorna el valor del id seleccdo en el dgv

            if (valorSeleccionado > -1)
            {
                //mostrar el formulario enviando como valor lo seleccionado en el DGV
                FormAsignacionesElimina formEliminarAsignacion = new FormAsignacionesElimina(valorSeleccionado);
                formEliminarAsignacion.ShowDialog();
                this.CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila válida",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}
