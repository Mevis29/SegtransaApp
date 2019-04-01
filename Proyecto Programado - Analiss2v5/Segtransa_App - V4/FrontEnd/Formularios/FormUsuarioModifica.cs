using Backend.DAL;
using Backend.Entities;
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
    public partial class frmUsuarioModifica : Form
    {
        #region Get y Set e inicializacion
        //definir variable para indicar IdUsuario
        // IdUsuario = spUsuariosRetornaDatosId_Result retornaUsuarioId(int pIdUsuario)
        int IdUsuario { set; get; }

        //cambiar constructor para que utilice variable IdUsuario
        public frmUsuarioModifica(int IdUsuario)
        {
            InitializeComponent();
            this.IdUsuario = IdUsuario;  //variable q llama el SP
        }
        #endregion

        #region Cargar frmUsuariosModifica
        ///Evento pr cargar frmUM
        ///Invocar los mètodos de Cargas y Acceso
        private void FormUsuarioModifica_Load(object sender, EventArgs e)
        {

            this.CargarEstadoUsuario();
            this.CargarRolUsuario();
            this.EstablerAccesoRolUsuario();
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

        #region Boton Modificar
        /// Evento en el boton Modificar
        /// invocar e mètodo ModificarDatos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.ModificarDatos();
        }
        #endregion

        #region Mètodo EstablerAccesoRolUsuario
        void EstablerAccesoRolUsuario()
        {
            //ValoresApliccn = Clases
            //referencia al rol o tipo de Usuario (Empleado)
            if (ValoresAplicacion.rolUsuario == "Empleado")
            {
                //Invocar eventos del grb y btn con sus parametros
                //q determinaran si un Usuario es Empleado o Admin
                this.grbDatosAcceso.Visible = false;
                this.btnAceptar.Location = new Point(330, 430);
                this.btnCancelar.Location = new Point(550, 430);
            }
        }
        #endregion

        #region Mètodo CargarEstadoUsuario
        void CargarEstadoUsuario()
        {
            //objeto de la instancia del mètodo
            UsuariosImplDAL Estadousuario = new UsuariosImplDAL();

            this.lsbEstado.DataSource = Estadousuario.retornaListaEstadosUsuario();
            //el lbs invoca el origen de datos de EstdUs pr retornarlo a la lista desplegada
        }
        #endregion

        #region Mètodo CargarRolUsuario
        void CargarRolUsuario()
        {
            //objeto de la instancia del mètodo
            UsuariosImplDAL Rolusuario = new UsuariosImplDAL();

            this.lsbRol.DataSource = Rolusuario.retornaListaRolesUsuario();
            //el lbs invoca el origen de datos de RolUs pr retornarlo a la lista desplegada
        }
        #endregion

        #region Mètodo CargarDatos
        /// <summary>
        /// Método para cargar datos actuales y IdUsuario
        /// </summary>
        void CargarDatos()
        {

            //objeto de la instancia del mètodo
            UsuariosImplDAL UsuarioD = new UsuariosImplDAL();

            //SP q retorna los datos del Usuario(id)
            spUsuariosRetornaDatosId_Result resultadoSP = UsuarioD.retornaUsuarioId(this.IdUsuario);
            if (resultadoSP != null)
            {
                ///Extrae y muestra los resultados en los txt del FormUM

                this.txtNombre.Text = resultadoSP.Nombre;
                this.txtApellido.Text = resultadoSP.Apellido;
                this.txtCedula.Text = resultadoSP.Cedula.ToString();
                this.dtpFechaCreacn.Value = DateTime.Parse(resultadoSP.FechaCreacion);
                this.txtCorreo.Text = resultadoSP.Correo;
                this.txtContrasena.Text = resultadoSP.Contrasena;
                this.txtTelefono.Text = resultadoSP.Telefono;
                this.txtDireccion.Text = resultadoSP.Direccion;
                this.lsbEstado.SelectedValue = resultadoSP.Estado;
                this.lsbRol.SelectedValue = resultadoSP.Rol;
            }
            else
            {
                MessageBox.Show("El registro seleccionado no existe.",
                    "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);


                ///habilita el botòn Modificar para procedecer con el mètodo ModificarDatos    
                this.btnAceptar.Enabled = false;
            }
        }
        #endregion

        #region Mètodo para ModificarDatos
        void ModificarDatos()
        {
            if (ValidarIngresoDatos())
            {
                try
                {
                    // Objeto de la instancia del Mètodo
                    UsuariosImplDAL UsuarioD = new UsuariosImplDAL();

                    ///todos los datos se cargan en "0"
                    int IdEstado = 0, IdRol = 0, Cedula = 0;

                    ///conversion de las Propiedades tipo int 
                    ///pr seleccionar y mostrar datos en el formUM
                    ///
                    IdEstado = Convert.ToInt16(this.lsbEstado.SelectedValue);
                    IdRol = Convert.ToInt16(this.lsbRol.SelectedValue);
                    Cedula = Convert.ToInt32(this.txtCedula.Text);

                    //var Usuario q invoca al Mètodo ModificarUsuario y muestre datos en el formUM
                    UsuarioD.ModificaUsuario(this.txtNombre.Text, this.txtApellido.Text, IdEstado, IdRol, Cedula,
                        this.txtContrasena.Text, this.txtTelefono.Text,
                         this.txtCorreo.Text, this.txtDireccion.Text, this.dtpFechaCreacn.Value);

                    MessageBox.Show("Registro modificado correctamente.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("No fue posible modificar el registro. \nEs posible que esté incluyendo datos duplicados",
                       "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Mètodo ValidarIngresoDatos
        bool ValidarIngresoDatos()
        {
            bool resultado = true;
            string mensaje = "";

            if (this.txtCedula.Text == "")
            {
                mensaje += "Debe ingresar un valor para Cédula.";
            }

            if (this.txtNombre.Text == "")
            {
                mensaje += "\nDebe ingresar un valor para Nombre.";
            }

            if (this.txtApellido.Text == "")
            {
                mensaje += "\nDebe ingresar un valor para Apellido.";
            }

            if (this.txtCorreo.Text == "")
            {
                mensaje += "\nDebe ingresar un valor para Correo Electrónico";
            }

            if (this.txtDireccion.Text == "")
            {
                mensaje += "\nDebe ingresar un valor para Dirección Física";
            }

            if (this.txtTelefono.Text == "")
            {
                mensaje += "\nDebe ingresar un valor para el Teléfono No.1";
            }

            if (this.txtContrasena.Text == "")
            {
                mensaje += "\nDebe ingresar un valor para Contraseña";
            }

            if (mensaje != "")
            {
                MessageBox.Show(mensaje, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = false;
            }

            return resultado;
        }
        #endregion
    }
}