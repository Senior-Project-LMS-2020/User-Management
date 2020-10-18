using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace User_Management_try.Models
{
    public class UserViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm passwod")]
        [Compare("Password",ErrorMessage ="password and conformation password dont match.")]
        public string ConfirmPassword { get; set; }
    }
    public class StudentViewModel : UserViewModel
    {
        public Gender Gender { get; set; }
    }

    public class AdministratorViewModel : UserViewModel
    {

    }

    public class InstructorViewModel : UserViewModel
    {
        public string TeacherIdentification { get; set; }
    }
}
