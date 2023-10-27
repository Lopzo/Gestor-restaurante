using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gestor_de_restaurante.net.Models
{
    public abstract class Empleado
    {
        public int idEmpleado { get;protected set; }
        public string nombre { get;protected set; }
        public int tipoDocumento { get;protected set; }
        public string Documento { get;protected set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fechaNacimiento { get;protected set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fechaIngreso { get; set; }
        public bool estado { get;protected set; }
        public string Funciones { get; set; }


        protected abstract void definirCargo();
        protected abstract void definirTipoContrato();
    }
}