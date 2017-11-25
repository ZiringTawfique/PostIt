using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Interfaces
{
    public interface IUseCases
    {
        void AddPost(Post post);

        void SetUserInfor();

        Task<ICollection<Post>> GetAllPostAsync();

        Post GetSinglePost();

        User GetUserInfor();
    }
}   
