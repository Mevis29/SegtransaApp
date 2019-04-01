using Backend.Entities;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        #region Boton Cancelar
        /// Evento en el boton Cancelar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Boton Insertar
        /// Evento en el boton insertar 
        /// activa el metodo AutenticarUsuario 
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.AutenticarUsuario();
        }
        #endregion

        #region Metodo AutenticarUsuario
        /// <summary>
        /// Método para verificar login del usuario
        /// </summary>
        void AutenticarUsuario()
        {
        //crear instancia de los métodos de usuario
            // UsuariosImplDAL usuario = new UsuariosImplDAL();
            // MUsuario Usuario = new MUsuario();
            UsuariosImplDAL usuario = new UsuariosImplDAL();

            //crear instancia para asignar datos de usuario desde SP
            spUsuariosRetornaDatosLogin_Result datosLogin = new spUsuariosRetornaDatosLogin_Result();

            //llamar SP para retonar datos de usuario para login
            datosLogin = usuario.retornaDatosLogin(this.txtCorreo.Text, this.txtContrasena.Text);

            //si no se retorna ningún resultado, indicar mensaje al usuario
            if (datosLogin == null)
            {
                ValoresAplicacion.usuarioAutenticado = false;

                MessageBox.Show("Datos de usuario incorrectos." + Environment.NewLine +
                    "Por favor ingrese los datos correctos.",
                    "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);

               // this.txtCorreo.Text = "";
                this.txtContrasena.Text = "";

            }
            //si se retorna un resultado, validar esado del usuario
            else
            {
                //si el usuario está activo, asignar variables globales, mostrar mensaje y actualizar login
                if (datosLogin.Estado == "Activo")
                {
                    //asignar variables globales de sesión del usuario 
                    //
                    ValoresAplicacion.idUsuario = datosLogin.Id;
                    ValoresAplicacion.nombreUsuario = datosLogin.Nombre;
                    ValoresAplicacion.correoUsuario = datosLogin.Correo;
                    ValoresAplicacion.rolUsuario = datosLogin.Rol;
                    ValoresAplicacion.usuarioAutenticado = true;

                    //esta condiciòn valida la fecha 
                    //compara la fecha en la q se esta logueando el Usuario
                    if (datosLogin.UltLogin.Contains("2000"))
                    {
                        //mostrar mensaje con datos de usuario y último login
                        MessageBox.Show("Bienvenido " + datosLogin.Nombre + "." + Environment.NewLine +
                        "Esta es la primera vez que ingresa al Sistema.",
                        "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //mostrar mensaje con datos de usuario y último login
                        MessageBox.Show("Bienvenido " + datosLogin.Nombre + "." + Environment.NewLine +
                        "Usted ingresó por última vez el " + datosLogin.UltLogin,
                        "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //actualizar fecha y hora de último login del usuario
                    usuario.actualizaDatosLogin(datosLogin.Id);
                }
                //si el usuario está inactivo, mostrar mensaje 
                else
                {
                    MessageBox.Show("Su acceso se encuentra actualmente deshabilitado." + Environment.NewLine +
                        "Por favor consulte con un administrador para reactivarlo.",
                        "Acceso Deshabilitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.Close();
            }

            #endregion

        }
    }
}
