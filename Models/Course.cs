using System.Collections.Generic;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using User_Management_try.Models;
using Microsoft.AspNetCore.Mvc;

namespace User_Management_try.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(8, ErrorMessage = "maximum of 8 characters")]
        [Remote(action:"CourseCodeExists",controller:"Course")]
        public string CourseCode { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string TItle { get; set; }

        [Required]
        [Display(Name = "Credit Hour")]
        [Range(0, 10)]
        public int CreditHour { get; set; }

        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }

        [Display(Name = "Course Start Date")]
        public DateTime CourseStartDate { get; set; }

        [Display(Name = "Course End Date")]
        public DateTime CourseEndDate { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }

        public ICollection<InstructorCourse> InstructorCourses { get; set; }

        public ICollection<BatchCourse> BatchCourses { get; set; }

        public Departement Departement { get; set; }

        public List<Course> Prerequisite { get; set; }

        public ICollection<Term> Terms { get; set; }
        // public ICollection<Instructor> Instructors { get; set; }
        // public ICollection<Resource> resources { get; set; }
        // public ICollection<Exam> Exams { get; set; }
        // public ICollection<Assignment> Assignments { get; set; }
        // public ICollection<Attendance> Attendances { get; set; }
        // public ICollection<lecture> Lectures { get; set; }

    }

    public class StudentCourse
    {
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }

    }
  

   public class InstructorCourse
    {
        public Guid InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }

    public class BatchCourse
    {
        public int BatchId { get; set; }
        public Batch Batch { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public CourseStatus CourseStatus { get; set; }
    }  
    public enum CourseStatus{
        completed, Inprogress, Incomplete
     }
}