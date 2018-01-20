﻿using DataServiceLayer.IService;
using DataServiceLayer.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace AplikacjaIO.Controllers
{
    [Authorize(Roles = "Kierownik")]
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
            ViewBag.czyPost = true; ;
            model = _promocja.Wprowadz(model);
            ViewBag.Status = true;
            return View(model);
        }

        [HttpGet]
        public ActionResult Edytuj(int IdPromocji)
        {
            PromocjeModel model = _promocja.GetPromocje(IdPromocji);
            ViewBag.czyEdycja = true;
            ViewBag.czyPost = false;
            model.IdKierownika = Convert.ToInt32(((ClaimsPrincipal)User).FindFirst(ClaimTypes.NameIdentifier).Value);
            return View("Wprowadz", model);
        }
        [HttpPost]
        public ActionResult Edytuj(PromocjeModel model)
        {
            ViewBag.czyEdycja = true;
            ViewBag.czyPost = true;
            model = _promocja.Edycja(model);
            ViewBag.Status = true;
            return View("Wprowadz", model);
        }

        [HttpGet]
        public ActionResult Usun(int IdPromocji)//ewentulanie samo id promocji
        {
            ViewBag.CzyUsunieto = _promocja.Usun(IdPromocji);
            return View("Index");
        }

    }
}