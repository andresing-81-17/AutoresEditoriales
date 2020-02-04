using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoresEditoriales_DB.EntityModel
{
    public class autores_has_libros
    {
        public int autores_Id { get; set; }
        public int libros_ISBN { get; set; }
    }
}