using System;
using System.Collections.Generic;
using PostIt.FrontEnd.Models;
using PostIt.FrontEnd.ViewModel;
using Xamarin.Forms;

namespace PostIt.FrontEnd
{
    public partial class PostListPage : ContentPage
    {
        public PostListPage()
        {
			BindingContext = new PostListsViewModel();
            InitializeComponent();
        }

		protected override void OnAppearing()
		{
			base.OnAppearing();
		}

		void OnPostListSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
			(BindingContext as PostListsViewModel).SelectPost(e.SelectedItem as Post);
        }
	}
}
