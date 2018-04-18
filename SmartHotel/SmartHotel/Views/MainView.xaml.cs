using SmartHotel.Services;
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
            //Call dependency service
            var serviceEmail = DependencyService.Get<IEmailService>();
            serviceEmail.Send("abc@gmail.com", "Hello", "Hello kun");
            buttonBasicMap.Clicked += (_, e) => Navigation.PushAsync(new BasicMapPage());
            buttonCamera.Clicked += (_, e) => Navigation.PushAsync(new CameraPage());
            buttonPins.Clicked += (_, e) => Navigation.PushAsync(new PinsPage());
            buttonShapes.Clicked += (_, e) => Navigation.PushAsync(new ShapesPage());
            buttonShapes2.Clicked += (_, e) => Navigation.PushAsync(new Shapes2Page());
            buttonTiles.Clicked += (_, e) => Navigation.PushAsync(new TilesPage());
            buttonCustomPins.Clicked += (_, e) => Navigation.PushAsync(new CustomPinsPage());
            buttonShapesWithInitialize.Clicked += (_, e) => Navigation.PushAsync(new ShapesWithInitializePage());
            buttonBindingPin.Clicked += (_, e) => Navigation.PushAsync(new BindingPinViewPage());
            buttonGroundOverlays.Clicked += (_, e) => Navigation.PushAsync(new GroundOverlaysPage());
            buttonMapStyles.Clicked += (_, e) => Navigation.PushAsync(new MapStylePage());
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