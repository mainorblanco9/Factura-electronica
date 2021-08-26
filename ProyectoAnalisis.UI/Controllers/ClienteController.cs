using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoAnalisis.UI.Controllers
{
    [Authorize]
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            Business.GestorDeCliente gestorDeCliente = new Business.GestorDeCliente();
            var lista = gestorDeCliente.ListarClientes();
            return View(lista);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
       

        // GET: Cliente/Create
        public ActionResult Create()
        {
            Business.GestorDeUbicacion gestorDeUbicacion = new Business.GestorDeUbicacion();
            
            
          
           ViewBag.Provincia = gestorDeUbicacion.ListarProvincia();
           
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Model.Cliente cliente)
        {
            try
            {
                Business.GestorDeCliente gestorDeCliente = new Business.GestorDeCliente();
                gestorDeCliente.RegistrarUnCliente(cliente); 

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            Model.Cliente cliente = new Model.Cliente();
            Business.GestorDeCliente gestorDeCliente = new Business.GestorDeCliente();
            cliente = gestorDeCliente.Consultar(id);
            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Model.Cliente cliente)
        {
            try
            {
                Business.GestorDeCliente gestorDeCliente = new Business.GestorDeCliente();
                gestorDeCliente.EditarCliente(cliente);
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
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
