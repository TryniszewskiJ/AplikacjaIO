using DataServiceLayer.IService;
using DataServiceLayer.Models.View;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace AplikacjaIO.Controllers
{
    //[Authorize(Roles = "Kierownik")]
    public class PromocjeController : Controller
    {
        private readonly IPromocja _promocja;

        public PromocjeController(IPromocja promocja)
        {
            _promocja = promocja;
        }

        // GET: Promocje
        public ActionResult Index()
        {
            var model = _promocja.GetPromocjaList();
            if(model == null)
            {
                model = new List<PromocjeModel>();
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Wprowadz()
        {
            ViewBag.czyEdycja = false;
            ViewBag.czyPost = false;
            return View();
        }
        [HttpPost]
        public ActionResult Wprowadz(PromocjeModel model)
        {
            ViewBag.czyEdycja = false;
            var data = Request.Form.GetValues("DataWdrozenia");
            //model.DataWdrozenia = DateTime.ParseExact(data[0], "MM/dd/yyyy", CultureInfo.InvariantCulture);
            model.DataWdrozenia = DateTime.ParseExact(data[0], "MM/dd/yyyy", CultureInfo.InvariantCulture);
            model.IdKierownika = Convert.ToInt32(((ClaimsPrincipal)User).FindFirst(ClaimTypes.NameIdentifier).Value);
            ViewBag.czyPost = true; 
            model = _promocja.Wprowadz(model);
            if(model == null)
            {
                ViewBag.Status = false;
            }
            else
            {
                ViewBag.Status = true;
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Edytuj(int IdPromocji)
        {
            PromocjeModel model = _promocja.GetPromocje(IdPromocji);
            if(model == null)
            {
                return View("Index", _promocja.GetPromocjaList());
            }
            ViewBag.czyEdycja = true;
            ViewBag.czyPost = false;
            return View("Wprowadz", model);
        }
        [HttpPost]
        public ActionResult Edytuj(PromocjeModel model)
        {
            ViewBag.czyEdycja = true;
            ViewBag.czyPost = true;
            model.IdKierownika = Convert.ToInt32(((ClaimsPrincipal)User).FindFirst(ClaimTypes.NameIdentifier).Value);
            model = _promocja.Edycja(model);
            if(model == null)
            {
                ViewBag.Status = false;
            }
            else
            {
                ViewBag.Status = true;
            }
            return View("Wprowadz", model);
        }

        [HttpGet]
        public ActionResult Usun(int IdPromocji)//ewentulanie samo id promocji
        {
            ViewBag.CzyUsunieto = _promocja.Usun(IdPromocji);
            var model = _promocja.GetPromocjaList();
            return View("Index", model);
        }

    }
}