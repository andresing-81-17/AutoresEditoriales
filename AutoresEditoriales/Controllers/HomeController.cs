using AutoresEditoriales_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoresEditoriales.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Repositorio repo = new Repositorio();
            List<AutoresEditoriales_DB.EntityModel.editoriales> editoriales = new List<AutoresEditoriales_DB.EntityModel.editoriales>();
            editoriales = repo.GetEditoriales();
            ViewBag.editoriales = editoriales;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
           
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult insertarEditoriales(AutoresEditoriales_DB.EntityModel.editoriales editoriales)
        {
            Repositorio repo = new Repositorio();
            Respuesta result = repo.insertaEditoriales(editoriales);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}