using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
  public interface ICategoriaDAL
    {
        Categoria obtenerCategoriaPorID(int idCategoria);

        bool addCategoria(Categoria categorias);

        bool deleteCategoria(int idCategoria);

        bool updateCategoria(Categoria categorias);

        List<Categoria> obtenerCategorias();
    }
}
