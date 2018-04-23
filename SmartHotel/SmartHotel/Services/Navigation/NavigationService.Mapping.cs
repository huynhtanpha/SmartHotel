using System;
using System.Collections.Generic;
using System.Text;
using SmartHotel.ViewModels;
using SmartHotel.ViewModels.Base;
using SmartHotel.Views;
using Xamarin.Forms;

namespace SmartHotel.Services.Navigation
{
    public partial class NavigationService
    {
        private void Mapping()
        {
            Map<LoginViewModel, LoginView>();
            Map<HomeViewModel, HomeView>();
            Map<MainViewModel, MainView>();
        }
        private void Map<TViewModel, TView>() where TViewModel : ViewModelBase where TView : Page
        {
            _mappings.Add(typeof(TViewModel), typeof(TView));


        }
    }
}
