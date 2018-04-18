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
    public partial class MenuView : ContentPage
    {
        public MenuView()
        {
            InitializeComponent();
            BindingContext = new MenuViewModel();
            menuListView.ItemSelected += MenuListView_ItemSelected;
            //BookingRoom.Tapped += BookingRoom_Tapped;
            //MyRoom.Tapped += MyRoom_Tapped;
            //Suggesstion.Tapped += Suggesstion_Tapped;
            //Concierge.Tapped += Concierge_Tapped;
            //Logout.Tapped += Logout_Tapped;

        }


        private void MenuListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (menuListView.SelectedItem == null)
                return;

            menuListView.SelectedItem = null;

            switch (menuListView.SelectedItem.ToString())
            {

                case "Book a room":

                    if (Application.Current.MainPage is MainView mainView1)
                    {
                        if (mainView1.Detail is NavigationPage navigationPage)
                        {
                            navigationPage.PushAsync(new BookingView());
                            mainView1.IsPresented = false;
                        }
                    }
                    break;

                case "My room":
                    {
                        if (Application.Current.MainPage is MainView mainView2)
                        {
                            if (mainView2.Detail is NavigationPage navigationPage)
                            {
                                navigationPage.PushAsync(new MyRoomView());
                                mainView2.IsPresented = false;
                            }
                        }
                    }
                    break;


                case "Suggestion":
                    if (Application.Current.MainPage is MainView mainView3)
                    {
                        if (mainView3.Detail is NavigationPage navigationPage)
                        {
                            navigationPage.PushAsync(new SuggesstionView());
                            mainView3.IsPresented = false;
                        }
                    }
                    break;
                case "Concierge":
                    if (Application.Current.MainPage is MainView mainView4)
                    {
                        if (mainView4.Detail is NavigationPage navigationPage)
                        {
                            navigationPage.PushAsync(new ConciergeView());
                            mainView4.IsPresented = false;
                        }
                    }
                    break;
                case "Logout":

                    if (Application.Current.MainPage is MainView mainView5)
                    {
                        if (mainView5.Detail is NavigationPage navigationPage)
                        {
                            navigationPage.PushAsync(new LoginView());
                            mainView5.IsPresented = false;
                        }
                    }
                    break;
                default:
                    break;
            }

        }

        //private void BookingRoom_Tapped(object sender, EventArgs e)
        //{
        //    if (Application.Current.MainPage is MainView mainView)
        //    {
        //        if (mainView.Detail is NavigationPage navigationPage)
        //        {
        //            navigationPage.PushAsync(new BookingView());
        //            mainView.IsPresented = false;
        //        }
        //    }
        //}
        //private void MyRoom_Tapped(object sender, EventArgs e)
        //{
        //    if (Application.Current.MainPage is MainView mainView)
        //    {
        //        if (mainView.Detail is NavigationPage navigationPage)
        //        {
        //            navigationPage.PushAsync(new MyRoomView());
        //            mainView.IsPresented = false;
        //        }
        //    }
        //}
        //private void Suggesstion_Tapped(object sender, EventArgs e)
        //{
        //    if (Application.Current.MainPage is MainView mainView)
        //    {
        //        if (mainView.Detail is NavigationPage navigationPage)
        //        {
        //            navigationPage.PushAsync(new SuggesstionView());
        //            mainView.IsPresented = false;
        //        }
        //    }
        //}
        //private void Concierge_Tapped(object sender, EventArgs e)
        //{
        //    if (Application.Current.MainPage is MainView mainView)
        //    {
        //        if (mainView.Detail is NavigationPage navigationPage)
        //        {
        //            navigationPage.PushAsync(new ConciergeView());
        //            mainView.IsPresented = false;
        //        }
        //    }
        //}
        //private void Logout_Tapped(object sender, EventArgs e)
        //{
        //    if (Application.Current.MainPage is MainView mainView)
        //    {
        //        if (mainView.Detail is NavigationPage navigationPage)
        //        {
        //            navigationPage.PushAsync(new LoginView());
        //            mainView.IsPresented = false;
        //        }
        //    }
        //}
    }
}