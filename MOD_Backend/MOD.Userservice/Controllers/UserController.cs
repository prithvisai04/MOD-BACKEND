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
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        // GET: api/User/GetUsers
        [HttpGet]
        [Route("GetUsers")]
        public List<User> Get()
        {
            return _repository.GetUsers();
        }

        // POST: api/User/Add
        [HttpPost("{item}")]
        [Route("PostUser/{item}")]
        public IActionResult Post(User item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/User/Update/5
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public void Put(User item)
        {
            _repository.Update(item);
        }

        // DELETE: api/User/Delete/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(string id)
        {
            _repository.Delete(id);
        }
        //put
        [HttpPut("{id}")]
        [Route("RstPass/{Email}/{NewPass}")]
        public void ResetPassword(string email, string NewPass)
        {
            _repository.ResetPassword(email,NewPass);
        }

        //GET: api/User/5
        [HttpGet("{Skill}/{Timeslot}", Name = "Get")]
        [Route("SearchMentor/{Skill}/{Timeslot}")]
        public List<Mentor> Get(string Skill, string Timeslot)
        {
            return _repository.SearchMentor(Skill, Timeslot);
        }


    }
}
