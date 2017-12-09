using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Model;
using Domain.Ports;

namespace Domain
{
    public class GetUseCases: IGetUseCases
    {
        IRepository _mongoRepo;
        public GetUseCases(IRepository MongoRepo )
        {
            _mongoRepo = MongoRepo;

        }

        public async Task<ICollection<Post>> GetAllPostAsync()
        {
            return await _mongoRepo.GetAllPostAsync();
        }



        public async Task<Post> GetSinglePost(int postid)
        {
            return await _mongoRepo.GetSinglePost(postid);
        }

        public User GetUserInfor()
        {
            throw new NotImplementedException();
        }



        public async Task<bool> DeletePost(int postid){

            return await _mongoRepo.DeletePost(postid);
        }

    }

}
