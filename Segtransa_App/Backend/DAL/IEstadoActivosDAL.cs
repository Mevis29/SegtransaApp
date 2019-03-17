using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;

namespace Backend.DAL
{
    public interface IEstadoActivosDAL : IDisposable
    {
        void Add(EstadoActivos EstadoActivo);
        void Delete(int idEstadoActivo);
        void Update(EstadoActivos EstadoActivo);
        EstadoActivos GetEstadoActivo(int idEstadoActivo);
        List<EstadoActivos> GetEstadoActivos();
    }
}
