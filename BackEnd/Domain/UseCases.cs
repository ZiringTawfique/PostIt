using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Model;
using Domain.Ports;

namespace Domain
{
    public class UseCases: IUseCases
    {
        IRepository _mongoRepo;
        public UseCases(IRepository MongoRepo )
        {
            _mongoRepo = MongoRepo;

        }

        public Task<ICollection<Post>> GetAllPostAsync()
        {
            return _mongoRepo.GetAllPostAsync();
        }

        public Post GetSinglePost()
        {
            throw new NotImplementedException();
        }

        public User GetUserInfor()
        {
            throw new NotImplementedException();
        }

        public void SetPost(Post Post)
		{
            _mongoRepo.SetPost(Post);
		}

        public void SetUserInfor()
        {
            throw new NotImplementedException();
        }
    }

}
