using MOD.Technologyservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Technologyservice.Repositories
{
    public interface ISkillRepository
    {
        List<Skill> GetSkills();
        void Add(Skill item);
        void Update(Skill item);
        void Delete(string id);
    }
}
