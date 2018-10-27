using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly : XamlCompilation(XamlCompilationOptions.Compile)]
namespace Kelompok33
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; internal set; }
        public App()
        {
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new NavigationPage(new HalamanUtama());
            }
            //initializeComponent();

            //MainPage = new MainPageCS();
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
