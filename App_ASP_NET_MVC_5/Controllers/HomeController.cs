using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_ASP_NET_MVC_5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Si requieres servicios de desarrollo de software o tienes preguntas no dudes en contactarme";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(Models.Contacto contacto)
        {
            var db = new Models.ContactoContext();
            db.Contactos.Add(contacto);
            try
            {
                db.SaveChanges();
                ViewBag.Mesage = "Tu mensaje se ha guardado";
            }
            catch(Exception e)
            {
                ViewBag.Message = "Error al Guardar " + e.Message;
            }

            return View();
        }

        [Authorize]
        public ActionResult Projects()
        {
            return View();
        }
    }
}