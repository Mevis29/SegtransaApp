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
        Activo mostrarActivo(int idActivo);
        void agregarActivo(Activo activos);
        void actualizarActivo(Activo activos);
        void eliminarActivo(int idActivo);
        List<Activo> obtenerActivos();
        List<Object> obtenerActivosObjetos();
        List<object> buscarActivos(String busqueda);
    }
}
