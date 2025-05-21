﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Xml.Linq;

namespace layout.Modelos
{
    public class Contacto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public bool Activo { get; set; }
    }
}
