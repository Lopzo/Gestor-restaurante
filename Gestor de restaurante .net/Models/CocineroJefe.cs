using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gestor_de_restaurante.net.Models
{
    public class CocineroJefe : Cargo
    {
        protected override void definirCargo(Empleado empleado) 
        {
            empleado.Funciones = "Encargado de administrar y registrar todos los empleados en el sistema";
        }
    }
}