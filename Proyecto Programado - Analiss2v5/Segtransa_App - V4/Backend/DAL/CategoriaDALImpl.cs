using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;

namespace Backend.DAL
{
    public class CategoriaDALImpl : ICategoriasDAL
    {
        public bool addCategoria(Categorias categorias)
        {
            {
                using (BDContext db = new BDContext())
                {
                    try
                    {
                        // agregar una nueva  categoria
                        db.Categorias.Add(categorias);
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
        public bool deleteCategoria(int idCategoria)
        {
            {
                Categorias c = this.obtenerCategoriaPorID(idCategoria);
                using (BDContext db = new BDContext())
                {
                    try
                    {
                        // remover de la tabla de Categorias la categoria que tenga el ID que se envio
                        db.Categorias.Attach(c);
                        db.Categorias.Remove(c);

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

        public Categorias obtenerCategoriaPorID(int idCategoria)
        {
            try
            {
                using (BDContext db = new BDContext())
                {

                    // obtener la categoria y guardarlo en una variable
                    Categorias categorias = (from s in db.Categorias
                                                   where s.IdCategoria == idCategoria
                                                   select s).First();
                    return categorias;
                }
            }
            catch (System.Exception)
            {

                return null;
            }

        }

        public List<Categorias> obtenerCategorias()
        {
            List<Categorias> listaCategorias = new List<Categorias>();
            using (BDContext db = new BDContext())
            {
                listaCategorias = (from Categorias in db.Categorias
                                      select Categorias).ToList();
                if (listaCategorias.Count > 0)
                {
                    return listaCategorias;
                }
                else
                {
                    return null;
                }
            }
        }

        public bool updateCategoria(Categorias categorias)
        {
            using (BDContext db = new BDContext())
            {
                try
                {
                    // obtener la categoria a modificar y guardarlo en una variable
                    Categorias categoriaModificar = db.Categorias.Single(laCategoria => laCategoria.IdCategoria == categorias.IdCategoria);

                    // entity framework empieza a 'trackear' los cambios que se estan realizando, por lo que
                    // nada mas hay que cambiar el nombre en el objeto donde guardamos el resultado del query de arriba
                    categoriaModificar.Descripcion = categorias.Descripcion;
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
