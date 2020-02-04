using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoresEditoriales_DB
{
    public class Respuesta
    {
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public bool Exitoso { get; set; }
    }
}