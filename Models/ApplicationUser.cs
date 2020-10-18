using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using User_Management_try.Data;

namespace User_Management_try.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }


        private readonly ApplicationDbContext context;

        public ApplicationUser(ApplicationDbContext _context)
        {
            context = _context;
        }
        public ApplicationUser Add(ApplicationUser user)
        {
            context.ApplicationUsers.Add(user);
            context.SaveChanges();
            return user;
        }

        public ApplicationUser Delete(int id)
        {
            ApplicationUser user = context.ApplicationUsers.Find(id);
            if (user != null)
            {
                context.ApplicationUsers.Remove(user);
                context.SaveChanges();

            }
            return user;
        }

        public IEnumerable<ApplicationUser> GetAllMovie()
        {
            return context.ApplicationUsers;
        }

        public ApplicationUser GetUser(int Id)
        {
            return context.ApplicationUsers.Find(Id);
        }

        public ApplicationUser Update(ApplicationUser userChanges)
        {
            var user = context.ApplicationUsers.Attach(userChanges);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return userChanges;
        }
    }

}
