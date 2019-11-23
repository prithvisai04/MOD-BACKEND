using MOD.Trainingservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Trainingservice.Repositories
{
    public interface ITrainingRepository
    {
        List<Trainings> GetTrainings();
        void Add(Trainings item);

        void Update(Trainings item);
        void Delete(string id);
    }
}
