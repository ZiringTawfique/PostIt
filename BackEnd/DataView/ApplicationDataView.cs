using System;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using DataView.Interface;
using DataView.DataEntities;

namespace DataView
{
    public class ApplicationDataView : IApplicationDataView
    {
        private readonly MongoDBContext _context = null;


        public ApplicationDataView(IOptions<MongoDBSettings> settings)
        {
            _context = new MongoDBContext(settings);
        }

        public async Task<ICollection<Post>> GetAllPostAsync()
        {
            var allPosts = new List<Post>();
            try
            {
                var dataPost = new Post { 
                    PostId = 1,
                    isUrgent = true,
                    Title = "Getting post data entity"
                };

                var dataPost2 = new Post
                {
                    PostId = 2,
                    isUrgent = true,
                    Title = "Getting post data entity22"
                };
                allPosts.Add(dataPost);
                allPosts.Add(dataPost2);
                return allPosts;
                //return await _context.AppUsers.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }
    }
}
