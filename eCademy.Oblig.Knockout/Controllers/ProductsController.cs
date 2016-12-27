using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCademy.Oblig.Knockout.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}
