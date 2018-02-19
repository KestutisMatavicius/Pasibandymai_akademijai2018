using AutoMapper;
using EF.Automapper.Dto;
using EF.context;
using EF.models;
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
            List<BlogDto> blogDto = new List<BlogDto>();

            blogDto = _iMapper.Map<List<BlogDto>>(list);



            /*Blog kl = new Blog();

            var lis = new List<Blog>();
            kl.BlogId = 1;
            kl.Url = "lkj";

            Post p1 = new Post();

            p1.BlogId = 1;
            p1.PostId = 1;
            p1.Title = "Post1";
            kl.Post.Add(p1);
            lis.Add(kl);*/
            //return lis;

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
