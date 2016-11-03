using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using SchoolPlan.Services.Interface;
using SchoolPlan.Web.Models;

namespace SchoolPlan.Web.Controllers
{
    public class ClassesController : ApiController
    {
        private readonly IClassService _classService;
        private readonly IMapper _mapper;

        public ClassesController(IClassService classService, IMapper mapper)
        {
            _classService = classService;
            _mapper = mapper;
        }

        // GET: api/Classes
        public IEnumerable<Class> Get()
        {
            var serviceClasses = _classService.GetClasses();
            return _mapper.Map<IEnumerable<Class>>(serviceClasses);
        }

        // GET: api/Classes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Classes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Classes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Classes/5
        public void Delete(int id)
        {
        }
    }
}
