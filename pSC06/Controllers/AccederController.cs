using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pSC06.Models;

namespace pSC06.Controllers
{
    public class AccederController : Controller
    {
        // GET: Acceder
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Enter(string usuario, string password)
        {
            using (DBMVCSCEntities db = new DBMVCSCEntities())
            {
                // SELECT * FROM USERS WHERE EMAIL = @USUARIO AND PASSWORD = @PASSWORD AND IDESTATUS = 1

                var read = from d in db.USERS
                           where d.Email == usuario
                              && d.Password == password
                              && d.idEstatus == 1
                           select d;

                if (read.Count() > 0)  // aqui pregunta si encontro algun registro
                {
                    Session["Usuario"] = read.First();  // creamos una session de usuario, con el primer elemento encontrado en la consulta
                    return Content("1");  // retorn 1 hacia el script de la vista, indicando que encontro el registro buscado
                }
                else
                {
                    return Content("Ocurrio un error :("); // despliega una caja de mensage indicando que no encontro registro
                }
            }
        }
    }
}