using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Interfaces
{
    public interface IGetUseCases
    {
        Task<bool> DeletePost(int postid);

        Task<ICollection<Post>> GetAllPostAsync();

        Task<Post> GetSinglePost(int postid);

        Task<ICollection<Post>> GetMyPosts(string username);
       
        User GetUserInfor();
    }
}   
