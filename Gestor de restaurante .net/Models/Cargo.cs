using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestor_de_restaurante.net.Models
{
    //Clase cargo que contendra los cargos que podran ser registrados por el usuario
    public class Cargo
    {
        //atributo para acceder a los datos de cada objeto
        public int idCargo { get; set; }
        //atributo para registrar el nombre del cargo
        public string nombreCargo { get; set; }
        //atributo para registrar la informacion detallada del cargo del cargo
        public string descripcion { get; set; }
        //Atributo para registrar el salrio
        public double salario { get; set; }
    }
}