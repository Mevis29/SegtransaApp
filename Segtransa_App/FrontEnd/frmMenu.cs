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
    public partial class frmMenuReporte : Form
    {
        private Usuarios usuario;
        static Form previousForm;
        public frmMenuReporte()
        {
            InitializeComponent();

        }
        public frmMenuReporte(Usuarios user, Form prevForm)
        {
            InitializeComponent();
            if (user.RolUsuario != 1)
            {
                btnActivos.Enabled = false;
                btnUsuarios.Enabled = false;
            }
            usuario = user;
            previousForm = prevForm;
            printInfo();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void printInfo()
        {
            lblNombre.Text = usuario.Nombre + " " + usuario.Apellido;
            lblFecha.Text = DateTime.Today.ToShortDateString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frm_Usuarios = new frmUsuarios(this);
            frm_Usuarios.Show(this);
            this.Hide();
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            frmActivos frm_Activos = new frmActivos(this);
            frm_Activos.Show(this);
            this.Hide();
        }

        private void btnMisDatos_Click(object sender, EventArgs e)
        {
            frmMisDatos frm_MisDatos = new frmMisDatos(usuario, this);
            frm_MisDatos.Show();
            this.Hide();
        }

        private void btnMisActivos_Click(object sender, EventArgs e)
        {
            frmMisActivos frm_MisActivos = new frmMisActivos(usuario.IdUsuario, this);
            frm_MisActivos.Show();
            this.Hide();
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frm_Reportes = new frmReportes(this);
            frm_Reportes.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            printInfo();
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
