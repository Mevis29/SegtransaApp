using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
   public interface IActivosDAL
    {
        Activos mostrarActivo(int idActivo);
        void agregarActivo(Activos activos);
        void actualizarActivo(Activos activos);
        void eliminarActivo(int idActivo);
       
        List<Activos> obtenerActivos();
        List<Object> obtenerActivosObjetos();
        List<object> buscarActivos(String busqueda);
    }
}
