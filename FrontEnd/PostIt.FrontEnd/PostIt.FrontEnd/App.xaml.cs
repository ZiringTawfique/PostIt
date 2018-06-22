using BackEndService;
using BackEndService.Interfaces;
using PostIt.FrontEnd.Views;
using Unity;
using Xamarin.Forms;

namespace PostIt.FrontEnd
{
    public partial class App : Application
    {
		public static UnityContainer UnityContainer { get; set; }

        public App()
        {
            InitializeComponent();
			var nav = new NavigationPage(new PostListPage());
            MainPage = nav;       
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
