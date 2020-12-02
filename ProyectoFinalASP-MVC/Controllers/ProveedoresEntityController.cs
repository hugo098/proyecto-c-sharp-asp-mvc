using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoFinalASP_MVC.Models;

namespace ProyectoFinalASP_MVC.Controllers
{
    [Authorize]
    public class ProveedoresEntityController : Controller
    {
        private ComercialEntities db = new ComercialEntities();

        // GET: ProveedoresEntity
        public ActionResult Index()
        {
            return View(db.Proveedor.ToList());
        }

        // GET: ProveedoresEntity/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proveedor proveedor = db.Proveedor.Find(id);
            if (proveedor == null)
            {
                return HttpNotFound();
            }
            return View(proveedor);
        }

        // GET: ProveedoresEntity/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProveedoresEntity/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RUC,idProveedor,razonSocial,telefono,direccion")] Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {

                db.Proveedor.Add(proveedor);
                db.SaveChanges();
                return RedirectToAction("Index");


            }

            return View(proveedor);
        }

        // GET: ProveedoresEntity/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proveedor proveedor = db.Proveedor.Find(id);
            if (proveedor == null)
            {
                return HttpNotFound();
            }
            return View(proveedor);
        }

        // POST: ProveedoresEntity/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RUC,idProveedor,razonSocial,telefono,direccion")] Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {

                db.Entry(proveedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(proveedor);
        }

        // GET: ProveedoresEntity/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proveedor proveedor = db.Proveedor.Find(id);
            if (proveedor == null)
            {
                return HttpNotFound();
            }
            return View(proveedor);
        }

        // POST: ProveedoresEntity/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Proveedor proveedor = db.Proveedor.Find(id);
                db.Proveedor.Remove(proveedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View("Error");
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
