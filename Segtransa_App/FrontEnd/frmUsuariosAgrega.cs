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

namespace FrontEnd
{
    public partial class frmUsuariosAgrega : Form
    {
        private IUsuariosDAL usuariosDAL;
        private IRolUsuariosDAL rolUsuariosDAL;
        private Usuarios Usuario;
        
        public frmUsuariosAgrega()
        {
            InitializeComponent();
            usuariosDAL = new UsuariosImplDAL();
            rolUsuariosDAL = new RolUsuariosImplDAL();
        }

        public frmUsuariosAgrega(Form prevForm)
        {
            InitializeComponent();
            usuariosDAL = new UsuariosImplDAL();
            rolUsuariosDAL = new RolUsuariosImplDAL();
            previousForm = prevForm;
        }

        static Form previousForm;
        private void CargaComboRoles()
        {
            cmbBoxRol.DisplayMember = "nombreRol";
            cmbBoxRol.ValueMember = "idRol";
            List<RolUsuarios> rol_Usuarios = rolUsuariosDAL.GetRols();

            cmbBoxRol.DataSource = rol_Usuarios;
        }

        private void frmUsuariosAgrega_Load(object sender, EventArgs e)
        {
            CargaComboRoles();
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario = new Usuarios();
                Usuario.Nombre = txtNombre.Text;
                Usuario.Apellido = txtApellido1.Text;
                Usuario.Telefono = txtTelefono.Text;
                Usuario.Correo = txtEmail.Text;
                Usuario.Direccion = txtDireccion.Text;
                Usuario.RolUsuario = (int)cmbBoxRol.SelectedValue;
                Usuario.RolUsuarios = (RolUsuarios)cmbBoxRol.SelectedItem;
                Usuario.Contrasena = txtContrasena.Text;
                Usuario.FechaCreacion =  DateTime.Now;

                usuariosDAL.Add(Usuario);
                MessageBox.Show("Usuario agregado");

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
           
            frmUsuarios frmUsuarios = new frmUsuarios();

            //this.Close();
            this.Hide();
            frmUsuarios.Show();
        }
    }
}
