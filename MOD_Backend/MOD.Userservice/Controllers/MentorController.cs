using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.Userservice.Models;
using MOD.Userservice.Repositories;

namespace MOD.Userservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _repository;
        public MentorController(IMentorRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Mentor/GetMentors
        [HttpGet]
        [Route("GetMentors")]
        public List<Mentor> Get()
        {
            return _repository.GetMentors();
        }

        // POST: api/Mentor/Add
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Mentor item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Mentor/Update/5
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public IActionResult Put(Mentor item)
        {
            _repository.Update(item);
            return Ok("Record Updated ");
        }
        //put
        [HttpPut("{id}")]
        [Route("RstPass/{Email}/{NewPass}")]
        public void ResetPassword(string email, string NewPass)
        {
            _repository.ResetPassword(email, NewPass);
        }

        // DELETE: api/Mentor/Delete/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
