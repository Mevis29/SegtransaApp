using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public class UsuariosImplDAL : IUsuariosDAL
    {
        // Crear una instancia del modelo de la BD
        BDContext Segtransa = new BDContext();

        #region Método para comprobar los datos de login del Usuario
        /// <summary>
        /// Método para comprobar los datos de login del Usuario
        /// </summary>
        public spUsuariosRetornaDatosLogin_Result retornaDatosLogin(string pCorreo, string pContrasena)
        {
            //crear la variable que retorna la funcion
            spUsuariosRetornaDatosLogin_Result resultado = new spUsuariosRetornaDatosLogin_Result();

            ///invocar SP y asignar valor a la variable
            resultado = this.Segtransa.spUsuariosRetornaDatosLogin(pCorreo, pContrasena).FirstOrDefault();

            return resultado;
        }
        #endregion

        #region Método para actualizar fecha/hora de login del Usuario
        /// <summary>
        /// Método para actualizar fecha/hora de login del Usuario
        /// Mostrara la ultm fecha de ingreso en un mensj  
        /// </summary>
        public bool actualizaDatosLogin(int pIdUsuario)
        {
            bool resultado = false;
            try
            {
                int registrosAfectados = Segtransa.spUsuariosActualizaUltLogin(pIdUsuario);

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

        #region Método para retornar Usuario por Id
        /// <summary>
        /// Método para retornar Usuario por Id
        /// </summary>
        public spUsuariosRetornaDatosId_Result retornaUsuarioId(int pIdUsuario)
        {
            spUsuariosRetornaDatosId_Result resultado = new spUsuariosRetornaDatosId_Result();

            resultado = this.Segtransa.spUsuariosRetornaDatosId(pIdUsuario).FirstOrDefault();

            return resultado;
        }
        #endregion

        #region  Método para retornar lista completa de Usuarios

        /// <summary>
        /// Método para retornar lista completa de Usuarios
        /// </summary>
        public List<spUsuariosRetornaLista_Result> retornaListaUsuarios(string pCedula, string pNombre, string pCorreo)
        {

            List<spUsuariosRetornaLista_Result> resultado = new List<spUsuariosRetornaLista_Result>();

            resultado = this.Segtransa.spUsuariosRetornaLista(pCedula, pNombre, pCorreo).ToList();

            return resultado;
        }
        #endregion

        #region Método para retornar lista de Usuario por Id

        /// <summary>
        /// Método para retornar lista de Usuario por Id
        /// </summary>
        public List<spUsuariosRetornaListaId_Result> retornaListaUsuarioId(int pIdUsuario)
        {
            List<spUsuariosRetornaListaId_Result> resultado = new List<spUsuariosRetornaListaId_Result>();

            resultado = this.Segtransa.spUsuariosRetornaListaId(pIdUsuario).ToList();

            return resultado;
        }
        #endregion

        #region Método para retornar lista de solo Empleados asignados
        /// <summary>
        /// Método para retornar lista de solo empleados asignados
        /// </summary>
        public List<spUsuariosRetornaListaEmpleado_Result> retornaListaEmpleados(int? pIdEmpleado)
        {
            List<spUsuariosRetornaListaEmpleado_Result> resultado = new List<spUsuariosRetornaListaEmpleado_Result>();

            resultado = this.Segtransa.spUsuariosRetornaListaEmpleado(pIdEmpleado).ToList();

            return resultado;
        }
        #endregion

        #region Método para retornar Empleado por Id

        /// <summary>
        /// Método para retornar Empleado por Id
        /// </summary>
        public spUsuariosRetornaListaEmpleado_Result retornaEmpleadoId(int pIdEmpleado)
        {
            spUsuariosRetornaListaEmpleado_Result resultado = new spUsuariosRetornaListaEmpleado_Result();

            resultado = this.Segtransa.spUsuariosRetornaListaEmpleado(pIdEmpleado).FirstOrDefault();

            return resultado;
        }
        #endregion

        #region Método para retornar lista de estados de Usuario

        /// <summary>
        /// Método para retornar lista de estados de Usuario
        /// </summary>
        public List<spEstadoUsuariosRetornaLista_Result> retornaListaEstadosUsuario()
        {
            List<spEstadoUsuariosRetornaLista_Result> resultado = new List<spEstadoUsuariosRetornaLista_Result>();

            resultado = this.Segtransa.spEstadoUsuariosRetornaLista().ToList();

            return resultado;
        }
        #endregion

        #region Método para retornar lista de roles de Usuario
        /// <summary>
        /// Método para retornar lista de roles de Usuario
        /// </summary>
        public List<spRolesRetornaLista_Result> retornaListaRolesUsuario()
        {
            List<spRolesRetornaLista_Result> resultado = new List<spRolesRetornaLista_Result>();

            resultado = this.Segtransa.spRolesRetornaLista().ToList();

            return resultado;
        }
        #endregion

        #region Método para insertar nuevo Usuario
        /// <summary>
        /// Método para insertar nuevo Usuario
        /// </summary>
        public bool InsertaUsuario(string pNombre, string pApellido, int pEstado, int pRol, int pCedula, string pContrasena,
       string pTelefono, string pCorreo, string pDireccion, DateTime pFechaCreacion)
        {
            bool resultado = false;
            try
            {
                int registrosAfectados = this.Segtransa.spUsuariosInsertaDatos(pNombre, pApellido, pEstado, pRol, pCedula, pContrasena,
       pTelefono, pCorreo, pDireccion, pFechaCreacion);

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

        #region Método para modificar Usuario existente
        /// <summary>
        /// Método para modificar Usuario existente
        /// </summary>
        public bool ModificaUsuario(string pNombre, string pApellido, int pEstado, int pRol, int pCedula, string pContrasena,
       string pTelefono, string pCorreo, string pDireccion, DateTime pFechaCreacion)
        {
            bool resultado = false;
            try
            {
          //      int registrosAfectados = this.Segtransa.spUsuariosModificaDatos(pNombre, pApellido, pEstado, pRol, pCedula, pContrasena,
     // pTelefono, pCorreo, pDireccion, pFechaCreacion);

         //       if (registrosAfectados > 0)
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

        #region Método para eliminar Usuario existente
        /// <summary>
        /// Método para eliminar Usuario existente
        /// </summary>
        public bool EliminaUsuario(int IdUsuario)
        {
            bool resultado = false;
            try
            {
                int registrosAfectados = Segtransa.spUsuariosEliminaDatos(IdUsuario);

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
