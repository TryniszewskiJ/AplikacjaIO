using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataServiceLayer.Models.View
{
    public class RachunkiModel
    {
        [Display(Name = "Numer rachunku")]
        public int IdRachunku { get; set; }
        [Display(Name = "Wysokosc rachunku")]
        public double Wysokosc { get; set; }
        public int IdKasjera { get; set; }
        [Display(Name = "Data Rachunku")]
        public DateTime DataRachunku { get; set; }
        [Display(Name = "Kto wystawil")]
        public string NazwaKasjera { get; set; }
        public List<PozycjeModel> Sklad { get; set; }
    }

    public class PozycjeModel
    {
        public int IdPozycji { get; set; }
        public int IdRachunku { get; set; }
        public double Cena { get; set; }
        public double Ilosc { get; set; }
    }

    public class RachunkiSaveModel
    {
        public string NazwaPromocji { get; set; }
        public int Rabat { get; set; }
    }
}