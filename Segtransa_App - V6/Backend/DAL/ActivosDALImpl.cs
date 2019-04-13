using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Entities;

namespace Backend.DAL
{
    public class ActivosDALImpl : IActivosDAL
    {
        BDContext activosDB;


        public ActivosDALImpl()
        {

        }


        public void actualizarActivo(Activos activos)
        {
            using (activosDB = new BDContext())
            {
                // obtener el activo a modificar y guardarlo en una variable
                Activos activoModificar = activosDB.Activos.Single(elActivo => elActivo.IdActivo == activos.IdActivo);

                // entity framework empieza a 'trackear' los cambios que se estan realizando, por lo que
                // nada mas hay que cambiar el nombre en el objeto donde guardamos el resultado del query de arriba
                activoModificar.CodActivo = activos.CodActivo;
                activoModificar.Categoria = activos.Categoria;
                activoModificar.Descripcion = activos.Descripcion;
                activoModificar.PrecioInicial = activos.PrecioInicial;
                activoModificar.PrecioActual = activos.PrecioActual;
                activoModificar.FechaCompra = activos.FechaCompra;
                activoModificar.Proveedor = activos.Proveedor;
                activoModificar.EstadoActivo = activos.EstadoActivo;
                activoModificar.Garantia = activos.Garantia;
                
                // salvar los cambios
                activosDB.SaveChanges();


            }
        }

        public void agregarActivo(Activos activos)
        {
            try
            {
                using (activosDB = new BDContext())
                {

                    activosDB.Activos.Add(activos);
                    activosDB.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("hola" + ex);

            }
        }

        public List<object> buscarActivos(string busqueda)
        {
            using(activosDB = new BDContext())
            {
                List<object> activos = activosDB.sp_BuscarActivos(busqueda).ToList<object>();
                if (activos.Count > 0)
                {
                    return activos;
                }
                else
                {
                    return null;
                }
            }
        }

        public void eliminarActivo(int idActivo)
        {
            using (activosDB = new BDContext())
            {
                activosDB.Activos.Remove(activosDB.Activos.Single(elActivo => elActivo.IdActivo == idActivo));
                activosDB.SaveChanges();
            }
        }

      




        public Activos mostrarActivo(int idActivo)
        {
            using (activosDB = new BDContext())
            {
                return activosDB.Activos.Single(elActivo => elActivo.IdActivo == idActivo);
            }
        }

        public List<Activos> obtenerActivos()
        {
             List<Activos> listaActivos = new List<Activos>();
            using(BDContext db = new BDContext())
            {
                listaActivos = (from Activos in db.Activos
                                  select Activos).ToList();
                if(listaActivos.Count > 0)
                {
                    return listaActivos;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<object> obtenerActivosObjetos()
        {
            using (BDContext db = new BDContext())
            {
                var listaActivos = (from activos in db.Activos
                                      join Proveedores in db.Proveedores on activos.Proveedor equals Proveedores.IdProveedor 
                                      join EstadoActivos in db.EstadoActivos on activos.EstadoActivo equals EstadoActivos.IdEstadoActivo                                      
                                      select new
                                      {
                                          Id = activos.IdActivo,
                                          CodActivo = activos.CodActivo,
                                          Descripcion = activos.Descripcion,
                                          PrecioInicial = activos.PrecioInicial,
                                          FechaCompra = activos.FechaCompra,
                                          Proveedor = Proveedores.NombreProveedor,
                                          Estado = EstadoActivos.NombreEstado
                                      }
                                  ).ToList<Object>();
                if (listaActivos.Count > 0)
                {
                    return listaActivos;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
