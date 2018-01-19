using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataServiceLayer.Models.View
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Title is required.")]
        [Display(Name = "Login")]
        [MaxLength(10)]
        public string Login { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        [Display(Name = "Hasło")]
        [MaxLength(10)]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }
    }
}