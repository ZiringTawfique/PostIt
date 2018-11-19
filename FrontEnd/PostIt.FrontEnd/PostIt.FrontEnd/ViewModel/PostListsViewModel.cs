using System;
using System.Collections.ObjectModel;
using BackEndService;
using BackEndService.Interfaces;
using Model;

namespace PostIt.FrontEnd.ViewModel
{
    public class PostListsViewModel
    {
		private readonly IPostService _postService;
		public ObservableCollection<Post> PostLists { get; private set; } = new ObservableCollection<Post>();
        public Post SelectedPost { get; set; }

		public PostListsViewModel(IPostService postService)

		{
			_postService = postService;
		}

		public void GetAPost(int postId)
		{
			_postService.GetAPost(postId);
		}
        
    
		public void SelectPost(Post post)
		{

			if (post == null)
				return;
                
			SelectedPost = new Post{ Price=1};

		}
    }
}







