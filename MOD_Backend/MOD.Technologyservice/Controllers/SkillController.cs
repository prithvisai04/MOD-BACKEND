using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.Technologyservice.Models;
using MOD.Technologyservice.Repositories;

namespace MOD.Technologyservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ISkillRepository _repository;
        public SkillController(ISkillRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Skill/GetSkills
        [HttpGet]
        [Route("GetSkills")]
        public IList<Skill> Get()
        {
            return _repository.GetSkills();
        }

        //// GET: api/Skill/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Skill/Add
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Skill item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Skill/Update/5
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public void Put(Skill item)
        {
            _repository.Update(item);
        }

        // DELETE: api/Skill/Delete
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(string id)
        {
            _repository.Delete(id);
        }
    }
}
