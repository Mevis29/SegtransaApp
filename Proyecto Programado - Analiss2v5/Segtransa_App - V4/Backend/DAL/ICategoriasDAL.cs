using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
   public interface ICategoriasDAL
    {
        Categorias obtenerCategoriaPorID(int idCategoria);

        bool addCategoria(Categorias categorias);

        bool deleteCategoria(int idCategoria);

        bool updateCategoria(Categorias categorias);

        List<Categorias> obtenerCategorias();
    }
}
