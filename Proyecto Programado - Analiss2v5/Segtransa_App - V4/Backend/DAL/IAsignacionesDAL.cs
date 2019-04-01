using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;

namespace Backend.DAL
{
    public interface IAsignacionesDAL : IDisposable
    {
        void Add(THAsignaciones Asignacion);
        void Delete(int idAsignacion);
        void Update(THAsignaciones Asignacion);
        THAsignaciones GetAsignacion(int idAsignacion);
        List<THAsignaciones> GetAsignaciones();
        List<THAsignaciones> GetAsignaciones(int idUsuario);
    }
}
