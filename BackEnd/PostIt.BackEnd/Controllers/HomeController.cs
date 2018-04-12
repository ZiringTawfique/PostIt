using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Aggregate;
using Domain.Interfaces;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using NLog;

namespace PostIt.BackEnd.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        // private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        IGetUseCases _getUseCases;
        IPostUseCases _postUseCases;
        ISearchUseCases _searchUseCases;
        private readonly ILogger _logger;

        public HomeController(IGetUseCases getCases, IPostUseCases postUseCases, ISearchUseCases searchUseCases, ILogger<HomeController> logger)
        {
            _getUseCases = getCases;
            _postUseCases = postUseCases;
            _searchUseCases = searchUseCases;
            _logger = logger;
        }
       
        #region Get
        // GET api/Home
        //[NoCache]
        [HttpGet]
        public Task<ICollection<Post>> Index()
        {
            return GetPostInternalAsync();
        }


        // GET api/Home/5
        [HttpGet("{id}")]
        public async Task<Post> Get(int id)
        {
            return await _getUseCases.GetSinglePost(id);
        }

        [HttpGet("my-posts")]
        public async Task<ICollection<Post>> GetMyPosts(string username)
        {
            return await _getUseCases.GetMyPosts(username);
        }

        #endregion
 
        #region Post

        ////[NoCache]
        [HttpPost("search")]
        public Task<ICollection<Post>> Search([FromBody] SearchParameters searchParameter)
        {

            try
            {

                if (searchParameter == null)
                {
                    _logger.LogWarning("search object is null({ID})", searchParameter);
                    // Logger.Error("Search parameters are null");

                }


            }
            catch (Exception e)
            {
                _logger.LogError("searching error ({e})", e);
            }
            return SearchInternalAsync(searchParameter);
        }


        // POST api/Home
        [HttpPost("add-a-post")]
        public void Post([FromBody] Post post)
        {
            _postUseCases.AddPost(post);

        }

        #endregion

        //// PUT api/Home/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{

        //}



        #region Delete

       

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _getUseCases.DeletePost(id);
        }

        #region PRIVATE METHODS
        private async Task<ICollection<Post>> GetPostInternalAsync() => await _getUseCases.GetAllPostAsync();
        private async Task<ICollection<Post>> SearchInternalAsync(SearchParameters searchParameter) => await _searchUseCases.SearchAsync(searchParameter);
        #endregion



    }

        #endregion
}
