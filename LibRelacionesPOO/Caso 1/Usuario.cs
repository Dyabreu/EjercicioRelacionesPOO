﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Password { get; set; }

        public Cliente Cliente { get; set; }
    }
}
