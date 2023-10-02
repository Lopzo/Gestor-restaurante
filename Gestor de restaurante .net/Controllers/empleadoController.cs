using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestor_de_restaurante.net.Models;

namespace Gestor_de_restaurante.net.Controllers
{
    public class empleadoController : Controller
    {
        // GET: Empleado
        public ActionResult index()
        {
            var empleados = Session["ListaEmpleados"];
            if (empleados == null) 
            {
                empleados = new List<Empleado>(); 
            }

            return View(empleados);
        }

        public ActionResult ver(int idEmpleado) 
        {
            Empleado empleado = new Empleado();
            empleado = empleado.GetEmpleado(idEmpleado);
            return View(empleado);
        }

        public ActionResult crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult crear(Empleado empleado)
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
            Empleado empleado = new Empleado();
            empleado = empleado.GetEmpleado(idEmpleado);
            return View(empleado);
        }

        [HttpPost]
        public ActionResult modificar(Empleado empleado, int idEmpleado) 
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
            Empleado metEmpleado = new Empleado();
            Session["ListaEmpleados"] = metEmpleado.eliminarEmpleado(idEmpleado);
            return RedirectToAction("Index");
        }

    }
}