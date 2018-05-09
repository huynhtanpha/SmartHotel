using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using SmartHotel.Droid.Renderers;
using SmartHotel.Controls;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace SmartHotel.Droid.Renderers
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class ExtendedEntryRenderer : EntryRenderer
    {
        public ExtendedEntry ExtendedEntryElement => Element as ExtendedEntry;

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.InputType |= Android.Text.InputTypes.TextFlagNoSuggestions;
                UpdateLineColor();
            }
        }       
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName.Equals(nameof(ExtendedEntry.LineColorToApply)))
            {
                UpdateLineColor();
            }
        }

        private void UpdateLineColor()
        {
            Control?.Background?.SetColorFilter(ExtendedEntryElement.LineColorToApply.ToAndroid(), Android.Graphics.PorterDuff.Mode.SrcAtop);
        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}