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
    public partial class frmRepRolUsuario : Form
    {
        public frmRepRolUsuario()
        {
            InitializeComponent();
        }

        public frmRepRolUsuario(frmReportes frmReportes)
        {
            InitializeComponent();
        }

        private void frmRepRolUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SEGTRANSADataSetRolUsuario.Rol_Usuarios' table. You can move, or remove it, as needed.
            this.Rol_UsuariosTableAdapter.Fill(this.SEGTRANSADataSetRolUsuario.Rol_Usuarios);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
