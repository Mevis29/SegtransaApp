using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;
using System.Data.Entity;

public class UsuariosImplDAL : IUsuariosDAL
{

    private BDContext context;

    public void Add(Usuarios Usuario)
    {
        try
        {
            using (context = new BDContext())
            {
                Usuario.RolUsuarios = (from c in context.RolUsuarios
                                        where c.IdRol == Usuario.RolUsuario
                                        select c).First();

                context.Usuarios.Add(Usuario);
                context.SaveChanges();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Delete(int idUsuario)
    {
        Usuarios Usuario = this.GetUsuario(idUsuario);
        using (context = new BDContext())
        {
            context.Usuarios.Attach(Usuario);
            context.Usuarios.Remove(Usuario);
            context.SaveChanges();
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public List<Usuarios> GetUsuarios()
    {
        List<Usuarios> result;
        using (context = new BDContext())
        {
            result = (from c in context.Usuarios
                      select c).ToList();
        }
        return result;
    }

    public Usuarios GetUsuario(int idUsuario)
    {
        try
        {
            Usuarios result;
            using (context = new BDContext())
            {
                result = (from c in context.Usuarios
                          where c.IdUsuario == idUsuario
                          select c).First();
            }
            return result;
        }
        catch (Exception)
        {

            return null;
        }

    }

    public void Update(Usuarios Usuario)
    {
        try
        {
            using (context = new BDContext())
            {
                context.Entry(Usuario).State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        catch (Exception)
        {
            throw;
        }
    }
    public bool isRealUser(int idUsuario)
    {
        bool real = false;
        if (this.GetUsuario(idUsuario) != null)
        {
            real = true;
        }
        return real;
    }
    public bool isValidPassword(string passUser, int idUsuario)
    {
        CryptoEngine cryptoEngine = new CryptoEngine();
        string passDecrypted = cryptoEngine.Decrypt(passUser);
        bool valid = false;
        if (this.GetUsuario(idUsuario).Contrasena.Equals(passDecrypted))
        {
            valid = true;
        }
        return valid;
    }
}

