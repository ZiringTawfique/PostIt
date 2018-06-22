using System;
using System.Net.Http;
using System.Net.Http.Headers;
using BackEndService;
using BackEndService.Interfaces;
using CommonServiceLocator;
using PostIt.FrontEnd.ViewModel;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.ServiceLocation;

namespace PostIt.FrontEnd
{
    public class ViewModelLocator
    {
		private UnityContainer _unityContainer;
	
		#region Get ViewModels
		public PostListsViewModel PostListsViewModel => _unityContainer.Resolve<PostListsViewModel>();

        #endregion


		public ViewModelLocator()
        {
			_unityContainer = new UnityContainer();      
			RegisterType(_unityContainer);         
			var unityServiceLocator = new UnityServiceLocator(_unityContainer);
			ServiceLocator.SetLocatorProvider(() => unityServiceLocator);         
        }


		private static void RegisterType(UnityContainer _unityContainer)
		{
			_unityContainer.RegisterType<IPostService, PostService>();
			_unityContainer.RegisterType<PostListsViewModel>(new ContainerControlledLifetimeManager());
			_unityContainer.RegisterType<HttpClient>(
              new InjectionFactory(
                  h =>
                  {
                      var httpClient = new HttpClient
					  { //TODO: save value in a config file instead.
					
					      BaseAddress = new Uri("http://localhost:5000/"),  
                          DefaultRequestHeaders = { Accept = { new MediaTypeWithQualityHeaderValue("application/json") } }
                      };
                      return httpClient;
                  }));
		}
    }
}
