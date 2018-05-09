using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SmartHotel.Mvvm.Commands;
using SmartHotel.Services;
using SmartHotel.Services.Authentications;
using SmartHotel.ViewModels.Base;

namespace SmartHotel.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _userName;
        private string _password;

        private IAuthenticationService _authenticationService;
        //private string _passwordStrength;
        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value, ()=>{LoginCommand.RaiseCanExecuteChanged();});

        }

        public LoginViewModel(IAuthenticationService authenticationService)
        {
            LoginCommand = new DelegateCommand(Login, CanLogin).ObservesProperty(() => UserName)
                .ObservesProperty(() => Password);
        }

        

        private void Login()
        {
           //TODO
            NavigationService.NavigateToAsync<MainViewModel>();
        }

        private bool CanLogin()
        {
            return !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value, ()=>{LoginCommand.RaiseCanExecuteChanged();});

        }
 
        public  DelegateCommand LoginCommand { get; }
        public void SetUserName(string value)
        {
            UserName = value;
        }


    }
}
