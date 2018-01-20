using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataServiceLayer.Models.View
{
    public class RaportModel
    {

        [Display(Name = "Id Raportu")]
        public int IdRaportu { get; set; }
        [Display(Name = "Suma")]
        public double Suma { get; set; }
        [Display(Name = "Od")]
        public DateTime DataOd { get; set; }
        [Display(Name = "Do")]
        public DateTime DataDo { get; set; }
        public List<RachunkiModel> RachunkiNaRaporcie { get; set; }
    }
}