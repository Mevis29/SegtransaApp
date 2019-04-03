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
        Proveedore obtenerProveedorPorID(int idProveedor);

        bool addProveedor(Proveedore proveedores);

        bool deleteProveedor(int idProveedor);

        bool updateProveedor(Proveedore proveedores);

        List<Proveedore> obtenerProveedores();
    }
}
