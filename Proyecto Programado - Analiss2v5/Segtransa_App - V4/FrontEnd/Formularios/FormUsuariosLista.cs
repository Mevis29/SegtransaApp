using Backend.DAL;
using FrontEnd.Clases;
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
    public partial class FormUsuariosLista : Form
    {
        public FormUsuariosLista()
        {
            InitializeComponent();
        }


        #region Evento mnuCerrar 
        //evento Cerrar Ventana
        private void mnuCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Cargar el frmUsuariosLista
        //Evento q invoca al mètodo EstablerAccesoRolUsuario 
        private void frmUsuariosLista_Load(object sender, EventArgs e)
        {
            this.EstablerAccesoRolUsuario();
        }
        #endregion

        #region Botòn Buscar 
        //Eveneto q filtra la busqueda y la muestra en le dvg
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.CargarDatosAdmin();
        }

        #endregion

        #region Mètodo EstablerAccesoRolUsuario
        /// <summary>
        /// Establece formato y datos del form de acuerdo al rol del usuario
        /// </summary>
        void EstablerAccesoRolUsuario()
        {
            if (ValoresAplicacion.rolUsuario == "Empleado")
            {
                this.dgvLista.Size = new Size(1240, 120);
                this.dgvLista.Location = new Point(10, 50);
                this.mnuModificar.Text = "Actualizar Datos";
                this.mnuAgregar.Text = "";
                this.mnuEliminar.Text = "";
                this.mnuAgregar.Visible = false;
                this.mnuEliminar.Visible = false;
                this.grpBuscar.Visible = false;
                this.Column8.Visible = false;
                this.Column9.Visible = false;
                this.CargarDatosEmpleado();
            }
            else
            {
                this.CargarDatosAdmin();
            }
        }
        #endregion

        #region Mètodo CargarDatosAdmin
        /// <summary>
        /// Carga los datos del Stored Procedure en el DGV para Admin
        /// </summary>
        void CargarDatosAdmin()
        {
            //objeto de la instancia del mètodo
            UsuariosImplDAL datosAdmin = new UsuariosImplDAL();
            this.dgvLista.DataSource = datosAdmin.retornaListaUsuarios(this.txtCedula.Text, this.txtNombre.Text, this.txtCorreo.Text);
            //el dvg invoca el origen de datos y los refiere al objeto q retorna en una lista desplegada y la filtra
            //cuando el usuario-Admin se loguee
        }
        #endregion

        #region Mètodo CargarDatosEmpleado
        /// <summary>
        /// Carga los datos del Stored Procedure en el DGV para Empleados
        /// </summary>
        void CargarDatosEmpleado()
        {
            //objeto de la instancia del mètodo
            UsuariosImplDAL datosEmpleado = new UsuariosImplDAL();

            this.dgvLista.DataSource = datosEmpleado.retornaListaUsuarioId(ValoresAplicacion.idUsuario);
            //el dvg invoca el origen de datos y los refiere al objeto con los Valores de aplicaciòn,
            //pr retornarlo en una lista desplegada cuando el usuario-Empleado se loguee
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
            {  ///selecciona el dato de la fila marcada a color en el dgv pr ser tratado
                int filaSeleccionada = this.dgvLista.CurrentCell.RowIndex;
                resultado = Convert.ToInt16(this.dgvLista[0, filaSeleccionada].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar una fila válida",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }

        #endregion

        #region Evento mnuAgregar 
        private void mnuAgregar_Click(object sender, EventArgs e)
        {
            //Objeto de la instancia del Form
            //Invoca al Mètodo CargarDatosEmpleado
            frmUsuarioInserta formInsertarUsuario = new frmUsuarioInserta();
            formInsertarUsuario.ShowDialog();
            this.CargarDatosAdmin();
        }
        #endregion

        #region Evento mnuModificar
        private void mnuModificar_Click(object sender, EventArgs e)
        {
            //var valorSeleccionado q invoca al Mètodo RetornarIdSeleccionado
            int valorSeleccionado = this.RetornarIdSeleccionado();

            if (valorSeleccionado > -1)
            {
                if (ValoresAplicacion.rolUsuario == "Empleado")
                {
                    //mostrar el formulario enviando como valor lo seleccionado en el DGV
                    //cargar el Mètodo CargarDatosCliente
                    frmUsuarioModifica formModificarUsuario = new frmUsuarioModifica(valorSeleccionado);
                    formModificarUsuario.Size = new Size(980, 540);
                    formModificarUsuario.Text = "Actualizar Datos Personales";
                    formModificarUsuario.ShowDialog();
                    this.CargarDatosEmpleado();
                }
                else
                {
                    //mostrar el formulario enviando como valor lo seleccionado en el DGV
                    //cargar el Mètodo CargarDatosEmpleado
                    frmUsuarioModifica formModificarUsuario = new frmUsuarioModifica(valorSeleccionado);
                    formModificarUsuario.ShowDialog();
                    this.CargarDatosAdmin();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila válida",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Evento mnuEliminar
        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            int valorSeleccionado = this.RetornarIdSeleccionado();

            if (valorSeleccionado > -1)
            {
                //mostrar el formulario enviando como valor lo seleccionado en el DGV
                FormUsuarioElimina formEliminarUsuario = new FormUsuarioElimina(valorSeleccionado);
                formEliminarUsuario.ShowDialog();
                this.CargarDatosAdmin();
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
