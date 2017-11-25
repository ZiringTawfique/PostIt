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
            
            try
            {
             var x =  await _context.PostCollection.Find(_ => true).ToListAsync();
             return x;
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }



        public async Task AddPost(Post post)
        {
            try
            {
                await _context.PostCollection.InsertOneAsync(post);
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }
    }
}
