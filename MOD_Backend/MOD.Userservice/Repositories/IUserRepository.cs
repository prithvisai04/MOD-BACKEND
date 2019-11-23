using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Userservice.Models;

namespace MOD.Userservice.Repositories
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        void Add(User item);
        void Update(User item);
        void Delete(string id);
        List<Mentor> SearchMentor(string Skill, string Timeslot);
        void ResetPassword(string email, string NewPass);
    }
}
