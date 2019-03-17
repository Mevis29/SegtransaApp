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
        void Add(Asignaciones Asignacion);
        void Delete(int idAsignacion);
        void Update(Asignaciones Asignacion);
        Asignaciones GetAsignacion(int idAsignacion);
        List<Asignaciones> GetAsignaciones();
        List<Asignaciones> GetAsignaciones(int idUsuario);
    }
}
