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
    public partial class frmMisDatos : Form
    {
        public frmMisDatos()
        {
            InitializeComponent();
        }

        public frmMisDatos(Usuarios user, Form prevForm)
        {
            InitializeComponent();
            previousForm = prevForm;
            usuarios = user;
        }
        Usuarios usuarios;
        static Form previousForm;
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnActualizarClave_Click(object sender, EventArgs e)
        {
            IUsuariosDAL usuariosDAL = new UsuariosImplDAL();
            usuarios.contrasena = txbClave.Text;
            usuariosDAL.Update(usuarios);
            showInfo("Su clave de ingreso fue actualizada!");
        }

        private void frmMisDatos_Load(object sender, EventArgs e)
        {
            lvMisDatos.View = View.Details;
            lvMisDatos.Columns.Add("Id");
            lvMisDatos.Columns.Add("Nombre");
            lvMisDatos.Columns.Add("1er Apellido");
            lvMisDatos.Columns.Add("2do Apellido");
            lvMisDatos.Columns.Add("Telefono");
            lvMisDatos.Columns.Add("Email");
            lvMisDatos.Columns.Add("Direccion");
            lvMisDatos.Columns[0].Width = -2;
            lvMisDatos.Columns[1].Width = -2;
            lvMisDatos.Columns[2].Width = -2;
            lvMisDatos.Columns[3].Width = -2;
            lvMisDatos.Columns[4].Width = -2;
            lvMisDatos.Columns[5].Width = -2;
            lvMisDatos.Columns[6].Width = -2;
            string nombre, apellido1, apellido2, idUs, telefono, email, direccion;
            nombre = usuarios.nombre;
            apellido1 = usuarios.apellido1;
            apellido2 = usuarios.apellido2;
            idUs = usuarios.idUsuario.ToString();
            telefono = usuarios.telefono;
            direccion = usuarios.direccion;
            email = usuarios.email;
            string[] listS = { idUs, nombre, apellido1, apellido2, telefono, email, direccion };
            lvMisDatos.Items.Add(new ListViewItem(listS));
        }

        private void showInfo(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }
    }
}
