using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using DataServiceLayer.Models.App;

namespace AplikacjaIO.Helpers
{
    public class ClaimHellper
    {
        static public ClaimsIdentity CreateIdentity(LoginModel uzytkownik)
        {
            var identity = new ClaimsIdentity("FirstAppAuthorization");
            identity.AddClaims(new List<Claim> {
                    new Claim(ClaimTypes.NameIdentifier,uzytkownik.UzytkownikId.ToString()),
                new Claim(ClaimTypes.Name,uzytkownik.UzytkownikImie),
                new Claim(ClaimTypes.Role,uzytkownik.UzytkownikRola)
            });
            return identity;
        }
    }
}