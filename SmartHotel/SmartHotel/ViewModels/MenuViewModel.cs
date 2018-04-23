using System;
using System.Collections.Generic;
using SmartHotel.Mvvm.Commands;
using SmartHotel.Services.Navigation;
using Xamarin.Forms.Internals;

namespace SmartHotel.ViewModels
{
    public class MenuViewModel
    {
        public class MenuItem
        {
            public string Icon { get; set; }
            public string Title { get; set; }   
            public  Type ViewModelType { get; set; }
        }
        public List<MenuItem> Menu { get; set; }
        public MenuViewModel()
        {
            Menu = new List<MenuItem>
           {
               new MenuItem{Icon ="ic_bed", Title= "Book a room", ViewModelType = typeof(BookingViewModel)},
               new MenuItem{Icon ="ic_key", Title= "My room"},
               new MenuItem{Icon ="ic_beach", Title= "Suggestion"},
               new MenuItem{Icon ="ic_bot", Title= "Concierge"},
               new MenuItem{Icon ="ic_logout", Title= "Logout"}
           };
            MenuCommand = new DelegateCommand<object>(Selected);
        }

        private void Selected(object p)
        {
            if (p is MenuItem menuItem && menuItem.ViewModelType != null)
            {
               //NavigationService.NavigateToAsync(menuItem.ViewModelType);
            }                                             
        }

        public DelegateCommand<object> MenuCommand { get; }
    }
}
