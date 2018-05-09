using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHotel.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyEntry : ContentView
    {
        public MyEntry()
        {
            InitializeComponent();
        }
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(MyEntry), null,BindingMode.TwoWay);
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
    }
}