using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Routing;
using Vechiles.Models;
using Vechiles.Repository;
using Vechiles.Specification;

namespace Vechiles.Web.Controllers
{
    [RoutePrefix("api/vechiles")]
    public class VechileController : ApiController
    {
        private IRepository<Vechile> _vechileRepository;
        private IUnitOfWorkFactory _unitOfWorkFactory;
        public VechileController(IRepository<Vechile> vechileRepository, IUnitOfWorkFactory unitOfWorkFactory)
        {
            _vechileRepository = vechileRepository;
            _unitOfWorkFactory = unitOfWorkFactory;
        }
        [HttpGet]
        [Route]
        [ResponseType(typeof(IEnumerable<Vechile>))]
        public IHttpActionResult GetAllVechiles()
        {
            return Ok(_vechileRepository.());
        }
        [HttpPost]
        [Route("{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult ping(int id)
        {

            var vechile = _vechileRepository.Single(new Specification<Vechile>(s => s.Id == id));
            vechile.Status = true;
            _vechileRepository.AddOrUpdate(vechile);

            return Ok();
        }
    }
}
