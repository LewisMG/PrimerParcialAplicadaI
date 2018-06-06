using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimerParcial.BLL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial.BLL.Tests
{
    [TestClass()]
    public class GruposBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Grupos grupo = new Grupos();
            grupo.Descripcion = "Master";
            grupo.Cantidad = 30;
            grupo.GruposDeseados = 4;
            grupo.Integrantes = 10;
            paso = GruposBLL.Guardar(grupo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Grupos grupo = new Grupos();
            grupo.GrupoId = 8;
            grupo.Descripcion = "Super";
            grupo.Cantidad = 30;
            grupo.GruposDeseados = 4;
            grupo.Integrantes = 10;
            paso = GruposBLL.Modificar(grupo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = GruposBLL.Eliminar(4);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Grupos grupo = new Grupos();
            grupo = GruposBLL.Buscar(8);
            Assert.IsNotNull(grupo);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var Lista = GruposBLL.GetList(x => true);
            Assert.IsNotNull(Lista);
        }
    }
}