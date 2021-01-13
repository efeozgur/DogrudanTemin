using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using DogrudanTemin.Models;
using DogrudanTemin.ViewModels;
using RestSharp;
using RestSharp.Authenticators;

namespace DogrudanTemin.Controllers
{
    public class HomeController : Controller
    {
        DataModel db = new DataModel();
        private MalzemeViewModel mvm = new MalzemeViewModel();


        [HttpGet]
        public ActionResult MalzemeGiris()
        {
            
            mvm.Malzemeler = db.Malzeme.ToList();
            return View(mvm);
        }

        [HttpPost]
        public ActionResult MalzemeGiris(MALZEME malzeme)
        {
            db.Malzeme.Add(malzeme);
            db.SaveChanges();
            return RedirectToAction("MalzemeGiris");
        }


        public ActionResult Sil(int id)
        {

            var mevzu = db.Malzeme.Where(x => x.ID == id).FirstOrDefault();
            db.Malzeme.Remove(mevzu);
            db.SaveChanges();
            return RedirectToAction("MalzemeGiris");

        }

        public string SifreOlustur(string sifre)
        {
            MD5 md5Hasher= MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(sifre));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i< data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();

        }

      

    }
}