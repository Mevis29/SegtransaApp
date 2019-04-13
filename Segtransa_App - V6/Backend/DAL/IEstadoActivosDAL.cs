using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
   public interface IEstadoActivosDAL
    {
        EstadoActivos obtenerEstadoActivosPorID(int idEstadoActivo);

        bool addEstadoActivos(EstadoActivos estadoActivos);

        bool deleteEstadoActivos(int idEstadoActivo);

        bool updateEstadoActivos(EstadoActivos estadoActivos);

        List<EstadoActivos> obtenerEstadoActivos();
    }
}
