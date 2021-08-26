using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.Tests
{
    [TestClass]
   public  class TestFactura
    {
        [TestMethod]
        public void CalcularImpuesto()
        {
            //Arrange
            Model.LineaDeDetalle prueba = new Model.LineaDeDetalle();
            prueba.Subtotal = 1000;

            decimal Resultado = 130;
            //Act
            Business.GestorDeFactura gestorDeFactura = new Business.GestorDeFactura();
            decimal actual = gestorDeFactura.CalcularImpuesto(prueba);
            //Assert
            Assert.AreEqual(Resultado, actual);
        }
      
        [TestMethod]
        public void CalcularMontototal()
        {
            //Arrange
            Model.LineaDeDetalle prueba = new Model.LineaDeDetalle();
            prueba.Cantidad = 2;
            prueba.PrecioUnitario = 1000;

            decimal Resultado = 2000;
            //Act
            Business.GestorDeFactura gestorDeInventario = new Business.GestorDeFactura();
            decimal actual = gestorDeInventario.CalcularMontototal(prueba);
            //Assert
            Assert.AreEqual(Resultado, actual);
        }
        [TestMethod]
        public void CalcularSubtotal()
        {
           
            //Arrange
            Model.LineaDeDetalle prueba = new Model.LineaDeDetalle();
            prueba.Descuento  = 2;
            prueba.MontoTotal = 1000;
            

            decimal Resultado = 980;
            //Act
            Business.GestorDeFactura gestorDeInventario = new Business.GestorDeFactura();
            decimal actual = gestorDeInventario.CalcularSubtotal(prueba);
            //Assert
            Assert.AreEqual(Resultado, actual);
        }
        [TestMethod]
        public void CalcularMontoTotalLinea()
        {

            //Arrange
            Model.LineaDeDetalle prueba = new Model.LineaDeDetalle();
            prueba.Impuesto = 130;
            prueba.Subtotal = 1000;


            decimal Resultado = 1130;
            //Act
            Business.GestorDeFactura gestorDeInventario = new Business.GestorDeFactura();
            decimal actual = gestorDeInventario.CalcularMontoLinea(prueba);
            //Assert
            Assert.AreEqual(Resultado, actual);
        }
    }
}
