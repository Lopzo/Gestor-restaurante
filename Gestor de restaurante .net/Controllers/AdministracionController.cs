using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestor_de_restaurante.net.Models;

namespace Gestor_de_restaurante.net.Controllers
{
    public class AdministracionController : Controller
    {
        // GET: Empleado
        public ActionResult index()
        {
            var empleados = Session["ListaEmpleados"];
            if (empleados == null) 
            {
                empleados = new List<Adiministrador>(); 
            }

            return View(empleados);
        }

        public ActionResult ver(int idEmpleado) 
        {
            Adiministrador empleado = new Adiministrador();
            empleado = empleado.GetEmpleado(idEmpleado);
            return View(empleado);
        }

        public ActionResult crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult crear(Adiministrador empleado)
        {

            try
            {
                Session["ListaEmpleados"] = empleado.crearEmpleado();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult modificar(int idEmpleado)
        {
            Adiministrador empleado = new Adiministrador();
            empleado = empleado.GetEmpleado(idEmpleado);
            return View(empleado);
        }

        [HttpPost]
        public ActionResult modificar(Adiministrador empleado, int idEmpleado) 
        {
            try
            {
                Session["ListaEmpleados"] = empleado.modificarEmpleado(empleado);

                return RedirectToAction("index");
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public ActionResult eliminar(int idEmpleado) 
        {
            Adiministrador metEmpleado = new Adiministrador();
            Session["ListaEmpleados"] = metEmpleado.eliminarEmpleado(idEmpleado);
            return RedirectToAction("Index");
        }

    }
}