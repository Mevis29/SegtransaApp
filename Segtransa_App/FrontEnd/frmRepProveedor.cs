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
    public partial class frmRepProveedor : Form
    {
        public frmRepProveedor()
        {
            InitializeComponent();
        }

        public frmRepProveedor(frmReportes frmReportes)
        {
            InitializeComponent();
        }

        private void frmRepProveedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SEGTRANSADataSetProveedor.Proveedores' table. You can move, or remove it, as needed.
            this.ProveedoresTableAdapter.Fill(this.SEGTRANSADataSetProveedor.Proveedores);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
