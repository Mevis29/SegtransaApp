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
    public partial class frmRepActivo : Form
    {
        public frmRepActivo()
        {
            InitializeComponent();
        }

        public frmRepActivo(FormActivosAgregar frmReportes)
        {
            InitializeComponent();
        }

        private void frmRepActivo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SEGTRANSADataSetActivo.Activos' table. You can move, or remove it, as needed.
            this.ActivosTableAdapter.Fill(this.SEGTRANSADataSetActivo.Activos);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
