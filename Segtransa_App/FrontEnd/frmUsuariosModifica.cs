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
    public partial class frmUsuariosModifica : Form
    {
        private IUsuariosDAL usuariosDAL;
        private IRolUsuariosDAL rolUsuariosDAL;
        private Usuarios Usuario;

        public frmUsuariosModifica()
        {
            InitializeComponent();
        }

        public frmUsuariosModifica(Form prevform)
        {
            InitializeComponent();
            previousForm = prevform;
        }
        static Form previousForm;

        public frmUsuariosModifica(int id)
        {
            InitializeComponent();
            rolUsuariosDAL = new RolUsuariosImplDAL();
            usuariosDAL = new UsuariosImplDAL();
            Usuario = usuariosDAL.GetUsuario(id); 
        }

        private void CargaComboRoles()
        {
            cmbBoxRol.DisplayMember = "nombreRol";
            cmbBoxRol.ValueMember = "idRol";
            List<Rol_Usuarios> rol_Usuarios = rolUsuariosDAL.GetRols();

            cmbBoxRol.DataSource = rol_Usuarios;
        }

        private void frmUsuariosModifica_Load(object sender, EventArgs e)
        {
            CargaComboRoles();
            txtNombre.Text = Usuario.nombre;
            txtApellido1.Text = Usuario.apellido1;
            txtApellido2.Text = Usuario.apellido2;
            txtContrasena.Text = Usuario.contrasena;
            txtDireccion.Text = Usuario.direccion;
            txtEmail.Text = Usuario.email;
            txtTelefono.Text = Usuario.telefono;
            cmbBoxGeneros.Text = Usuario.genero;


        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario.nombre = txtNombre.Text;
                Usuario.apellido1 = txtApellido1.Text;
                Usuario.apellido2 = txtApellido2.Text;
                Usuario.genero = (string)cmbBoxGeneros.SelectedItem;
                Usuario.telefono = txtTelefono.Text;
                Usuario.email = txtEmail.Text;
                Usuario.direccion = txtDireccion.Text;
                Usuario.idRol = (int)cmbBoxRol.SelectedValue;
                Usuario.Rol_Usuarios = (Rol_Usuarios)cmbBoxRol.SelectedItem;
                Usuario.contrasena = txtContrasena.Text;

                usuariosDAL.Update(Usuario);
                MessageBox.Show("Usuario actualizado");
                frmUsuarios frmUsuarios = new frmUsuarios();

                this.Hide();
                frmUsuarios.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            previousForm.Show();
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
    }
}
