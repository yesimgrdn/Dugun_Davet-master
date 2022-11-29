using Dugun_Davet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dugun_Davet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult CevapFormu()
        {
            return View();
        }

        [HttpPost]
        public ViewResult CevapFormu(Cevap KatilimciCevabi)
        {
            if (ModelState.IsValid) // form validationlara göre doldurulmuşsa KatilimciCevabi'na eklenecek.
            {
                Repository.CevapEkle(KatilimciCevabi);
                return View("Tesekkurler", KatilimciCevabi);
            }
            else //eğer hatalıysa form sayfası boş şekilde geri yüklenecek.
            {
                return View();
            }
        }
        public ViewResult CevaplariListele()
        {
            var liste = Repository.Cevaplar.Where(x => x.DuguneGelecekMi == true).ToList();
            return View(liste);
        }
        public ViewResult Gelmeyenler()
        {
            var liste = Repository.Cevaplar.Where(x => x.DuguneGelecekMi == false).ToList();
            return View(liste);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}