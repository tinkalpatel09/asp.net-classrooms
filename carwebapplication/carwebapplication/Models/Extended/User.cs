using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace carwebapplication.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public string ConformPassword { get; set; }
    }
    public class UserMetadata
    {
        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false,  ErrorMessage ="Name required")]
        public string Name { get; set; }

        [Display(Name = "DateofBirth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:MM/dd/yyyy}" )]
        public Nullable<System.DateTime> DateofBirth { get; set; }

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password  required")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Minimum 6 Characters required")]
        public string Password { get; set; }

        [Display(Name = "conform Password")]

        [DataType(DataType.Password)]
      [Compare("Password",ErrorMessage ="conform password and password do not match")]
        public string ConformPassword { get; set; }



        [Display(Name = "PhoneNumber")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "PhoneNumber  required")]
        [DataType(DataType.PhoneNumber)]
        [MinLength(9, ErrorMessage = "Minimum 9 Characters required")]
        public string PhoneNumber { get; set; }


        [Display(Name = "DrivingLicence")]
      
        public string DrivingLicence { get; set; }

        #region Implementation of IValidatableObject interface

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var contextUser = (User)validationContext.ObjectInstance;

            using (var context = new CarRentDBEntities())
            {
                var existingUser = context.Users.FirstOrDefault(u => u.Password == this.Password);
                if (existingUser != null)
                {
                    yield return new ValidationResult("A user with the same username already exists");
                }
            }
        }

        #endregion
    }
}