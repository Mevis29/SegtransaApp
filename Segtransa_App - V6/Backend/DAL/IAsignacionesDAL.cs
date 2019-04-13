using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;

namespace Backend.DAL
{
    public interface IAsignacionesDAL
    {
        /* void Add(THAsignaciones Asignacion);
         void Delete(int idAsignacion);
         void Update(THAsignaciones Asignacion);
         THAsignaciones GetAsignacion(int idAsignacion);
         List<THAsignaciones> GetAsignaciones();
         List<THAsignaciones> GetAsignaciones(int idUsuario);*/
        #region  Método para retornar datos, valores, listas de los SP
        /// <summary>
        /// Método para retornar Asignacion por Usuario-Empleado por Id
        /// </summary>
        spAsignUsuarioRetornaDatosId_Result retornaAsignUsuarioId(int pIdAsignacion);


        /// <summary>
        /// Método para retornar lista completa de Asignaciones por Usuario-Empleado
        /// </summary>
        List<spAsignUsuarioRetornaLista_Result> retornaListaAsignUsuario(string pEmpleado, string pActivo);


        /// <summary>
        /// Método para retornar lista de Asignaciones por Usuario-Empleado por Id
        /// </summary>
        List<spAsignUsuarioRetornaListaId_Result> retornaListaAsignUsuarioId(int pIdUsuario);


        /// <summary>
        /// Método para insertar nueva Asignacion por Usuario-Empleado
        /// </summary>
        /// 
        #endregion

        #region  Método para Mantenimientos

        bool InsertaAsignUsuario(int pIdUsuario, int pIdActivo);


        /// <summary>
        /// Método para modificar Asignacion por Usuario-Empleado existente
        /// </summary>
        bool ModificaAsignUsuario(int pIdAsignacion, int pIdUsuario, int pIdActivo);


        /// <summary>
        /// Método para eliminar Asignacion por Usuario-Empleado existente
        /// </summary>
        bool EliminaAsignUsuario(int pIdAsignacion);

    }
    #endregion
}
