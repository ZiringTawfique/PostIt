using System;
using System.Collections.Generic;
using Domain.Model;

namespace Domain.Interfaces
{
    public interface IUseCases
    {
        void SetPost(Post post);

        void SetUserInfor();

        ICollection<Post> GetAllPost();

        Post GetSinglePost();

        User GetUserInfor();
    }
}   
