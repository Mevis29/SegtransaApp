using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backend.DAL
{
  public  class ActivosImplDAL : IActivosDAL
    { 
    DBContext activosDB;


        public ActivosImplDAL()
    {

    }


    public void actualizarActivo(Activo activos)
    {
        using (activosDB = new DBContext())
        {
            // obtener el activo a modificar y guardarlo en una variable
            Activo activoModificar = activosDB.Activos.Single(elActivo => elActivo.IdActivo == activos.IdActivo);

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

    public void agregarActivo(Activo activos)
    {
        try
        {
            using (activosDB = new DBContext())
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
        using (activosDB = new DBContext())
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
        using (activosDB = new DBContext())
        {
            activosDB.Activos.Remove(activosDB.Activos.Single(elActivo => elActivo.IdActivo == idActivo));
            activosDB.SaveChanges();
        }
    }

    public Activo mostrarActivo(int idActivo)
    {
        using (activosDB = new DBContext())
        {
            return activosDB.Activos.Single(elActivo => elActivo.IdActivo == idActivo);
        }
    }

    public List<Activo> obtenerActivos()
    {
        List<Activo> listaActivos = new List<Activo>();
        using (DBContext db = new DBContext())
        {
            listaActivos = (from Activos in db.Activos
                            select Activos).ToList();
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

    public List<object> obtenerActivosObjetos()
    {
        using (DBContext db = new DBContext())
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
