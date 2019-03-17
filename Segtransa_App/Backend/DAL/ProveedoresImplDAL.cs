using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;
using System.Data.Entity;

public class ProveedoresImplDAL : IProveedoresDAL
{

    private BDContext context;

    public void Add(Proveedores Proveedor)
    {
        using (context = new BDContext())
        {
            context.Proveedores.Add(Proveedor);
            context.SaveChanges();
        }
    }

    public void Delete(int idProveedor)
    {
        Proveedores Proveedor = this.GetProveedor(idProveedor);
        using (context = new BDContext())
        {
            context.Proveedores.Attach(Proveedor);
            context.Proveedores.Remove(Proveedor);
            context.SaveChanges();
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public List<Proveedores> GetProveedores()
    {
        List<Proveedores> result;
        using (context = new BDContext())
        {
            result = (from c in context.Proveedores
                      select c).ToList();
        }
        return result;
    }

    public Proveedores GetProveedor(int idProveedor)
    {
        Proveedores result;
        using (context = new BDContext())
        {
            result = (from c in context.Proveedores
                      where c.idProveedor == idProveedor
                      select c).First();
        }
        return result;
    }

    public void Update(Proveedores Proveedor)
    {
        try
        {
            using (context = new BDContext())
            {
                context.Entry(Proveedor).State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        catch (Exception)
        {
            throw;
        }
    }
}

