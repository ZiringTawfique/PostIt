using System;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using DataView.Interface;
using DataView.DataEntities;
using Domain.Aggregate;

namespace DataView
{
    public class ApplicationDataView : IApplicationDataView
    {
        private readonly MongoDBContext _context = null;


        public ApplicationDataView(IOptions<MongoDBSettings> settings)
        {
            _context = new MongoDBContext(settings);
        }

		public async Task<ICollection<Post>> SearchAsync(SearchParameters searchParameter)
        {

            try
            {
                _context.PostCollection.Indexes.CreateOne(Builders<Post>.IndexKeys.Text(x => x.Title));
                
				var searchResult= await _context.PostCollection.Find(Builders<Post>.Filter.Text(searchParameter.SearchWord)).ToListAsync();

                return searchResult;

            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public async Task<ICollection<Post>> GetAllPostAsync()
        {
            
            try
            {
                
             var allPosts =  await _context.PostCollection.Find(_ => true).ToListAsync();
             
             return allPosts;

            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }


        public async Task<ICollection<Post>> GetMyPostsAsync(string username)
        {
            try
            {
                var filter = Builders<Post>.Filter.Eq(x => x.User.Username, username);
                
                var myPosts = await _context.PostCollection.FindSync(filter).ToListAsync();

                return myPosts;
            }


            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Post> GetSinglePost(int postid)
        {
            var filter = Builders<Post>.Filter.Eq(x => x.PostId, postid);

            try
            {
                var singlePost = await _context.PostCollection.Find(filter).FirstOrDefaultAsync();
          
                return singlePost;

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

        public async Task<bool> DeletePost(int postId){
            try
            {
                var builder = Builders<Post>.Filter;
                var filter = builder.Eq(x => x.PostId, postId);
                var deletePost =  await _context.PostCollection
                                                .DeleteOneAsync(filter);

                return deletePost.IsAcknowledged && deletePost.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }

        }

    }
}
