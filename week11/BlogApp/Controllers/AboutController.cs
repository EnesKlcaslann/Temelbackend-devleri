using System.ComponentModel;
using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        public ActionResult Index()
        {
            About about = new About()
            {
                FullName = "Enes Kılıçaslan",
                OnSoz = "Merhabalar , Size Kendimi Tanıtmak İstiyorum",
                Alan = "Backend Developer",
                TanıtmaMetni = $" Ben Enes kılıçaslan acun medya akademide back-end developer eğitimi alıyorum aynı zamanda ahmet yesevi üniversitesi yönetim bilişim sistemleri bölümü öğrencisiyim. ",
                tel = "05464377739"

            };



            return View(about);
        }

    }
}
