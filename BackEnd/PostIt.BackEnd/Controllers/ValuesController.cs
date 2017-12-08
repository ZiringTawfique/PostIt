using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace PostIt.BackEnd.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        IUseCases _useCases; 

        public ValuesController(IUseCases useCases)
        {
            _useCases = useCases;

        }

        // GET api/values
        //[NoCache]
        [HttpGet]
        public Task<ICollection<Post>> Get()
        {
            return GetPostInternalAsync();
        }

    

        // GET api/values/5
        [HttpGet("{id}")]
        public Task<Post> Get(int id)
        {
            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Post post)
        {
            _useCases.AddPost(post);

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

        #region PRIVATE METHODS

        private async Task<ICollection<Post>> GetPostInternalAsync() => await _useCases.GetAllPostAsync();
  

        #endregion

      
    
    }
}
