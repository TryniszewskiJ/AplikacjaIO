using DataServiceLayer.IService;
using DataServiceLayer.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace AplikacjaIO.Controllers
{
    [Authorize]
    public class RachunkiController : Controller
    {
        private readonly IRachunki _rachunki;

        public RachunkiController(IRachunki rachunki)
        {
            _rachunki = rachunki;
        }
        // GET: Rachunki
        public ActionResult Index()
        {
            var model = _rachunki.GetRachunkiList();
            return View(model);
        }

        [Authorize(Roles = "Kasjer")]
        [HttpGet]
        public ActionResult Otworz()
        {
            var model = _rachunki.GetPromocje();
            return View(model);
        }

        [Authorize(Roles = "Kasjer")]
        [HttpPost]
        public ActionResult Zamknij()
        {
            var masa = Request.Form.Get("masa");
            var rabat = Request.Form.Get("sel");
            var idKasjera = Convert.ToInt32(((ClaimsPrincipal)User).FindFirst(ClaimTypes.NameIdentifier).Value);
            var model = _rachunki.Dodaj(masa, rabat,idKasjera);
            if(model == null)
            {
                ViewBag.Error = true;
            }
            return View("Zobacz", model);
        }

        [HttpGet]
        public ActionResult Zobacz(int IdRachunku)
        {
            var model = _rachunki.GetRachunek(IdRachunku);
            return View(model);
        }

        [HttpGet]
        public ActionResult Usun(int IdRachunku)
        {
            _rachunki.Usun(IdRachunku);
            return View("Index");
        }
        public ActionResult Wybierz()
        {
            return View();
        }

    }
}