using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataView.DataEntities;

namespace DataView.Interface
{
    public interface IApplicationDataView
    {
        Task <ICollection<Post>> GetAllPostAsync();
        Task AddPost(Post post);
        Task<bool> DeletePost(int postId);
    }
}
