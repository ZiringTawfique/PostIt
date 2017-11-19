using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Ports
{
    public interface IRepository
    {
		void SetPost(Post post);

		void SetUserInfor();

        Task<ICollection<Post>> GetAllPostAsync();

		Post GetSinglePost();

		User GetUserInfor();
    }
}
