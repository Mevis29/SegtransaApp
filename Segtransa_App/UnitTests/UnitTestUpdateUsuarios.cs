using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTestUpdateUsuarios
    {
        [TestMethod]
        public void TestMethodUpdate()
        {
            IUsuariosDAL usuariosDAL = new UsuariosImplDAL();
            int count = usuariosDAL.GetUsuarios().Count;

            Usuarios usuario = usuariosDAL.GetUsuario(3);
            usuario.nombre = "NombreTest";
           
            usuariosDAL.Update(usuario);
            Assert.AreEqual("NombreTest", usuariosDAL.GetUsuario(3).nombre);
        }
    }
}
