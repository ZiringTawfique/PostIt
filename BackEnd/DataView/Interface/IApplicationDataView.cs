using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataView.DataEntities;
using Domain.Aggregate;
namespace DataView.Interface
{
    public interface IApplicationDataView
    {
		Task<ICollection<Post>> SearchAsync(SearchParameters searchParameter);
        Task<ICollection<Post>> GetAllPostAsync();
        Task<ICollection<Post>> GetMyPostsAsync(string username);
        Task<Post> GetSinglePost(int postid);
        Task AddPost(Post post);
        Task<bool> DeletePost(int postId);
    }
}
