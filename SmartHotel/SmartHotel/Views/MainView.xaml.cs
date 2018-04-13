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
    public partial class MainView : MasterDetailPage
    {
        public MainView()
        {
            InitializeComponent();
            //Back.Clicked += Back_Clicked;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
         //   if (Navigation.RemovePage(Navigation.NavigationStack[0]) is LoginView)
           //     Navigation.RemovePage(Navigation.NavigationStack[0]);
        }
        private void Back_Clicked(object sender, EventArgs e)
        {
            //chuyển về trang trước đó
            Navigation.PopAsync();
        }
    }
}