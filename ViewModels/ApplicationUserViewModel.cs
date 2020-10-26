using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace User_Management_try.Models
{
    public class UserViewModel :ApplicationUser
    {
        [Required]
        public override string FirstName { get; set; }

        [Required]
        public override string LastName { get; set; }


        [Required]
        [EmailAddress]
        public override string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class StudentViewModel : UserViewModel
    {
        public string StudentIdentification { get; set; }

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
