using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataServiceLayer.Models.View
{
    public class PromocjeModel
    {
        public int IDPromoca { get; set; }
        [Display(Name = "Nazwa promocji")]
        [MaxLength(10)]
        [Required(ErrorMessage = "Pole wymagane")]
        public string NazwaPromocji { get; set; }
        [Display(Name = "Opis promocji")]
        [MaxLength(250)]
        [Required(ErrorMessage = "Pole wymagane")]
        [DataType(DataType.MultilineText)] /*DODANE POD TEXTAREA*/
        public string OpisPromocji { get; set; }
        [Display(Name = "Data wdrożenia")]
        [Required(ErrorMessage = "Pole wymagane")]
        public DateTime DataWdrozenia { get; set; }
        [Display(Name = "Kto utworzył")]
        public string NazwaKierownika { get; set; }
        public int IdKierownika { get; set; }
        [Display(Name = "Wysokośc Rabatu(%)")]
        [Required(ErrorMessage = "Pole wymagane")]
        public int WysokoscRabatu { get; set; }
    }
}