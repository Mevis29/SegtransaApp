using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;

namespace Backend.DAL
{
    public interface IActivosDAL : IDisposable
    {
        void Add(Activos Activo);
        void Delete(int idActivo);
        void Update(Activos Activo);
        Activos GetActivo(int idActivo);
        List<Activos> GetActivos();
        int getNextId();
    }
}
