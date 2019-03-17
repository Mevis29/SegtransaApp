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
    public partial class frmRepUsuario : Form
    {
        public frmRepUsuario()
        {
            InitializeComponent();
        }

        public frmRepUsuario(frmReportes frmReportes)
        {
            InitializeComponent();
        }

        private void frmRepUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SEGTRANSADataSetUsuarios.Usuarios' table. You can move, or remove it, as needed.
            this.UsuariosTableAdapter.Fill(this.SEGTRANSADataSetUsuarios.Usuarios);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
