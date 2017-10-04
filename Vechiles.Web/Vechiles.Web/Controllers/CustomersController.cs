using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Vechiles.DTO;
using Vechiles.Models;
using Vechiles.Repository;

namespace Vechiles.Web.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        private IRepository<Customer> _customerRepository;
        public CustomersController(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        [HttpGet]
        [Route]
        [ResponseType(typeof(IEnumerable<CustomerDTO>))]
        public IHttpActionResult GetAllCustomers()
        {
            return Ok(_customerRepository.GetAll<CustomerDTO>());
        }
    }
}
