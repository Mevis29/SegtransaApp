using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public class CategoriaImplDAL : ICategoriaDAL
    {
        public bool addCategoria(Categoria categorias)
        {
            {
                using (DBContext db = new DBContext())
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
        Categoria c = this.obtenerCategoriaPorID(idCategoria);
        using (DBContext db= new DBContext())
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

public Categoria obtenerCategoriaPorID(int idCategoria)
{
    try
    {
        using (DBContext db = new DBContext())
        {

            // obtener la categoria y guardarlo en una variable
            Categoria categorias = (from s in db.Categorias
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

public List<Categoria> obtenerCategorias()
{
    List<Categoria> listaCategorias = new List<Categoria>();
    using (DBContext db = new DBContext())
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

public bool updateCategoria(Categoria categorias)
{
            using (DBContext db = new DBContext())
            {
        try
        {
            // obtener la categoria a modificar y guardarlo en una variable
            Categoria categoriaModificar = db.Categorias.Single(laCategoria => laCategoria.IdCategoria == categorias.IdCategoria);

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

