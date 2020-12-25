using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace carwebapplication.Models
{
    public class UserLogin
    {
        [Display(Name = "User Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name required")]
        public string Name { get; set; }

       
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password  required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool rememberme { get; set; }
    }
}