using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataServiceLayer.Models.View
{
    public class RachunkiModel
    {
        public int IdRachunku { get; set; }
        [Display(Name = "Wysokosc rachunku")]
        public double Wysokosc { get; set; }
        public int IdKasjera { get; set; }
        public List<PozycjeModel> Sklad { get; set; }
    }

    public class PozycjeModel
    {
        public int IdPozycji { get; set; }
        public int IdRachunku { get; set; }
        public float Cena { get; set; }
        public float Ilosc { get; set; }
    }
}