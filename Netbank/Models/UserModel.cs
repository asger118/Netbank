using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Netbank.Models {
    public class UserModel {

        [Display(Name = "Bruger ID")]
        [Range(100000, 999999, ErrorMessage = "Indsæt et gyldigt Bruger ID")]
        public int UserId { get; set; }
        
        [Display(Name = "Konto ID")]
        [Range(100000, 999999, ErrorMessage = "Indsæt et gyldigt Konto ID")]
        public int AccountId { get; set; }
        
        [Display(Name = "Pinkode")]
        [Required(ErrorMessage = "Du mangler pinkode")]
        public int UserPincode { get; set; }
        
        [Display(Name = "Fornavn")]
        [Required(ErrorMessage = "Du mangler fornavn")]
        public string FirstName { get; set; }
        
        [Display(Name = "Efternavn")]
        [Required(ErrorMessage = "Du mangler efternavn")]
        public string LastName { get; set; }
        
        [Display(Name = "Email adresse")]
        [Required(ErrorMessage = "Du mangler email adresse")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        
        [Display(Name = "Bekræft email")]
        [DataType(DataType.EmailAddress)]
        [Compare("EmailAddress", ErrorMessage = "Email matcher ikke")]
        public string ConfirmEmail {get; set;}
        
        [Display(Name = "Adgangskode")]
        [Required(ErrorMessage = "Du mangler adgangskode")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Din adgangskode er ikke lang nok")]
        public string   Password { get; set; }
        
        [DataType(DataType.Password)]
        [Display(Name = "Bekræft adgangskode")]
        [Compare("Password", ErrorMessage = "Adgangskode matcher ikke")]
        public string ConfirmPassword { get; set; }
    }
}