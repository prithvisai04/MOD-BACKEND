using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.Userservice.Models;


namespace MOD.Userservice.Context
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) :
            base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<Mentor> Mentors { get; set; }

        public DbSet<Trainings> Training { get; set; }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<Payment> Payments { get; set; }

        


    }
}
