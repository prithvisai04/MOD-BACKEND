using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Trainingservice.Context;
using MOD.Trainingservice.Models;

namespace MOD.Trainingservice.Repositories
{
    public class TrainingRepository : ITrainingRepository
    {
        private readonly TrainingContext _context;
        public TrainingRepository(TrainingContext context)
        {
            _context = context;
        }
        public void Add(Trainings item)
        {
            _context.Training.Add(item);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var item = _context.Training.Find(id);
            _context.Training.Remove(item);
            _context.SaveChanges();
        }

        public List<Trainings> GetTrainings()
        {
            return _context.Training.ToList();
        }

        public void Update(Trainings item)
        {
            _context.Entry(item).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

        }
    }
}
