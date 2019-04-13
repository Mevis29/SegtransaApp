using Backend.DAL;
using Backend.Entities;
using FrontEnd.Clases;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Formularios
{
    public partial class frmRepUsuario : Form
    {
        public frmRepUsuario()
        {
            InitializeComponent();
        }
        #region cargar frmReportePolizas
        //Evento pr cargar el formRP
        //Invoca el Mètodo EstablerAccesoRolUsuario 
        //llama y refresca al rpvListaUsuarios

        private void frmRepUsuario_Load(object sender, EventArgs e)
        {
            this.rpvListaUsuarios.RefreshReport();
            this.EstablerAccesoRolUsuario();
        }
#endregion

        #region Evento mnuCerrar
        //Evento salir del form
        private void mnuCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region botòn VerReporte
        //Evento q filtra la busqueda 
        //invoca el Mètodo de GenerarReporte 
        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            this.GenerarReporte();
        }
        #endregion

        #region Mètodo EstablerAccesoRolUsuario
        void EstablerAccesoRolUsuario()
        {
            if (ValoresAplicacion.rolUsuario == "Empleado")
            {
                this.grpFiltrosReporte.Visible = false;
                this.rpvListaUsuarios.Location = new Point(10, 50);
                this.rpvListaUsuarios.Size = new Size(1150, 500);
                this.GenerarReporte();
                //datos obtenidos de Usuarios(Admin y Empleados)
            }
        }
        #endregion

        #region Retornar datos admin o empleado

        /// <summary>
        /// Retornar la fuente de datos para mostrar en el reporte - Admin
        /// </summary>
        List<spUsuariosRetornaLista_Result> retornaDatosReporteAdmin(string pCedula, string pNombre, string pCorreo)
        {

            UsuariosImplDAL usuarioI = new UsuariosImplDAL();

            return usuarioI.retornaListaUsuarios(pCedula, pNombre, pCorreo);
        }

        /// <summary>
        /// Retornar la fuente de datos para mostrar en el reporte - Empleado
        /// </summary>
        List<spUsuariosRetornaListaId_Result> retornaDatosReporteEmpleado(int pIdUsuario)
        {
            UsuariosImplDAL usuarioI = new UsuariosImplDAL();

            return usuarioI.retornaListaUsuarioId(pIdUsuario);
        }

        #endregion

        #region Mètodo GenerarReporte
        /// <summary>
        /// Retornar la fuente de datos para mostrar en el reporte
        /// </summary>
        void GenerarReporte()
        {
            //obtener fuentes de datos del reporte (esto es el DATASET, obtiene el nombre del reporte)
            var infoFuenteDatos = this.rpvListaUsuarios.LocalReport.GetDataSourceNames();

            //limpiar la fuente de datos (por si se genera varias veces)
            rpvListaUsuarios.LocalReport.DataSources.Clear();

            if (ValoresAplicacion.rolUsuario == "Empleado")
            {
                //obtener los datos del reporte Empleado 
                List<spUsuariosRetornaListaId_Result> datosReporte =
                retornaDatosReporteEmpleado(ValoresAplicacion.idUsuario);

                //crear la fuente de datos
                ReportDataSource fuenteDatos = new ReportDataSource();

                //.name=nombre DataSet, .value= store procedure
                fuenteDatos.Name = infoFuenteDatos[0];
                fuenteDatos.Value = datosReporte;

                //agregar fuente de datos al reporte
                this.rpvListaUsuarios.LocalReport.DataSources.Add(fuenteDatos);

                //mostrar los datos en el reporte
                this.rpvListaUsuarios.LocalReport.Refresh();
                this.rpvListaUsuarios.RefreshReport();
            }
            else
            {
                //obtener los datos del reporte Cliente
                List<spUsuariosRetornaLista_Result> datosReporte =
                retornaDatosReporteAdmin(this.txtNombre.Text, this.txtCedula.Text, this.txtCorreo.Text);

                //crear la fuente de datos
                ReportDataSource fuenteDatos = new ReportDataSource();

                //.name=nombre DataSet, .value= store procedure
                fuenteDatos.Name = infoFuenteDatos[0];
                fuenteDatos.Value = datosReporte;

                //agregar fuente de datos al reporte
                this.rpvListaUsuarios.LocalReport.DataSources.Add(fuenteDatos);

                //mostrar los datos en el reporte
                this.rpvListaUsuarios.LocalReport.Refresh();
                this.rpvListaUsuarios.RefreshReport();
            }
        }
        #endregion
    }
}
