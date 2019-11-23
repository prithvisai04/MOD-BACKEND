using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.Paymentservice.Models;
using MOD.Paymentservice.Repositories;

namespace MOD.Paymentservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _repository;
        public PaymentController(IPaymentRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Payment/GetPayments
        [HttpGet]
        [Route("GetPayments")]
        public IList<Payment> Get()
        {
            return _repository.GetPayments();
        }

        //// GET: api/Payment/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Payment/Add
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Payment item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Payment/Update/
        //[HttpPut("{id}")]
        //[Route("Update/{id}")]
        //public void Put(Payment item)
        //{
        //    _repository.Update(item);
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
