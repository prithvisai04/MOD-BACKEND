using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Technologyservice.Context;
using MOD.Technologyservice.Models;

namespace MOD.Technologyservice.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly SkillContext _context;
        public SkillRepository(SkillContext context)
        {
            _context = context;
        }

        public void Add(Skill item)
        {
            _context.Skills.Add(item);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var item = _context.Skills.Find(id);
            _context.Skills.Remove(item);
            _context.SaveChanges();
        }

        public List<Skill> GetSkills()
        {
            return _context.Skills.ToList();
        }

        public void Update(Skill item)
        {
            _context.Entry(item).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
