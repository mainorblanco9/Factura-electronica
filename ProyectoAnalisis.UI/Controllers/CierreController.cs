using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoAnalisis.UI.Controllers
{
    [Authorize]
    public class CierreController : Controller
    {
        // GET: Cierre
        public ActionResult Index()
        {
            Business.GestorDeCierres gestorDeCierres = new Business.GestorDeCierres();
            var lis = gestorDeCierres.ListarCierres();
          
            return View(lis);
        }
        [HttpPost]
        public ActionResult Index(Model.Cierres cierres)
        {
            try
            {
                Business.GestorDeCierres gestorDeCierres = new Business.GestorDeCierres();
                cierres.NombreDelUsuario = User.Identity.Name;
                gestorDeCierres.CrearCierre(cierres);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cierre/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cierre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cierre/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cierre/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cierre/Edit/5
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

        // GET: Cierre/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cierre/Delete/5
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
