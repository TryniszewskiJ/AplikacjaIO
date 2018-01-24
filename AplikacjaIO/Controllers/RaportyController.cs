using DataServiceLayer.IService;
using DataServiceLayer.Models.View;
using DataServiceLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplikacjaIO.Controllers
{
    [Authorize(Roles = "Kierownik")]
    public class RaportyController : Controller
    {
        private readonly IRaporty _raporty;

        public RaportyController(IRaporty raporty)
        {
            _raporty = raporty;
        }
        // GET: Raporty
        public ActionResult Index()
        {
            var model = _raporty.GetRaportList();
            return View(model);
        }

        [HttpGet]
        public ActionResult Utworz()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Utworz(RaportModel model)
        {
            model = _raporty.Utworz(model);
            ViewBag.czyPostBack = true;
            if(model == null)
            {
                ViewBag.Error = true;
                return View();
            }
            return View(model);
        }

        public ActionResult Zobacz(int IdRaportu)
        {
            var model = _raporty.GetRaport(IdRaportu);
            return View(model);
        }

        public ActionResult Usun(int IdRaportu)
        {
            _raporty.Usun(IdRaportu);
            var model = _raporty.GetRaportList();
            return View("Index",model);
        }
    }
}