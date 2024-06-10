using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pSC06.Controllers
{
    public class CerrarSessionController : Controller
    {
        // GET: CerrarSession
        public ActionResult Logoff()
        {
            Session["Usuario"] = null;  // cierra la seccion 
            return RedirectToAction("Login", "Acceder");  // redireciona hacia la vista de Login
        }
    }
}