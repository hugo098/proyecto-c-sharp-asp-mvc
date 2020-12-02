using ProyectoFinalASP_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalASP_MVC.Controllers
{
    [Authorize]
    public class ConsultaStockBajoController : Controller
    {
        private ComercialEntities db = new ComercialEntities();
        // GET: ConsultaStockBajo
        public ActionResult Index()
        {
            ViewBag.BajoStock = db.Producto.Where(x => x.cantidadStock <= 10).ToList();
            return View();
        }


    }
}