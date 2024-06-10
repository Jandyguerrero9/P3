using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using pSC06.Models;
using pSC06.Models.ViewModels;

namespace pSC06.Controllers
{
    public class QueryController : Controller
    {
        // GET: Query
        public ActionResult Query()
        {
            List<QueryUserViewModels> lst = null;  

            using (DBMVCSCEntities db = new DBMVCSCEntities())
            {
                // SELECT * FROM USERS WHERE IDESTATUS = 1 ORDER BY EMAIL 
                lst = (from d in db.USERS
                       where d.idEstatus == 1
                       orderby d.Email

                       select new QueryUserViewModels
                       {
                           _Email = d.Email,
                           _Edad = d.Edad,
                           _Id = d.ID
                       }).ToList();
            }

            return View(lst);
        }
    }
}