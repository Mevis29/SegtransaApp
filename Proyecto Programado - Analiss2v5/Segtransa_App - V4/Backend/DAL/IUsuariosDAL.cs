using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;

namespace Backend.DAL
{
   public interface IUsuariosDAL
    {

       #region Métodos para retornar datos y listas de lo SP
        /// <summary>
        /// Método para comprobar los datos de login del Usuario
        /// </summary>
        spUsuariosRetornaDatosLogin_Result retornaDatosLogin(string pCorreo, string pContrasena);


        /// <summary>
        /// Método para actualizar fecha/hora de login del Usuario
        /// </summary>
        bool actualizaDatosLogin(int IdUsuario);


        /// <summary>
        /// Método para retornar Usuario por Id
        /// </summary>
        spUsuariosRetornaDatosId_Result retornaUsuarioId(int pIdUsuario);


        /// <summary>
        /// Método para retornar lista completa de Usuarios
        /// </summary>
        List<spUsuariosRetornaLista_Result> retornaListaUsuarios(string pCedula, string pNombre, string pCorreo);


        /// <summary>
        /// Método para retornar lista de Usuario por Id
        /// </summary>
        List<spUsuariosRetornaListaId_Result> retornaListaUsuarioId(int pIdUsuario);


        /// <summary>
        /// Método para retornar lista de solo Empleados asignados
        /// </summary>
        List<spUsuariosRetornaListaEmpleado_Result> retornaListaEmpleados(int? pIdEmpleado);


        /// <summary>
        /// Método para retornar Empleado por Id
        /// </summary>
        spUsuariosRetornaListaEmpleado_Result retornaEmpleadoId(int pIdEmpleado);


        /// <summary>
        /// Método para retornar lista de estados de Usuario
        /// </summary>
        List<spEstadoUsuariosRetornaLista_Result> retornaListaEstadosUsuario();


        /// <summary>
        /// Método para retornar lista de roles de Usuario
        /// </summary>
        List<spRolesRetornaLista_Result> retornaListaRolesUsuario();
        #endregion

        #region Métodos para Mantenimientos
        /// <summary>
        /// Método para insertar nuevo Usuario
        /// </summary>
        bool InsertaUsuario(string pNombre, string pApellido, int pEstado, int pRol, int pCedula, string pContrasena,
       string pTelefono, string pCorreo, string pDireccion, DateTime pFechaCreacion);


        /// <summary>
        /// Método para modificar Usuario existente
        /// </summary>
        bool ModificaUsuario(string pNombre, string pApellido, int pEstado, int pRol, int pCedula, string pContrasena,
       string pTelefono, string pCorreo, string pDireccion, DateTime pFechaCreacion);


        /// <summary>
        /// Método para eliminar Usuario existente
        /// </summary>
        bool EliminaUsuario(int IdUsuario);

    }
    #endregion
}
