using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace PostIt.BackEnd.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        IGetUseCases _getUseCases;
        IPostUseCases _postUseCases;
        ISearchUseCases _searchUseCases;

        public ValuesController(IGetUseCases getCases, IPostUseCases postUseCases, ISearchUseCases searchUseCases)
        {
            _getUseCases = getCases;
            _postUseCases = postUseCases;
            _searchUseCases = searchUseCases;
        }

        // GET api/values
        //[NoCache]
        [HttpGet]
        public Task<ICollection<Post>> Search(string searchStr)
        {
            //TODO: make a class of all incoming parameters instead, pageno, pagesize ect..
            try{
                
                if (searchStr == null){
                    Logger.Error("Search parameters are null");
                }
               
            }
            catch(Exception e){
                Logger.Error(e);
            }
            return SearchInternalAsync(searchStr);
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
        public async Task<Post> Get(int id)
        {
            return await _getUseCases.GetSinglePost(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Post post)
        {
            _postUseCases.AddPost(post);

        }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
            
        //}

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _getUseCases.DeletePost(id);
        }

        #region PRIVATE METHODS
        private async Task<ICollection<Post>> GetPostInternalAsync() => await _getUseCases.GetAllPostAsync();
        private async Task<ICollection<Post>> SearchInternalAsync(string searchStr) => await _searchUseCases.SearchAsync(searchStr);
        #endregion

      
    
    }
}
