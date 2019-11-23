using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.Trainingservice.Models;
using MOD.Trainingservice.Repositories;

namespace MOD.Trainingservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepository _repository;
        public TrainingController(ITrainingRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Training/GetTrainings
        [HttpGet]
        [Route("GetTrainings")]
        public IList<Trainings> Get()
        {
            return _repository.GetTrainings();
        }

        //// GET: api/Training/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Training/Add
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Trainings item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Training/Update/5
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public void Put(Trainings item)
        {
            _repository.Update(item);
        }

        // DELETE: api/Training/Delete
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(string id)
        {
            _repository.Delete(id);
        }
    }
}
