using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Userservice.Context;
using MOD.Userservice.Models;

namespace MOD.Userservice.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public void Add(User item)
        {
            _context.Users.Add(item);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var item = _context.Users.Find(id);
            _context.Users.Remove(item);
            _context.SaveChanges();
        }

        public void Update(User item)
        {
            _context.Entry(item).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public void ResetPassword(string email, string NewPass)
        {
            var resetPass = _context.Users.SingleOrDefault(i => i.Email == email);
            resetPass.Password = NewPass;
            _context.SaveChanges();
        }

        public List<Mentor> SearchMentor(string Skill, string Timeslot)
        {
            var searchMentors = _context.Mentors.Where(searchMentors => searchMentors.Skills == Skill ||
            searchMentors.timeslot == Timeslot).ToList();
            return searchMentors;
        }

        
    }
}
