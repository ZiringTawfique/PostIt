using System;
using System.Net.Http;
using System.Threading.Tasks;
using BackEndService.Interfaces;
using Model;

namespace BackEndService
{

	public class PostService : BackEndService, IPostService
	{
		const string path = "api/home/";
		public PostService(HttpClient client) : base(client, path)
		{
		}

		public async Task<Post> GetAPost(int postId)
		{
			return await GetStringAsync<Post>(postId.ToString());
		}



	}
}

