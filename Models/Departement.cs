using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace User_Management_try.Models
{
    public class Departement
    { 
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Instructor DepartementHead { get; set; }

        public ICollection<Instructor> Instructors { get; set; }

        public ICollection<Batch> Batchs { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
    public class Batch
    {
        [Key]
        public int Id { get; set; }

        public string BatchIdentifier { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Term> Terms { get; set; }

        public ICollection<BatchCourse> BatchCourses { get; set; }
        public Departement Departement { get; set; }
    }

    public class Term
    {
        [Key]
        public int id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime TermStartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime TermEndDate { get; set; }

        public ICollection<Course> Courses { get; set; }

        public int NumberOfCourses { get; set; }

        //public RegistationPeriod RegPeriod { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Registration Start Date")]
        public DateTime RegistrationStartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Registration End Date")]
        public DateTime RegistrationEndDate { get; set; }
    }
    //public class RegistationPeriod
    //{
    //    public int id { get; set; }
    //    [DataType(DataType.Date)]
    //    public DateTime StartDate { get; set; }
    //    [DataType(DataType.Date)]
    //    public DateTime EndDate { get; set; }
    //}
}
