using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoresEditoriales.Models
{
    public class Libros
    {
        public int editoriales_Id { get; set; }
        public string titulo { get; set; }
        public string sinopsis { get; set; }
        public string n_Paginas { get; set; }
    }
}