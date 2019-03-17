using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;

namespace Backend.DAL
{
    public interface IProveedoresDAL : IDisposable
    {
        void Add(Proveedores Proveedor);
        void Delete(int idProveedor);
        void Update(Proveedores Proveedor);
        Proveedores GetProveedor(int idProveedor);
        List<Proveedores> GetProveedores();
    }
}
