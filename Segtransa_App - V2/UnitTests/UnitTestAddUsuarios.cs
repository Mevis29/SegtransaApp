using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.DAL;
using Backend.Entities;

namespace UnitTests
{
    [TestClass]
    public class UnitTestAddUsuarios
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            IUsuariosDAL usuariosDAL = new UsuariosImplDAL();
            int count = usuariosDAL.GetUsuarios().Count;

            Usuarios usuario = new Usuarios
            {
                nombre = "Test",
                contrasena = "0000",
                apellido1 = "testApellido",
                apellido2 = "testApellido",
                email = "test@test.com"
            };
            usuariosDAL.Add(usuario);
            Assert.AreEqual(count + 1, usuariosDAL.GetUsuarios().Count);
        }
    }
}