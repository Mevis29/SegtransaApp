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
            List<RolUsuarios> rol_Usuarios = rolUsuariosDAL.GetRols();

            cmbBoxRol.DataSource = rol_Usuarios;
        }

        private void frmUsuariosModifica_Load(object sender, EventArgs e)
        {
            CargaComboRoles();
            txtNombre.Text = Usuario.Nombre;
            txtApellido1.Text = Usuario.Apellido;
            txtContrasena.Text = Usuario.Contrasena;
            txtDireccion.Text = Usuario.Direccion;
            txtEmail.Text = Usuario.Correo;
            txtTelefono.Text = Usuario.Telefono;
        


        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario.Nombre = txtNombre.Text;
                Usuario.Apellido = txtApellido1.Text;
                Usuario.Telefono = txtTelefono.Text;
                Usuario.Correo = txtEmail.Text;
                Usuario.Direccion = txtDireccion.Text;
                Usuario.RolUsuario = (int)cmbBoxRol.SelectedValue;
                Usuario.RolUsuarios = (RolUsuarios)cmbBoxRol.SelectedItem;
                Usuario.Contrasena = txtContrasena.Text;

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
