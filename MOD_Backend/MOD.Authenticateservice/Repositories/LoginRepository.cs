using MOD.Authenticateservice.Context;
using MOD.Authenticateservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Authenticateservice.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly LoginContext _context;
        public LoginRepository(LoginContext context)
        {
            _context = context;
        }
        public bool MentorLogin(string mid, string pwd)
        {
            Mentor obj = _context.Mentors.SingleOrDefault(data => data.Mentorid == mid && data.Password == pwd);
            {
                if (obj != null)
                    return true;
                else
                    return false;
            }
        }

        public bool UserLogin(string uid, string pwd)
        {
            User obj = _context.Users.SingleOrDefault(Data => Data.UId == uid && Data.Password == pwd);
            {
                if (obj != null)
                    return true;
                else
                    return false;
            }

        }
    }
}
