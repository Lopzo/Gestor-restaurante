using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestor_de_restaurante.net.Models;

namespace Gestor_de_restaurante.net.Controllers
{
    public class tipoDocumentoController : Controller
    {

        // GET: tipoDocumento
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult crear()
        {

            return View();
        }

        [HttpPost]
        public ActionResult crear(Cargo cargo)
        {

            return View();
        }

        public ActionResult modificar(int idCargo)
        {

            return View();
        }

        [HttpPost]
        public ActionResult modificar(Cargo cargo, int idCargo)
        {

            return View();
        }

        public ActionResult eliminar(int idCargo)
        {
            return RedirectToAction("Index");
        }
    }
}