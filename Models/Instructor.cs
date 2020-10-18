using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User_Management_try.Models
{
    public class Instructor :ApplicationUser
    {

        public ICollection<InstructorCourse> InstructorCourse { get; set; }

        public int DepartementId { get; set; }
        public Departement Departement { get; set; }
    }
}
