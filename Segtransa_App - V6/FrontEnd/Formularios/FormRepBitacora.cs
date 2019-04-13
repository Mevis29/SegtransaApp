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
    public partial class frmRepBitacora : Form
    {
        public frmRepBitacora()
        {
            InitializeComponent();
        }

        public frmRepBitacora(Form frmReportes)
        {
            InitializeComponent();
        }

        private void frmRepBitacora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SEGTRANSADataSetBitacora.Bitacora' table. You can move, or remove it, as needed.
       //     this.BitacoraTableAdapter.Fill(this.SEGTRANSADataSetBitacora.Bitacora);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
