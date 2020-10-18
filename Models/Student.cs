using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User_Management_try.Models
{
    public class Student : ApplicationUser
    {
        public string StudentIdentification { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }


        public Batch Batch { get; set; }

        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,Female
    }
}
