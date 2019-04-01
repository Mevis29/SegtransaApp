using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
   public interface IProveedoresDAL
    {
        Proveedores obtenerProveedorPorID(int idProveedor);

        bool addProveedor(Proveedores proveedores);

        bool deleteProveedor(int idProveedor);

        bool updateProveedor(Proveedores proveedores);

        List<Proveedores> obtenerProveedores();
    }
}
