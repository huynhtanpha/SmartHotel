using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SmartHotel.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _userName;
        private string _password;
        private string _passwordStrength;
        public string UserName
        {
            get => _userName;
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    if (PropertyChanged != null)
                    {
                        RaisePropertyChanged(nameof(UserName));
                    }
                }
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string PasswordStrength {
            get => _passwordStrength;
            set
            {
                if (_passwordStrength != value)
                {
                    _passwordStrength = value;
                    if (PropertyChanged != null)
                    {
                        RaisePropertyChanged(nameof(PasswordStrength));
                    }
                }
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    if (PropertyChanged != null)
                    {
                        RaisePropertyChanged(nameof(Password));
                        if (_password != null && _password.Length >= 6)
                            PasswordStrength = "Good";
                        else
                            PasswordStrength = "Invalid";
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //public void SetUserName(string value)
        //{
        //    UserName = value;

        //}
    }
}
