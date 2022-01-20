using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odev.Controllers
{
    public class MusterilerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Listele()
        {
            using (var session=NhibernateHelper.OpenSession())
            {
                var musteriler = session.Query<Models.musteriler1>().ToList();
                return View(musteriler);
            }
        }

        public IActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Yeni(Models.musteriler1 musteriler11)
        {
            using(var session =NhibernateHelper.OpenSession())
            { 
            var musteriler1 = new Models.musteriler1();
            musteriler1.Ad = musteriler11.Ad;
            musteriler1.Soyad = musteriler11.Soyad;
            session.SaveOrUpdate(musteriler1);
            session.Flush();
            }
            return RedirectToAction("Listele");
        }

        public IActionResult Sil(int id)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var r = session.Query<Models.musteriler1>().FirstOrDefault(x => x.MusteriId == id);
                return View(r);
            }
        }
        [HttpPost]
        public IActionResult Sil(Models.musteriler1 musteriler11)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var r = session.Query<Models.musteriler1>().FirstOrDefault(x => x.MusteriId == musteriler11.MusteriId);
                session.Delete(r);
                session.Flush();
            }
            return RedirectToAction("Listele");
        }


        public IActionResult Guncelle(int id)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var r = session.Query<Models.musteriler1>().FirstOrDefault(x => x.MusteriId == id);
                return View(r);
            }
        }
        [HttpPost]
        public IActionResult Guncelle(Models.musteriler1 musteriler11)
        {
            using(var session = NhibernateHelper.OpenSession())
            {
                var r = session.Query<Models.musteriler1>().FirstOrDefault(x => x.MusteriId == musteriler11.MusteriId);
                r.Ad = musteriler11.Ad;
                r.Soyad = musteriler11.Soyad;
                session.SaveOrUpdate(r);
                session.Flush();
            }
            return RedirectToAction("Listele");
        }
        
        public IActionResult Detay(int id)
        {
            using (var session =NhibernateHelper.OpenSession())
            {
                var r = session.Query<Models.musteriler1>().FirstOrDefault(x => x.MusteriId == id);
                return View(r);
            }
        }
        


    }
}
