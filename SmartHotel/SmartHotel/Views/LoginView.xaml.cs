using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
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
	public partial class LoginView : ContentPage
	{
        private LoginViewModel LoginViewModel { get; }
		public LoginView ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);

            LoginViewModel loginViewModel = new LoginViewModel();
            this.BindingContext = loginViewModel;
            //loginViewModel.SetUserName("ABCD");
            SignUp.Clicked += SignUp_Clicked;
            
            //takePhoto.Clicked += async (sender, args) =>
            //{

            //    if (!CrossMedia.Instance.IsCameraAvailable || !CrossMedia.Instance.IsTakePhotoSupported)
            //    {
            //        DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
            //        return;
            //    }

            //    var file = await CrossMedia.Instance.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            //    {
            //        Directory = "Test",
            //        SaveToAlbum = true,
            //        CompressionQuality = 75,
            //        CustomPhotoSize = 50,
            //        PhotoSize = PhotoSize.MaxWidthHeight,
            //        MaxWidthHeight = 2000,
            //        DefaultCamera = CameraDevice.Front
            //    });

            //    if (file == null)
            //        return;

            //    DisplayAlert("File Location", file.Path, "OK");

            //    image.Source = ImageSource.FromStream(() =>
            //    {
            //        var stream = file.GetStream();
            //        file.Dispose();
            //        return stream;
            //    });
            //};

            //pickPhoto.Clicked += async (sender, args) =>
            //{
            //    if (!CrossMedia.Instance.IsPickPhotoSupported)
            //    {
            //        DisplayAlert("Photos Not Supported", ":( Permission not granted to photos.", "OK");
            //        return;
            //    }
            //    var file = await Plugin.Media.CrossMedia.Instance.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            //    {
            //        PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,

            //    });


            //    if (file == null)
            //        return;

            //    image.Source = ImageSource.FromStream(() =>
            //    {
            //        var stream = file.GetStream();
            //        file.Dispose();
            //        return stream;
            //    });
            //};

            //takeVideo.Clicked += async (sender, args) =>
            //{
            //    if (!CrossMedia.Instance.IsCameraAvailable || !CrossMedia.Instance.IsTakeVideoSupported)
            //    {
            //        DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
            //        return;
            //    }

            //    var file = await CrossMedia.Instance.TakeVideoAsync(new Plugin.Media.Abstractions.StoreVideoOptions
            //    {
            //        Name = "video.mp4",
            //        Directory = "DefaultVideos",
            //    });

            //    if (file == null)
            //        return;

            //    DisplayAlert("Video Recorded", "Location: " + file.Path, "OK");

            //    file.Dispose();
            //};

            //pickVideo.Clicked += async (sender, args) =>
            //{
            //    if (!CrossMedia.Instance.IsPickVideoSupported)
            //    {
            //        DisplayAlert("Videos Not Supported", ":( Permission not granted to videos.", "OK");
            //        return;
            //    }
            //    var file = await CrossMedia.Instance.PickVideoAsync();

            //    if (file == null)
            //        return;

            //    DisplayAlert("Video Selected", "Location: " + file.Path, "OK");
            //    file.Dispose();
            //};
        }

        private void SignUp_Clicked(object sender, EventArgs e)
        {
          
        }
    }
}