using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataServiceLayer.Models.App
{
    public class LoginModel
    {
        public int UzytkownikId { get; set; }
        public string UzytkownikImie { get; set; }
        public string UzytkownikRola { get; set; }
    }
}