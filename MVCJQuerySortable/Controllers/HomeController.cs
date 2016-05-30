using MVCJQuerySortable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCJQuerySortable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Ninja> ninjalist = new List<Ninja>();

            Ninja ninja1 = new Ninja();
            ninja1.ID = 1;
            ninja1.Name = "çağatay";

            Ninja ninja2 = new Ninja();
            ninja2.ID = 2;
            ninja2.Name = "ahmet";

            Ninja ninja3 = new Ninja();
            ninja3.ID = 3;
            ninja3.Name = "tuna";

            ninjalist.Add(ninja1);
            ninjalist.Add(ninja2);
            ninjalist.Add(ninja3);


            return View(ninjalist);
        }
    }
}