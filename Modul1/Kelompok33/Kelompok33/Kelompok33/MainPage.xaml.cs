using Kelompok33;
using Kelompok33.Model;
using Kelompok33.View;
using System;
using Xamarin.Forms;

namespace Kelompok33
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
        }
        public void Remove_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var data = button.BindingContext as DataMahasiswa;
            var vm = BindingContext as HalamanLihatData;

            vm.RemoveCommand.Execute(data);
        }
    }
}
