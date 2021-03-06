﻿using SmartHotel.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartHotel.Services.Navigation;
using SmartHotel.ViewModels;
using Xamarin.Forms;

namespace SmartHotel
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            ServiceLocator.Instance.Build();
		    ServiceLocator.Instance.Resolve<INavigationService>().NavigateToAsync<LoginViewModel>();
		    //MainPage = new NavigationPage(new LoginView());
		    //MainPage = new SmartHotel.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
