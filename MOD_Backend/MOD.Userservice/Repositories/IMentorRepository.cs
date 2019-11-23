using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Userservice.Models;

namespace MOD.Userservice.Repositories
{
    public interface IMentorRepository
    {
        List<Mentor> GetMentors();
        void Add(Mentor item);
        void Update(Mentor item);
        void Delete(int id);
        void ResetPassword(string email, string NewPass);








    }
}
