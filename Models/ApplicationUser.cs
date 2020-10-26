using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using User_Management_try.Data;

namespace User_Management_try.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public virtual string FirstName { get; set; }

        [Required]
        public virtual string LastName { get; set; }

    }

    public class Administrator :ApplicationUser
    {
        public ApplicationUser User { get; set; }

    }

    public class Instructor : ApplicationUser
    {

        public ICollection<InstructorCourse> InstructorCourse { get; set; }

        public int DepartementId { get; set; }
        public Departement Departement { get; set; }
    }

    public class Student :ApplicationUser
    {

        public string StudentIdentification { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }


        public Batch Batch { get; set; }

        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male, Female
    }
}
