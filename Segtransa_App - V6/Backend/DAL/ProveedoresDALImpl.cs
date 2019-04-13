using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;

namespace Backend.DAL
{
    public class ProveedoresDALImpl : IProveedoresDAL
    {
        public bool addProveedor(Proveedores proveedores)
        {
            {
                using (BDContext db = new BDContext())
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
                Proveedores p = this.obtenerProveedorPorID(idProveedor);
                using (BDContext db = new BDContext())
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

        public List<Proveedores> obtenerProveedores()
        {
            List<Proveedores> listaproveedores = new List<Proveedores>();
            using (BDContext db = new BDContext())
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

        public Proveedores obtenerProveedorPorID(int idProveedor)
        {
            try
            {
                using (BDContext db = new BDContext())
                {

                    // obtener el proveedor y guardarlo en una variable
                    Proveedores proveedores = (from s in db.Proveedores
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

        public bool updateProveedor(Proveedores proveedores)
        {
            using (BDContext db = new BDContext())
            {
                try
                {
                    // obtener el proveedor a modificar y guardarlo en una variable
                    Proveedores proveedorModificar = db.Proveedores.Single(elproveedor => elproveedor.IdProveedor == proveedores.IdProveedor);

                    // entity framework empieza a 'trackear' los cambios que se estan realizando, por lo que
                    // nada mas hay que cambiar el nombre en el objeto donde guardamos el resultado del query de arriba
                    proveedorModificar.NombreProveedor = proveedores.NombreProveedor;
                    proveedorModificar.Telefono = proveedores.Telefono;
                    proveedorModificar.Correo = proveedores.Correo;
                    proveedorModificar.Direccion = proveedores.Direccion;




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