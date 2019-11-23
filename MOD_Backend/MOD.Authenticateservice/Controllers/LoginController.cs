using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.Authenticateservice.Models;
using MOD.Authenticateservice.Repositories;

namespace MOD.Authenticateservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _repository;

        public LoginController(ILoginRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Login
        [HttpGet]
        [Route("Validate/{id}/{password}")]
        public Token Get(string id, string password)
        {
            if (_repository.UserLogin(id, password))
            {
                return new Token() { message = "User", token = GetToken() };
            }
            else if (_repository.MentorLogin(id, password))
            {
                return new Token() { message = "Mentor", token = GetToken() };

            }
            else if (id == "Admin" && password == "Admin")
            {
                return new Token() { message = "Admin", token = GetToken() };

            }
            else
            {
                return new Token() { message = "Invalid User", token = "" };

            }
        }
        public string GetToken()
        {
            return "";
        }
    }
}
