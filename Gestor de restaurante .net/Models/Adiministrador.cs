using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gestor_de_restaurante.net.Models
{
    public class Administrador : Cargo
    {
        protected override void definirCargo(Empleado empleado) 
        {
            empleado.Funciones = "Encargado de administrar y registrar todos los empleados en el sistema";
        }

        private List<object> crearEmpleado()
        {
            List<object> empleados = HttpContext.Current.Session["ListaEmpleados"] as List<object>;
            if (empleados != null)
            {
                empleados.Add();
            }

            return empleados;
        }

        public List<Empleado> eliminarEmpleado(int idEmpleado)
        {
            List<Empleado> empleados = HttpContext.Current.Session["ListaEmpleados"] as List<Empleado>;
            Empleado empleado = empleados.Where(x => x.idEmpleado == idEmpleado).FirstOrDefault();
            empleados.Remove(empleado);
            return empleados;
        }

        public List<Empleado> modificarEmpleado(Empleado modEmpleado)
        {
            List<Empleado> empleados = HttpContext.Current.Session["ListaEmpleados"] as List<Empleado>;
            foreach (var empleado in empleados)
            {
                if (empleado.idEmpleado == modEmpleado.idEmpleado)
                {
                    empleado.idEmpleado = modEmpleado.idEmpleado;
                    empleado.nombre = modEmpleado.nombre;
                    empleado.tipoDocumento = modEmpleado.tipoDocumento;
                    empleado.Documento = modEmpleado.Documento;
                    empleado.fechaNacimiento = modEmpleado.fechaNacimiento;
                    empleado.fechaIngreso = modEmpleado.fechaIngreso;
                    empleado.cargo = modEmpleado.cargo;
                    empleado.estado = modEmpleado.estado;
                    break;
                }
            }

            return empleados;
        }

        public Empleado GetEmpleado(int idEmpleado)
        {
            List<object> empleados = HttpContext.Current.Session["ListaEmpleados"] as List<object>;

            object empleado = empleados.Where(x => x.va)
            return empleado;
        }
    }
}