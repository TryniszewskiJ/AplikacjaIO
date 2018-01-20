using DataServiceLayer.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Configuration;
using System.Security.Claims;
using System.Web.Security;
using Microsoft.Owin.Security;
using AplikacjaIO.Helpers;
using DataServiceLayer.Service;
using DataServiceLayer.IService;
using AplikacjaIO.Attributes;

namespace AplikacjaIO.Controllers
{
    public class LoginController : Controller
    {
        private readonly IKasjer _kasjer;
        private readonly IKierownik _kierownik;

        public LoginController(IKasjer kasjer,IKierownik kierownik)
        {
            _kasjer = kasjer;
            _kierownik = kierownik;
        }

        // GET: Kasjer
        [HttpGet]
        [IsNotAuthorizeAttribute]
        public ActionResult Kasjer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kasjer(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View();
            if (model.Haslo == null || model.Login == null)
                return View();
            DataServiceLayer.Models.App.LoginModel uzytkownik = _kasjer.Autoruzacja(model);
            if (uzytkownik != null)
            {
                var identity = ClaimHellper.CreateIdentity(uzytkownik);
                HttpContext.GetOwinContext().Authentication.SignIn(identity);
                return RedirectToAction("Index", "MenuUzytkownika", new { Id = uzytkownik.UzytkownikId });
            }
            else
            {
                if (!string.IsNullOrEmpty(model.Login) && !(string.IsNullOrEmpty(model.Haslo)))
                    ViewBag.Error = "Nie poprawny login lub hasło";
                return View();
            }
        }

        [HttpGet]
        [IsNotAuthorize]
        public ActionResult Kierownik()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kierownik(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View();
            if (model.Haslo == null || model.Login == null)
                return View();
            DataServiceLayer.Models.App.LoginModel uzytkownik = _kierownik.Autoruzacja(model);
            if (uzytkownik != null)
            {
                var identity = ClaimHellper.CreateIdentity(uzytkownik);
                HttpContext.GetOwinContext().Authentication.SignIn(identity);
                return RedirectToAction("Index", "MenuUzytkownika");
            }
            else
            {
                if (!string.IsNullOrEmpty(model.Login) && !(string.IsNullOrEmpty(model.Haslo)))
                    ViewBag.Error = "Nie poprawny login lub hasło";
                return View();
            }
        }
    }
}