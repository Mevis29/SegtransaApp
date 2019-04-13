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

namespace FrontEnd.Formularios
{
    public partial class FormUsuarioElimina : Form
    {
        #region Get y Set e inicializacion
        //definir variable para indicar IdUsuario
        //IdUsuario = spUsuariosRetornaDatosId_Result retornaUsuarioId(int pIdUsuario);
        int IdUsuario { set; get; }

        public FormUsuarioElimina(int pIdusuario)
        {
            InitializeComponent();
            this.IdUsuario = pIdusuario;  //variable q llama el SP
        }
        #endregion

        #region Cargar frmUsuariosElimina
        //Evento del form pr invocar al mètodo CargarDatos
        private void FormUsuarioElimina_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }
        #endregion

        #region Boton Cancelar
        /// Evento en el boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Boton Eliminar
        /// Evento en el boton Eliminar q llama al metodo EliminarDatos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.EliminarDatos();
        }
        #endregion

        #region Método para cargar datos actuales y IdUsuario
        /// <summary>
        /// Método para cargar datos actuales y IdUsuario
        /// </summary>
        void CargarDatos()
        {
            // Objeto de la instancia del Mètodo
            UsuariosImplDAL usuario = new UsuariosImplDAL();

            spUsuariosRetornaDatosId_Result resultadoSP = usuario.retornaUsuarioId(this.IdUsuario);
            if (resultadoSP != null)
            {
                ///Extraer y mostrar los resultados en los txt del FormUE 
                this.txtCedula.Text = resultadoSP.Cedula.ToString();
                this.txtNombre.Text = resultadoSP.Nombre + " " + resultadoSP.Apellido;
                this.txtCorreo.Text = resultadoSP.Correo;
            }
            else
            {
                MessageBox.Show("El registro seleccionado no existe.",
                    "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ///habilita el btnAceptar para procedecer con el mètodo eliminar
                this.btnAceptar.Enabled = false;
            }
        }
        #endregion

        #region Mètodo para EliminarDatos
        void EliminarDatos()
        {
            try
            {
                // Objeto de la instancia del Mètodo
                UsuariosImplDAL usuario = new UsuariosImplDAL();

                usuario.EliminaUsuario(this.IdUsuario);   //var q invoca el mètodo eliminar usuario existnt

                MessageBox.Show("Registro eliminado correctamente.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible eliminar el registro. \nEs posible que el registro se encuentre en uso.",
                    "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void FormUsuarioElimina_Load_1(object sender, EventArgs e)
        {

        }
    }
}
