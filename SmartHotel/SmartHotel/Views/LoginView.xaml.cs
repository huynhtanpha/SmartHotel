using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using SmartHotel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        private LoginViewModel LoginViewModel { get; }
        public LoginView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            //LoginViewModel loginViewModel = new LoginViewModel();
            //this.BindingContext = loginViewModel;
            //loginViewModel.SetUserName("ABCD");
            SignUp.Clicked += SignUp_Clicked;

        }

        private void SignUp_Clicked(object sender, EventArgs e)
        {

        }
    }
}