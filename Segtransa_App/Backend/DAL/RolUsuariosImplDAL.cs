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

    public List<Rol_Usuarios> GetRols()
    {
        List<Rol_Usuarios> result;
        using (context = new BDContext())
        {
            result = (from c in context.Rol_Usuarios
                      select c).ToList();
        }
        return result;
    }

    public Rol_Usuarios GetRol(int idRolU)
    {
        Rol_Usuarios result;
        using (context = new BDContext())
        {
            result = (from c in context.Rol_Usuarios
                      where c.idRol == idRolU
                      select c).First();
        }
        return result;
    }

    
}

