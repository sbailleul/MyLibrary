using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(CustomConventions))]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ConventionTestsController : ControllerBase
    {
        // GET: api/ConventionTests
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] {"value1", "value2"};
        }

        // GET: api/ConventionTests/5
        [HttpGet("{id}", Name = "Get")]
        //[ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ConventionTests
        [HttpPost]
        // [ApiConventionMethod(typeof(CustomConventions), nameof(CustomConventions.Insert))]
        public void Insert([FromBody] string value)
        {
        }

        // PUT: api/ConventionTests/5
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