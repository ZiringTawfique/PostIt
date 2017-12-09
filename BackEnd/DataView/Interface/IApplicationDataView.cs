using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataView.DataEntities;

namespace DataView.Interface
{
    public interface IApplicationDataView
    {
        Task<ICollection<Post>> SearchAsync(string searchStrn);
        Task <ICollection<Post>> GetAllPostAsync();
        Task<Post> GetSinglePost(int postid);
        Task AddPost(Post post);
        Task<bool> DeletePost(int postId);
    }
}
