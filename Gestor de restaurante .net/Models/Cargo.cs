﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestor_de_restaurante.net.Models
{
    public abstract class Cargo
    {
        protected abstract void definirCargo(Empleado empleado);

    }
}