using DataServiceLayer.IService;
using DataServiceLayer.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplikacjaIO.Controllers
{
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

        [HttpGet]
        public ActionResult Otworz()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Zamknij(RachunkiModel rachunek)
        {
            return View();
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
    }
}