using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public class ProveedoresImplDAL : IProveedoresDAL
    {
        public bool addProveedor(Proveedore proveedores)
        {
            {
                using (DBContext db = new DBContext())
                {
                    try
                    {
                        // agregar un nuevo proveedor
                        db.Proveedores.Add(proveedores);
                        // guardar los cambios
                        db.SaveChanges();
                        return true;
                    }
                    catch (SqlException)
                    {
                        return false;
                    }
                }
            }
        }

        public bool deleteProveedor(int idProveedor)
        {
            {
                Proveedore p = this.obtenerProveedorPorID(idProveedor);
                using (DBContext db = new DBContext())
                {
                    try
                    {
                        // remover de la tabla de proveedores el proveedor que tenga el ID que se envio
                        db.Proveedores.Attach(p);
                        db.Proveedores.Remove(p);

                        // salvar los cambios
                        db.SaveChanges();
                        return true;
                    }
                    catch (SqlException)
                    {
                        return false;
                    }
                }
            }
        }

        public List<Proveedore> obtenerProveedores()
        {
            List<Proveedore> listaproveedores = new List<Proveedore>();
            using (DBContext db = new DBContext())
            {
                listaproveedores = (from Proveedores in db.Proveedores
                                    select Proveedores).ToList();
                if (listaproveedores.Count > 0)
                {
                    return listaproveedores;
                }
                else
                {
                    return null;
                }
            }
        }

        public Proveedore obtenerProveedorPorID(int idProveedor)
        {
            try
            {
                using (DBContext db = new DBContext())
                {

                    // obtener el proveedor y guardarlo en una variable
                    Proveedore proveedores = (from s in db.Proveedores
                                               where s.IdProveedor == idProveedor
                                               select s).First();
                    return proveedores;
                }
            }
            catch (System.Exception)
            {

                return null;
            }

        }

        public bool updateProveedor(Proveedore proveedores)
        {
            using(DBContext db = new DBContext())
            {
                try
                {
                    // obtener el proveedor a modificar y guardarlo en una variable
                    Proveedore proveedorModificar = db.Proveedores.Single(elproveedor => elproveedor.IdProveedor == proveedores.IdProveedor);

                    // entity framework empieza a 'trackear' los cambios que se estan realizando, por lo que
                    // nada mas hay que cambiar el nombre en el objeto donde guardamos el resultado del query de arriba
                    proveedorModificar.NombreProveedor = proveedores.NombreProveedor;
                    proveedorModificar.TelefonoProv = proveedores.TelefonoProv;
                    proveedorModificar.CorreoProv = proveedores.CorreoProv;
                    proveedorModificar.DireccionProv = proveedores.DireccionProv;




                    // salvar los cambios
                    db.SaveChanges();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
