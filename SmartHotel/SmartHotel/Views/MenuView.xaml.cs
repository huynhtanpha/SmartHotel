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
    public partial class MenuView : ContentPage
    {
        public MenuView()
        {
            InitializeComponent();
            BookingRoom.Tapped += BookingRoom_Tapped;
            MyRoom.Tapped += MyRoom_Tapped;
            Suggesstion.Tapped += Suggesstion_Tapped;
            Concierge.Tapped += Concierge_Tapped;
            Logout.Tapped += Logout_Tapped;
        }

        private void BookingRoom_Tapped(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MainView mainView)
            {
                if (mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new BookingView());
                    mainView.IsPresented = false;
                }
            }
        }
        private void MyRoom_Tapped(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MainView mainView)
            {
                if (mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new MyRoomView());
                    mainView.IsPresented = false;
                }
            }
        }
        private void Suggesstion_Tapped(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MainView mainView)
            {
                if (mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new SuggesstionView());
                    mainView.IsPresented = false;
                }
            }
        }
        private void Concierge_Tapped(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MainView mainView)
            {
                if (mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new ConciergeView());
                    mainView.IsPresented = false;
                }
            }
        }
        private void Logout_Tapped(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MainView mainView)
            {
                if (mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new LoginView());
                    mainView.IsPresented = false;
                }
            }
        }
    }
}