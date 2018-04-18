using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SmartHotel.iOS.Services;
using SmartHotel.Services;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(EmailServiceiOS))]

namespace SmartHotel.iOS.Services
{
    class EmailServiceiOS : IEmailService
    {
        public void Send(string email, string title, string content)
        {
            throw new NotImplementedException();
        }
    }
}