﻿using System;
using System.Collections.Generic;
using System.Text;
using SmartHotel.ViewModels.Base;

namespace SmartHotel.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
         public MenuViewModel MenuViewModel { get; set; }

        public MainViewModel()
        {
            MenuViewModel = new MenuViewModel();
        }
    }
}
