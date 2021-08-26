using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.Tests
{
   [TestClass]
    public class TestInventario
    {
        [TestMethod]
        public void CalcularImpuesto()
        {
            //Arrange
            Model.Producto Subtotal = new Model.Producto();
            Subtotal.Subtotal = 1000;

            decimal Resultado = 130;
            //Act
            Business.GestorDeInventario gestorDeInventario = new Business.GestorDeInventario();
            decimal actual = gestorDeInventario.CalcularImpuesto(Subtotal);
            //Assert
            Assert.AreEqual(Resultado, actual);
        }
        [TestMethod]
        public void CalcularMontototal()
        {
            //Arrange
            Model.Producto prueba = new Model.Producto();
            prueba.Subtotal = 1000;
            prueba.IVA = 130;

            decimal Resultado = 1130;
            //Act
            Business.GestorDeInventario gestorDeInventario = new Business.GestorDeInventario();
            decimal actual = gestorDeInventario.CalcularMontototal(prueba);
            //Assert
            Assert.AreEqual(Resultado, actual);
        }
        [TestMethod]
        public void CalcularSubtotal()
        {
            //Arrange
            Model.Producto prueba = new Model.Producto();
            prueba.Cantidad = 2;
            prueba.PrecioUnitario = 1000;

            decimal Resultado = 2000;
            //Act
            Business.GestorDeInventario gestorDeInventario = new Business.GestorDeInventario();
            decimal actual = gestorDeInventario.CalcularSubtotal(prueba);
            //Assert
            Assert.AreEqual(Resultado, actual);
        }
    }
}
