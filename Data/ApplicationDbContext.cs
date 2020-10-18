using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Management_try.Models;

namespace User_Management_try.Data
{
    public class ApplicationDbContext :IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUser>().ToTable("Users"); // Your custom IdentityUser class
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            //primary key not defined error
            //caused by not caaling the base class on model creating method
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Entity<InstructorCourse>().HasKey(ic => new { ic.InstructorId, ic.CourseId });

            //modelBuilder.Entity<Batch>()
            //.HasMany(b => b.Students)
            //.WithOne(s => s.Batch)
            //.IsRequired()
            //.OnDelete(DeleteBehavior.SetNull);

            //.HasForeignKey(s => s.CurrentGradeId);
            // modelBuilder
            //.Entity<>()
            //.HasOne<Team>(e => e.Team1)
            //.WithMany(e => e.Matches)
            //.OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>()
            .HasAlternateKey(c => c.CourseCode)
            .HasName("CourseCode");
        }

        //keys of identity tables are maped in onmodelcreating
        public DbSet<Administrator> Administrators { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Departement> Departements { get; set; }

        public DbSet<Batch> Batchs { get; set; }

        public DbSet<Term> Terms { get; set; }
        public object T { get; internal set; }
    }

}

