using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Entities;
using Backend.DAL;

namespace FrontEnd
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }
        
        public frmReportes(Form prevForm)
        {
            InitializeComponent();
            previousForm = prevForm;
        }

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

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }

        private void btnRepActivo_Click(object sender, EventArgs e)
        {
            frmRepActivo frmRepActivo = new frmRepActivo(this);
            frmRepActivo.Show(this);            
        }

        private void btnRepBitacora_Click(object sender, EventArgs e)
        {
            frmRepBitacora frmRepBitacora = new frmRepBitacora(this);
            frmRepBitacora.Show(this);
        }

        private void btnRepProveedor_Click(object sender, EventArgs e)
        {
            frmRepProveedor frmRepProveedor = new frmRepProveedor(this);
            frmRepProveedor.Show(this);
        }

        private void btnRepRolUsuario_Click(object sender, EventArgs e)
        {
            frmRepRolUsuario frmRepRolUsuario = new frmRepRolUsuario(this);
            frmRepRolUsuario.Show(this);
        }

        private void btnRepUsuario_Click(object sender, EventArgs e)
        {
            frmRepUsuario frmRepUsuario = new frmRepUsuario(this);
            frmRepUsuario.Show(this);
        }
    }
}
