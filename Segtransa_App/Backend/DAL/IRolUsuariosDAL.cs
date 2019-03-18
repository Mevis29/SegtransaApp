using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;

namespace Backend.DAL
{
    public interface IRolUsuariosDAL : IDisposable
    {
        RolUsuarios GetRol(int idRol);
        List<RolUsuarios> GetRols();
    }
}
