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
        public string OpisPromocji { get; set; }
        [Display(Name = "Data wdrożenia")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Pole wymagane")]
        public DateTime DataWdrozenia { get; set; }
    }
}