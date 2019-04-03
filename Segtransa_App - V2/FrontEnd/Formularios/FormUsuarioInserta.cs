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
    public partial class frmUsuarioInserta : Form 
    {
        public frmUsuarioInserta()
        {
            InitializeComponent();
        }

        #region Cargar frmUsuariosInserta
        //Evento del form pr invocar mètodos y tools con referencias

        private void frmUuarioInserta_Load(object sender, EventArgs e)
        {
            //Incovar mètodos de carga

            this.CargarEstadoUsuario();
            this.CargarRolUsuario();

            //Invocar las herramientas refereciadas a valores del sistema
            this.dtpFechaCreacn.Value = new DateTime(1980, 01, 01);
            this.lsbEstado.SelectedValue = "";
            this.lsbRol.SelectedValue = "";
        }
        #endregion

        #region Boton Cancelar
        /// Evento en el boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Boton Insertar
        /// Evento en el boton insertar q invoca al mètodo InsertarDatos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.InsertarDatos();
        }
        #endregion


        #region Mètodo CargarEstadoUsuario
        void CargarEstadoUsuario()
        {
            // Objeto de la instancia del Mètodo
            UsuariosImplDAL Estadousuario = new UsuariosImplDAL();
            this.lsbEstado.DataSource = Estadousuario.retornaListaEstadosUsuario();
            //el lbs invoca el origen de datos de EstadoUs pr retornarlo a la lista desplegada
        }
        #endregion

        #region Mètodo CargarRolUsuario
        void CargarRolUsuario()
        {
            // Objeto de la instancia del Mètodo
            UsuariosImplDAL Rolusuario = new UsuariosImplDAL();
            this.lsbRol.DataSource = Rolusuario.retornaListaRolesUsuario();
            //el lbs invoca el origen de datos de RolUs pr retornarlo a la lista desplegada
        }
        #endregion

        #region Mètodo InsertarDatos
        void InsertarDatos()
        {
            if (ValidarIngresoDatos())
            {
                try
                {
                    // Objetos de las instancias de los Mètodos
                    UsuariosImplDAL Usuario = new UsuariosImplDAL();
                    ///  MCorreo Correo = new MCorreo();    ///en caso de usar avss de registro x correo

                    //todos los datos se cargan en "0"
                    int IdEstado = 0, IdRol = 0, Cedula = 0;

                    //var nombreCompleto concatenara cm resumen las propiedades del Usuario - empld
                    string nombreCompleto = this.txtNombre.Text + " " + this.txtApellido.Text;

                    ///conversion de las Propiedades tipo int 
                    ///pr seleccionar y mostrar datos en el formUI 
                  
                    IdEstado = Convert.ToInt16(this.lsbEstado.SelectedValue);
                    IdRol = Convert.ToInt16(this.lsbRol.SelectedValue);
                    Cedula = Convert.ToInt32(this.txtCedula.Text);

                    //var Usuario q invoca al Mètodo InsertarUsuario y muestre datos en el formUI
                    Usuario.InsertaUsuario(this.txtNombre.Text, this.txtApellido.Text, IdEstado, IdRol, Cedula,
                        this.txtContrasena.Text, this.txtTelefono.Text,
                         this.txtCorreo.Text, this.txtDireccion.Text, this.dtpFechaCreacn.Value);

                    MessageBox.Show("Registro insertado correctamente.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    //Condiciòn exclusiva pr el Usuario Empldo registrado por primera vez
                    //Envìo de correo de bienvenida 
                    //si se usa se debe crear una interfaz para Correo = ICorreo

                    /*if (IdRol == 2)
                      
                    {
                        Correo.enviarCorreo(this.txtCorreo.Text, nombreCompleto);
                    }
                    */


                    //Refiere a todos los campos del formUI q carguen en "0"
                    this.txtCedula.Text = "";
                    this.txtNombre.Text = "";
                    this.txtApellido.Text = "";
                    this.dtpFechaCreacn.Value = new DateTime(1980, 01, 01);
                    this.txtCorreo.Text = "";
                    this.txtContrasena.Text = "";
                    this.txtDireccion.Text = "";
                    this.txtTelefono.Text = "";
                    this.lsbEstado.SelectedValue = "";
                    this.lsbRol.SelectedValue = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("No fue posible insertar el registro. \nEs posible que esté agregando datos duplicados",
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
                mensaje += "\nDebe ingresar un valor para el Teléfono";

                if (this.txtContrasena.Text == "")
                {
                    mensaje += "\nDebe ingresar un valor para Contraseña";
                }
                if (this.lsbEstado.Text == "")
                {
                    mensaje += "\nDebe ingresar un valor para Estado";
                }
                if (this.lsbRol.Text == "")
                {
                    mensaje += "\nDebe ingresar un valor para Rol";
                }

                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = false;
                }
            }
            return resultado;
        }
        #endregion
    }
}

