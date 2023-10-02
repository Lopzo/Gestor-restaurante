using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gestor_de_restaurante.net.Models
{
    public class Empleado
    {
        public int  idEmpleado { get; set; } 
        public string  nombre{ get; set; } 
        public int  tipoDocumento { get; set; }
        public string Documento { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fechaNacimiento { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fechaIngreso { get; set; }
        public bool estado { get; set; }
        public int cargo { get; set; }

        public List<Empleado> crearLista() 
        {

            List<Empleado> empleados = new List<Empleado>()
            {
               new Empleado(){ idEmpleado = this.idEmpleado, nombre = this.nombre, tipoDocumento = this.tipoDocumento, Documento = this.Documento, fechaNacimiento = this.fechaNacimiento, fechaIngreso = this.fechaIngreso, cargo=this.cargo, estado = this.estado}
            };


            return empleados;
        }

    public List<Empleado> crearEmpleado() 
        {
            List<Empleado> empleados = HttpContext.Current.Session["ListaEmpleados"] as List<Empleado>;
            if (empleados != null)
            {
                empleados.Add(this);
            }
            else 
            {
                empleados  = this.crearLista();
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
            foreach (var empleado  in empleados) 
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
            List<Empleado> empleados = HttpContext.Current.Session["ListaEmpleados"] as List<Empleado>;

            Empleado empleado = empleados.Where(x => x.idEmpleado == idEmpleado).FirstOrDefault();
            return empleado;
        }
    }
}