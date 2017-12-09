using System;
using Domain.Model;

namespace Domain.Interfaces
{
    public interface IPostUseCases
    {
        void AddPost(Post post);
        void SetUserInfor();

    }
}
