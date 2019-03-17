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
    public partial class frmUsuarios : Form
    {
        private IUsuariosDAL usuariosDAL;
        private List<Usuarios> usuarios;

        public frmUsuarios()
        {
            InitializeComponent();
            usuariosDAL = new UsuariosImplDAL();
        }
        public frmUsuarios(Form prevForm)
        {
            InitializeComponent();
            usuariosDAL = new UsuariosImplDAL();
            previousForm = prevForm;
        }

        public void CargarLista()
        {
            lstUsuarios.Items.Clear();
            usuarios = usuariosDAL.GetUsuarios();

            foreach(var item in usuarios)
            {
                item.nombre = item.nombre + " " + item.apellido1 + " " + item.apellido2;
            }


            lstUsuarios.DisplayMember = "nombre";
            lstUsuarios.ValueMember = "idUsuario";

            lstUsuarios.DataSource = usuarios;

        }

        static Form previousForm;
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmUsuariosAgrega frm_UsuariosAgrega = new frmUsuariosAgrega(this);
            frm_UsuariosAgrega.Show();
            this.Hide();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            Usuarios usuario = (Usuarios)lstUsuarios.SelectedItem;
            frmUsuariosModifica frm_UsuariosModifica = new frmUsuariosModifica(usuario.idUsuario); //(this)
            frm_UsuariosModifica.Show();
            this.Hide();
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

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios usuario = (Usuarios)lstUsuarios.SelectedItem;
              
                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar al usuario " + usuario.nombre + "?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    usuariosDAL.Delete(usuario.idUsuario);
                    MessageBox.Show("Usuario Eliminado");

                    usuarios.Clear();
                    lstUsuarios.DataSource = null;
                    
                    CargarLista();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Operacion Cancelada");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
