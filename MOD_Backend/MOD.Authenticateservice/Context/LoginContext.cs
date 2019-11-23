using Microsoft.EntityFrameworkCore;
using MOD.Authenticateservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Authenticateservice.Context
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<Mentor> Mentors { get; set; }
    }
}
