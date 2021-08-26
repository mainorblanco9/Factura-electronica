using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoAnalisis.UI.Controllers
{
    [Authorize]
    public class InventarioController : Controller
    {
        // GET: Inventario
        public ActionResult Index()
        {
            Business.GestorDeInventario gestorDeInventario = new Business.GestorDeInventario();
            List<Model.Producto> laListaDeProducto = new List<Model.Producto>();
            laListaDeProducto = gestorDeInventario.ListarProductos();
            return View(laListaDeProducto);
        }

        // GET: Inventario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inventario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inventario/Create
        [HttpPost]
        public ActionResult Create(Model.Producto producto)
        {
            try
            {
                Business.GestorDeInventario gestorDeInventario = new Business.GestorDeInventario();
                gestorDeInventario.RegistrarunProducto(producto);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Edit/5
        public ActionResult Edit(int id)
        {
            Model.Producto producto = new Model.Producto();
            Business.GestorDeInventario gestorDeInventario = new Business.GestorDeInventario();
            producto= gestorDeInventario.Consultar(id);
            return View(producto);
        }

        // POST: Inventario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Model.Producto producto)
        {
            try
            {
                Business.GestorDeInventario gestorDeInventario = new Business.GestorDeInventario();
                gestorDeInventario.EditarProducto(producto);
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inventario/Delete/5
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
