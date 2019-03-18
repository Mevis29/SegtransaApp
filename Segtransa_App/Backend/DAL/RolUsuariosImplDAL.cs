using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;
using System.Data.Entity;

public class RolUsuariosImplDAL : IRolUsuariosDAL
{

    private BDContext context;

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public List<RolUsuarios> GetRols()
    {
        List<RolUsuarios> result;
        using (context = new BDContext())
        {
            result = (from c in context.RolUsuarios
                      select c).ToList();
        }
        return result;
    }

    public RolUsuarios GetRol(int idRolU)
    {
        RolUsuarios result;
        using (context = new BDContext())
        {
            result = (from c in context.RolUsuarios
                      where c.IdRol == idRolU
                      select c).First();
        }
        return result;
    }

    
}

