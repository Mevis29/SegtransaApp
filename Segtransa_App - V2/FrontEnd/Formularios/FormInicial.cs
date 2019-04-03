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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
            this.Closing += OnClosing; //Invocar pr cerrar o abrir eventos
        }
        #region Método OnClosing (cerrar programa)
        ///Invocar pr abrir evento en el form
        private void OnClosing(object sender, CancelEventArgs cancelEventArgs)
        {
            DialogResult cerrarSistema = MessageBox.Show("¿Está seguro que desea salir del sistema?",
                "Cerrar Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cerrarSistema == DialogResult.Yes)
            {
                cancelEventArgs.Cancel = false;
            }
            else if (cerrarSistema == DialogResult.No)
                cancelEventArgs.Cancel = true;
        }
        #endregion

        #region Evento mnuCerrar
        //salir del form
        private void mnuCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region cargar FormInicial
        //invocar el mètodo EstablerAccesoRolUsuario
        private void FormInicial_Load(object sender, EventArgs e)
        {
            this.EstablerAccesoRolUsuario();
        }
        #endregion

        #region Método EstablerAccesoRolUsuario 
        //Extrae los valores de la clase  ValoresAplicacion
        void EstablerAccesoRolUsuario()
        {
            switch (ValoresAplicacion.rolUsuario)
            {
                case "Admin":
                    {  // tiene plena libertad de ver, insertar, modificar y eliminar datos de los Uss
                        this.mnuCatalogo.Visible = true;
                        this.mnuUsuario.Visible = true;
                        this.mnuActivos.Visible = true;
                        this.mnuAsignaciones.Visible = true;
                        this.mnuReparaciones.Visible = true;
                        this.mnuBitacora.Visible = true;
                        this.lblNombreUsuario.Text = ValoresAplicacion.nombreUsuario;
                        this.lblDatosLogin.Text = DateTime.Now.ToString("dd-MMM-yyyy , hh:mm tt");

                        ///   this.mnuBitacora.Visible = true;
                        ///este permite mostrar x un label el User y name Usuario en el form
                        ///   this.lblNombreUsuario.Text = ValoresAplicacion.nombreUsuario;
                        ///  this.lblDatosLogin.Text = DateTime.Now.ToString("dd-MMM-yyyy , hh:mm tt");
                    }
                    break;

                case "Empleado":
                    { //solo puede ver sus datos personales y reportes de sus polizas
                      //y actulizar sus datos 
                        this.mnuCatalogo.Text = "Opciones";
                        this.mnuUsuario.Text = "Datos Personales";
                        this.mnuActivos.Text = "";
                        this.mnuAsignaciones.Text = "";
                        this.mnuReparaciones.Text = "";        

                        ////este cede derecho del admin al empleado asignado
                        this.mnuCatalogo.Visible = true;
                        this.mnuUsuario.Visible = true;
                        this.mnuActivos.Visible = false;
                        this.mnuAsignaciones.Visible = false;
                        this.mnuReparaciones.Visible = false;
                        this.mnuBitacora.Visible = false;
                        ///este permite mostrar x un label el User y name Usuario en el form
                        ///   this.lblNombreUsuario.Text = ValoresAplicacion.nombreUsuario;
                        ///   this.lblDatosLogin.Text = DateTime.Now.ToString("dd-MMM-yyyy , hh:mm tt");
                    }
                    break;
            }
        }
        #endregion


        #region evento mnuUsuarios

        ///LISTA DE TODOS LOS MNU FORMS Q TIENE INCLUIDO EN MENU EL FORMINICIAL
        ///Form q se vera en dos vistas diferentes segùn el tipo de Usr
        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            if (ValoresAplicacion.rolUsuario == "Empleado")
            {
                FormUsuariosLista formUsuarios = new FormUsuariosLista();
                formUsuarios.Size = new Size(1282, 250);
                formUsuarios.Text = "Datos Personales";
                formUsuarios.ShowDialog();
            }
            else
            {
                FormUsuariosLista formUsuarios = new FormUsuariosLista();
                formUsuarios.ShowDialog();
            }
        }

        #endregion
    }
}

