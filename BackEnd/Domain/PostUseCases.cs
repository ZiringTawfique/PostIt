using System;
using Domain.Interfaces;
using Domain.Model;
using Domain.Ports;

namespace Domain
{
    public class PostUseCases : IPostUseCases
    {
        IRepository _mongoRepo;

        public PostUseCases(IRepository MongoRepo)
        {
            _mongoRepo = MongoRepo;
        }

        public void AddPost(Post Post)
        {
            _mongoRepo.AddPost(Post);
        }

        public void SetUserInfor()
        {
            throw new NotImplementedException();
        }
    }
}
