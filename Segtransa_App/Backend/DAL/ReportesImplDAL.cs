using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;
using System.Data.Entity;

/*
public class ReportesImplDAL : IReportesDAL
{

   private BDContext context;

  public void Add(Reportes Reporte)
   {
       using (context = new BDContext())
       {
           context.Reportes.Add(Reporte);
           context.SaveChanges();
       }
   }

   public void Delete(int idReporte)
   {
       Reportes Reporte = this.GetReporte(idReporte);
       using (context = new BDContext())
       {
           context.Reportes.Attach(Reporte);
           context.Reportes.Remove(Reporte);
           context.SaveChanges();
       }
   }

   public void Dispose()
   {
       throw new NotImplementedException();
   }

   public List<Reportes> GetReportes()
   {
       List<Reportes> result;
       using (context = new BDContext())
       {
           result = (from c in context.Reportes
                     select c).ToList();
       }
       return result;
   }

   public Reportes GetReporte(int idReporte)
   {
       Reportes result;
       using (context = new BDContext())
       {
           result = (from c in context.Reportes
                     where c.idReporte == idReporte
                     select c).First();
       }
       return result;
   }

   public void Update(Reportes Reporte)
   {
       try
       {
           using (context = new BDContext())
           {
               context.Entry(Reporte).State = EntityState.Modified;
               context.SaveChanges();
           }

       }
       catch (Exception)
       {
           throw;
       }
   } 
}
*/
