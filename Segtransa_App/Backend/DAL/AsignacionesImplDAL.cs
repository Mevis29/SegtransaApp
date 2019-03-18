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

    public void Add(THAsignaciones Asignacion)
    {
        using (context = new BDContext())
        {
            context.THAsignaciones.Add(Asignacion);
            context.SaveChanges();
        }
    }

    public void Delete(int idAsignacion)
    {
        THAsignaciones Asignacion = this.GetAsignacion(idAsignacion);
        using (context = new BDContext())
        {
            context.THAsignaciones.Attach(Asignacion);
            context.THAsignaciones.Remove(Asignacion);
            context.SaveChanges();
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public List<THAsignaciones> GetAsignaciones()
    {
        List<THAsignaciones> result;
        using (context = new BDContext())
        {
            result = (from c in context.THAsignaciones
                      select c).ToList();
        }
        return result;
    }

    public List<THAsignaciones> GetAsignaciones(int idUsuario)
    {
        List<THAsignaciones> result;
        using (context = new BDContext())
        {
            result = (from c in context.THAsignaciones
                      where c.IdUsuario == idUsuario
                      select c).ToList();
        }
        return result;
    }

    public THAsignaciones GetAsignacion(int idAsignacion)
    {
        THAsignaciones result;
        using (context = new BDContext())
        {
            result = (from c in context.THAsignaciones
                      where c.IdAsignacion == idAsignacion
                      select c).First();
        }
        return result;
    }

    public void Update(THAsignaciones Asignacion)
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

