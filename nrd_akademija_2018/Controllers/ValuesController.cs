using EF.context;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace nrd_akademija_2018.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        protected readonly IBlogContext _rt;

        public ValuesController(IBlogContext rt)
        {
            _rt = rt;

        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post()
        {


            //BlogContext kk = new BlogContext();
            _rt.Addnew();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
