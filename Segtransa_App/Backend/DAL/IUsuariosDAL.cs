using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;

namespace Backend.DAL
{
    public interface IUsuariosDAL : IDisposable
    {
        void Add(Usuarios Usuario);
        void Delete(int idUsuario);
        void Update(Usuarios Usuario);
        Usuarios GetUsuario(int idUsuario);
        List<Usuarios> GetUsuarios();

        /*Metodos necesarios para validar al usuario*/
        bool isRealUser(int idUsuario);
        bool isValidPassword(string passUser, int idUsuario);
    }
}
