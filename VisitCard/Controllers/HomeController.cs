using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VisitCard.Models;

namespace VisitCard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var card = new VisitCardModel
            {
                FullName = "Я",
                BirthDate = new DateTime(2007, 1, 1),
                Description = "Студент П422" +
                              "......................",
                Email = "i@email.com"
            };
            return View(card);
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
