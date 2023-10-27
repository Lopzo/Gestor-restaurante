using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gestor_de_restaurante.net.Models
{
    public class Mesero : Cargo
    {
        protected override void definirCargo(Empleado empleado)
        {
            empleado.Funciones = "Llevar comida, preparar mesa y cambiar estado de las mesa.";
        }


    }
}