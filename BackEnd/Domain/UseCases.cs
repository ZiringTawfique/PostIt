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

        public async Task<ICollection<Post>> GetAllPostAsync()
        {
            return await _mongoRepo.GetAllPostAsync();
        }

        public Post GetSinglePost()
        {
            throw new NotImplementedException();
        }

        public User GetUserInfor()
        {
            throw new NotImplementedException();
        }

        public void AddPost(Post Post)
		{
            _mongoRepo.AddPost(Post);
		}

        public void SetUserInfor()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeletePost(int postid){

            return await _mongoRepo.DeletePost(postid);
        }
    }

}
