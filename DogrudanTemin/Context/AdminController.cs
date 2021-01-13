using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DogrudanTemin.Models;

namespace DogrudanTemin.Context
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult KurumKaydi(KURUM kurum)
        {
            
            return View();

        }

    }
}