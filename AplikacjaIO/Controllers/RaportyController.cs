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
            return View();
        }

        public ActionResult Zobacz(int IdRaportu)
        {
            var model = _raporty.GetRaport(IdRaportu);
            return View(model);
        }
    }
}