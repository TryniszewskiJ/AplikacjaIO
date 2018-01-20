using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace AplikacjaIO.Controllers
{
    [Authorize]
    public class MenuUzytkownikaController : Controller
    {
        public ActionResult Index()
        {
            var role = ((ClaimsPrincipal)User).FindFirst(ClaimTypes.Role).Value;
            if(role == "Kierownik")
            {
                return RedirectToAction("Kierownik", "MenuUzytkownika");
            }
            else
            {
                return RedirectToAction("Kasjer", "MenuUzytkownika");
            }
            return View();
        }
        [Authorize(Roles = "Kasjer")]
        // GET: MenuUzytkownika
        public ActionResult Kasjer()
        {
            return View();
        }

        [Authorize(Roles = "Kierownik")]
        public ActionResult Kierownik()
        {
            return View();
        }
    }
}