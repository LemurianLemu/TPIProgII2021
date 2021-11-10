﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_Backend.servicios
{
    public class Parametro
    {

        public string Nombre { get; set; }
        public object Valor { get; set; }
        public Parametro(string nombre, object valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
        public Parametro()
        {
            Nombre = string.Empty;
            Valor = null;
        }
    }
}