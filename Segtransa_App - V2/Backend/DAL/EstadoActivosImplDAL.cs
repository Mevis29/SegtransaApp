using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public class EstadoActivosImplDAL : IEstadoActivosDAL
    {
        public bool addEstadoActivos(EstadoActivo estadoActivos)
        {
            {
                using (DBContext db = new DBContext())
                {
                    try
                    {
                        // agregar un nuevo estadoActivo
                        db.EstadoActivos.Add(estadoActivos);
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
        public bool deleteEstadoActivos(int idEstadoActivo)
        {
            {
                EstadoActivo e = this.obtenerEstadoActivosPorID(idEstadoActivo);
                using (DBContext db = new DBContext())
                {
                    try
                    {
                        // remover de la tabla de EstadoActivos el estadoActivo que tenga el ID que se envio
                        db.EstadoActivos.Attach(e);
                        db.EstadoActivos.Remove(e);

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

        public List<EstadoActivo> obtenerEstadoActivos()
        {
            List<EstadoActivo> listaEstadoActivos = new List<EstadoActivo>();
            using (DBContext db = new DBContext())
            {
                listaEstadoActivos = (from EstadoActivos in db.EstadoActivos
                                      select EstadoActivos).ToList();
                if (listaEstadoActivos.Count > 0)
                {
                    return listaEstadoActivos;
                }
                else
                {
                    return null;
                }
            }
        }

        public EstadoActivo obtenerEstadoActivosPorID(int idEstadoActivo)
        {
            try
            {
                using (DBContext db = new DBContext())
                {

                    // obtener el estadoActivo y guardarlo en una variable
                    EstadoActivo estadoActivos = (from s in db.EstadoActivos
                                                   where s.IdEstadoActivo == idEstadoActivo
                                                   select s).First();
                    return estadoActivos;
                }
            }
            catch (System.Exception)
            {

                return null;
            }

        }

        public bool updateEstadoActivos(EstadoActivo estadoActivos)
        {
            using (DBContext db = new DBContext())
            {
                try
                {
                    // obtener el estadoActivo a modificar y guardarlo en una variable
                    EstadoActivo estadoModificar = db.EstadoActivos.Single(elestado => elestado.IdEstadoActivo == estadoActivos.IdEstadoActivo);

                    // entity framework empieza a 'trackear' los cambios que se estan realizando, por lo que
                    // nada mas hay que cambiar el nombre en el objeto donde guardamos el resultado del query de arriba
                    estadoModificar.NombreEstado = estadoActivos.NombreEstado;
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


