using System;
using System.Collections.Generic;
using Domain.Model;

namespace Domain.Ports
{
    public interface IRepository
    {
		void SetPost(Post post);

		void SetUserInfor();

		ICollection<Post> GetAllPost();

		Post GetSinglePost();

		User GetUserInfor();
    }
}
