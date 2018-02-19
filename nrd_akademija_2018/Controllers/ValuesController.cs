using AutoMapper;
using EF.Automapper.Dto;
using EF.context;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace nrd_akademija_2018.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        protected readonly IBlogContext _rt;
        private readonly IMapper _iMapper;

        public ValuesController(IBlogContext rt, IMapper iMapper)
        {
            _rt = rt;
            _iMapper = iMapper;

        }
        // GET api/values
        [HttpGet]
        public List<BlogDto> Get()
        {
            var list = _rt.GetAll();

            var blogDto = _iMapper.Map<List<BlogDto>>(list);
            return blogDto;

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
