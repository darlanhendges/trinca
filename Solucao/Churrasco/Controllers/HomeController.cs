using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Churrasco.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var churrascos = new DAB.BO.Churrasco().Listar.OrderBy(c => c.Quando);
            return View(churrascos);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}