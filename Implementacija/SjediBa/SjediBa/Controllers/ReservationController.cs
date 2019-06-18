using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SjediBa.Models;

namespace SjediBa.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Reservation()
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