using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;
using System.Data.Entity;

public class AsignacionesImplDAL : IAsignacionesDAL
{

    private BDContext context;

    public void Add(Asignaciones Asignacion)
    {
        using (context = new BDContext())
        {
            context.Asignaciones.Add(Asignacion);
            context.SaveChanges();
        }
    }

    public void Delete(int idAsignacion)
    {
        Asignaciones Asignacion = this.GetAsignacion(idAsignacion);
        using (context = new BDContext())
        {
            context.Asignaciones.Attach(Asignacion);
            context.Asignaciones.Remove(Asignacion);
            context.SaveChanges();
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public List<Asignaciones> GetAsignaciones()
    {
        List<Asignaciones> result;
        using (context = new BDContext())
        {
            result = (from c in context.Asignaciones
                      select c).ToList();
        }
        return result;
    }

    public List<Asignaciones> GetAsignaciones(int idUsuario)
    {
        List<Asignaciones> result;
        using (context = new BDContext())
        {
            result = (from c in context.Asignaciones
                      where c.idUsuario == idUsuario
                      select c).ToList();
        }
        return result;
    }

    public Asignaciones GetAsignacion(int idAsignacion)
    {
        Asignaciones result;
        using (context = new BDContext())
        {
            result = (from c in context.Asignaciones
                      where c.idAsignacion == idAsignacion
                      select c).First();
        }
        return result;
    }

    public void Update(Asignaciones Asignacion)
    {
        try
        {
            using (context = new BDContext())
            {
                context.Entry(Asignacion).State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        catch (Exception)
        {
            throw;
        }
    }
}

