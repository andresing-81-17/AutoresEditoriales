using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoresEditoriales_DB.EntityModel
{
    public class libros
    {
        public int ISBM { get; set; } 
        public int editoriales_Id { get; set; }
        public string titulo { get; set; }
        public string sinopsis { get; set; }
        public string n_Paginas { get; set; }
    }
}