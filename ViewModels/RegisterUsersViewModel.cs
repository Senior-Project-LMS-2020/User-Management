using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using User_Management_try.Models;

namespace User_Management_try.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm passwod")]
        [Compare("Password", ErrorMessage = "password and conformation password dont match.")]
        public string ConfirmPassword { get; set; }
    }
    
    public class RegisterStudentViewModel :RegisterUserViewModel
    {
        [Required]
        public string StudentIdentification { get; set; }

        [Required]
        public Gender Gender { get; set; }


    }
}
