using ProyectoAnalisis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace ProyectoAnalisis.UI.Controllers
{
    [Authorize]
    public class FacturasController : Controller
    {
        // GET: Facturas
        public ActionResult Index()
        {
            Business.GestorDeFactura gestorDeFactura = new Business.GestorDeFactura();
            var lalista = gestorDeFactura.ListarFactura();

           
            return View(lalista);
        }

        // GET: Facturas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
       
        public ActionResult Create()
        {
            Business.GestorDeUbicacion gestorDeUbicacion = new Business.GestorDeUbicacion();
            Business.GestorDeInventario gestorDeInventario = new Business.GestorDeInventario();
            Business.GestorDeCliente gestorDeCliente = new Business.GestorDeCliente();
            Model.FacturaElectronica facturaElectronica = new FacturaElectronica();
            facturaElectronica.provincia = gestorDeUbicacion.ListarProvincia();
            facturaElectronica.productosFacturas = gestorDeInventario.dropdownlistProducto();
            ViewBag.Clientes= gestorDeCliente.DropdownlistCliente();
            return View(facturaElectronica);
        }

        // POST: Facturas/Create
        [HttpPost]
        public ActionResult Create(Model.FacturaElectronica facturaElectronica)
        {
            try
            {
                Business.GestorDeFactura gestorDeFactura = new Business.GestorDeFactura();
                facturaElectronica.Encabezado.Clave = "0000000000004445557425674";
                facturaElectronica.Encabezado.NumeroConsecutivo = 5674;
                gestorDeFactura.RegistarUnaFactura(facturaElectronica);
               
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
  
       
       
        // GET: Facturas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Facturas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Facturas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Facturas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
