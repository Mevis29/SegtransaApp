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
          
        EstadoActivo obtenerEstadoActivosPorID(int idEstadoActivo);

        bool addEstadoActivos(EstadoActivo estadoActivos);

        bool deleteEstadoActivos(int idEstadoActivo);

        bool updateEstadoActivos(EstadoActivo estadoActivos);

        List<EstadoActivo> obtenerEstadoActivos();
    
}
}
