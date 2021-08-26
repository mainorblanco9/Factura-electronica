using ProyectoAnalisis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoAnalisis.UI.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            Business.GestorDeUsuarios gestorDeUsuarios = new Business.GestorDeUsuarios();
            List<Model.Usuarios> laListaDeUsuarios = new List<Model.Usuarios>();
            laListaDeUsuarios = gestorDeUsuarios.ListarUsuarios();
            return View(laListaDeUsuarios);
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
        

            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(Model.Usuarios usuarios)
        {
            try
            {
                // TODO:
                Business.GestorDeUsuarios gestorDeUsuarios =new  Business.GestorDeUsuarios();
                gestorDeUsuarios.RegistrarunUsuario(usuarios);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuarios/Edit/5
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

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuarios/Delete/5
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
