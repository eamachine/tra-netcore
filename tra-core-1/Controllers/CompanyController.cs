using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tra_core_1.Business;
using tra_core_1.Model;

namespace tra_core_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        IRepositoryCompany repositoryCompany;
        public CompanyController(IRepositoryCompany repositoryCompany)
        {
            this.repositoryCompany = repositoryCompany;
        }

        // GET: api/Company
        [HttpGet]
        public Company Get()
        {
            return repositoryCompany.GetCompany();
        }

        // GET: api/Company/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Company
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Company/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
