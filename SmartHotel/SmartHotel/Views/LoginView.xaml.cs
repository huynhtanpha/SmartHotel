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
		public LoginView ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            SignUp.Clicked += SignUp_Clicked;
		}

        private void SignUp_Clicked(object sender, EventArgs e)
        {
            if(UserNameEntry.Text == null || Password.Text == null)
            {
                DisplayAlert("Error", "Please, Input your user name or password", "OK");
            }
            if (UserNameEntry.Text == "phahuynh" && Password.Text == "123456")
            {
                //Chuyển qua trang mới
              //  Navigation.PushAsync(new MainView());
                App.Current.MainPage = new MainView();
            }
        }
    }
}