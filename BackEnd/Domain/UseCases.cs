using System;
using System.Collections.Generic;
using Domain.Interfaces;
using Domain.Model;

namespace Domain
{
    public class UseCases: IUseCases
    {
        public UseCases( )
        {

        }

        public ICollection<Post> GetAllPost()
        {
            throw new NotImplementedException();
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

		}

        public void SetUserInfor()
        {
            throw new NotImplementedException();
        }
    }

}
