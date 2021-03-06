﻿using System;
using System.Collections.Generic;
using BackEndService.Interfaces;
using CommonServiceLocator;
using Model;
using PostIt.FrontEnd.ViewModel;
using Xamarin.Forms;

namespace PostIt.FrontEnd.Views
{
    public partial class PostListPage : ContentPage
    {
		
		public PostListPage()
		{
            InitializeComponent();
        }

		protected override void OnAppearing()
		{
			base.OnAppearing();


		}
		 void OnButtonClicked(object sender, EventArgs args)
        {
			(BindingContext as PostListsViewModel).GetAPost(1);
            
        }
	

		void OnPostListSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
			(BindingContext as PostListsViewModel).SelectPost(e.SelectedItem as Post);
        }

	
	}
}
