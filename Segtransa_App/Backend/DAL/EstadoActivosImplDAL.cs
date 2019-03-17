using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;
using System.Data.Entity;

public class EstadoActivosImplDAL : IEstadoActivosDAL
{

    private BDContext context;

    public void Add(EstadoActivos EstadoActivo)
    {
        using (context = new BDContext())
        {
            context.EstadoActivos.Add(EstadoActivo);
            context.SaveChanges();
        }
    }

    public void Delete(int idEstadoActivo)
    {
        EstadoActivos EstadoActivo = this.GetEstadoActivo(idEstadoActivo);
        using (context = new BDContext())
        {
            context.EstadoActivos.Attach(EstadoActivo);
            context.EstadoActivos.Remove(EstadoActivo);
            context.SaveChanges();
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public List<EstadoActivos> GetEstadoActivos()
    {
        List<EstadoActivos> result;
        using (context = new BDContext())
        {
            result = (from c in context.EstadoActivos
                      select c).ToList();
        }
        return result;
    }

    public EstadoActivos GetEstadoActivo(int idEstadoActivo)
    {
        EstadoActivos result;
        using (context = new BDContext())
        {
            result = (from c in context.EstadoActivos
                      where c.idEstadoActivo == idEstadoActivo
                      select c).First();
        }
        return result;
    }

    public void Update(EstadoActivos EstadoActivo)
    {
        try
        {
            using (context = new BDContext())
            {
                context.Entry(EstadoActivo).State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        catch (Exception)
        {
            throw;
        }
    }
}

