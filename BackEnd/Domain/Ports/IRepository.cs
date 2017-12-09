﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Ports
{
    public interface IRepository
    {
		void AddPost(Post post);

		void SetUserInfor();

        Task<bool>  DeletePost(int postid);

        Task<ICollection<Post>> SearchAsync(string searchStr);

        Task<ICollection<Post>> GetAllPostAsync();

        Task<Post> GetSinglePost(int postid);

		User GetUserInfor();
    }
}
