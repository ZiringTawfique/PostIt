using System;
using System.Collections.ObjectModel;
using PostIt.FrontEnd.Models;

namespace PostIt.FrontEnd.ViewModel
{
    public class PostListsViewModel
    {
		public ObservableCollection<Post> PostLists { get; private set; } = new ObservableCollection<Post>();
		public Post SelectedPost { get; set; }

		public void SelectPost(Post post){

			if (post == null)
				return;


			SelectedPost = null;

		}
    }
}
