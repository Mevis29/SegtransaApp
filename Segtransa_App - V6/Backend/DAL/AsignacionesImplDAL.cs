using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public class AsignacionesImplDAL : IAsignacionesDAL
    {
        // Crear una instancia del modelo de la BD
        BDContext modeloBD = new BDContext();

        #region Método para retornar Asignacion por Usuario-Empleado por Id
        /// <summary>
        /// Método para retornar Asignacion por Usuario-Empleado por Id
        /// </summary>
        public spAsignUsuarioRetornaDatosId_Result retornaAsignUsuarioId(int pIdAsignacion)
        {
            spAsignUsuarioRetornaDatosId_Result resultado = new spAsignUsuarioRetornaDatosId_Result();

            resultado = this.modeloBD.spAsignUsuarioRetornaDatosId(pIdAsignacion).FirstOrDefault();

            return resultado;
        }
        #endregion

        #region Método para retornar lista completa de Asignacion por Usuario-Empleado

        /// <summary>
        /// Método para retornar lista completa de Asignacions por Usuario-Empleado
        /// </summary>
        public List<spAsignUsuarioRetornaLista_Result> retornaListaAsignUsuario(string pEmpleado, string pActivo)
        {
            List<spAsignUsuarioRetornaLista_Result> resultado = new List<spAsignUsuarioRetornaLista_Result>();

            resultado = this.modeloBD.spAsignUsuarioRetornaLista(pEmpleado, pActivo).ToList();

            return resultado;
        }
        #endregion

        #region Método para retornar lista completa de Asignacion por Usuario-Empleado
        /// <summary>
        /// Método para retornar lista de Asignacions por Usuario-Empleadopor Id
        /// </summary>
        public List<spAsignUsuarioRetornaListaId_Result> retornaListaAsignUsuarioId(int pIdUsuario)
        {
            List<spAsignUsuarioRetornaListaId_Result> resultado = new List<spAsignUsuarioRetornaListaId_Result>();

            resultado = this.modeloBD.spAsignUsuarioRetornaListaId(pIdUsuario).ToList();

            return resultado;
        }

        #endregion

        #region Método para insertar nueva Asignacion por Usuario-Empleado
        /// <summary>
        /// Método para insertar nueva Asignacion por Usuario-Empleado
        /// </summary>
        public bool InsertaAsignUsuario(int pIdUsuario, int pIdActivo)
        {
            bool resultado = false;
            try
            {
                int registrosAfectados = this.modeloBD.spAsignUsuarioInsertaDatos(pIdUsuario, pIdActivo);

                if (registrosAfectados > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        #endregion

        #region  Método para modificar Asignacion por Usuario-Empleado existente
        /// <summary>
        /// Método para modificar Asignacion por Usuario-Empleado existente
        /// </summary>
        public bool ModificaAsignUsuario(int pIdAsignacion, int pIdUsuario, int pIdActivo)
        {
            bool resultado = false;
            try
            {
                int registrosAfectados = this.modeloBD.spAsignUsuarioModificaDatos(pIdAsignacion, pIdUsuario, pIdActivo);

                if (registrosAfectados > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
        #endregion

        #region Método para eliminar Asignacion por Usuario-Empleado existente
        /// <summary>
        /// Método para eliminar Asignacion por Usuario-Empleado existente
        /// </summary>
        public bool EliminaAsignUsuario(int pIdAsignacion)
        {
            bool resultado = false;
            try
            {
                int registrosAfectados = this.modeloBD.spAsignUsuarioEliminaDatos(pIdAsignacion);

                if (registrosAfectados > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
        #endregion
    }
}
