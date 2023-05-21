using System.Diagnostics;

namespace DeviceInfoSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnDeviceInfoClicked(object sender, EventArgs e)
	{
        Debug.WriteLine("端末");
        Debug.WriteLine("  Model:" + DeviceInfo.Current.Model);
        Debug.WriteLine("  Manufacturer:" + DeviceInfo.Current.Manufacturer);
        Debug.WriteLine("  Name:" + DeviceInfo.Current.Name);
        Debug.WriteLine("  Version:" + DeviceInfo.Current.VersionString);
        Debug.WriteLine("  Idiom:" + DeviceInfo.Current.Idiom);
        Debug.WriteLine("  Platform:" + DeviceInfo.Current.Platform);


        Debug.WriteLine("Display情報");
        Debug.WriteLine("  Pixel width:" + DeviceDisplay.Current.MainDisplayInfo.Width);
        Debug.WriteLine("  Pixel Height:" + DeviceDisplay.Current.MainDisplayInfo.Height);
        Debug.WriteLine("  Density:" + DeviceDisplay.Current.MainDisplayInfo.Density);
        Debug.WriteLine("  Orientation:" + DeviceDisplay.Current.MainDisplayInfo.Orientation);
        Debug.WriteLine("  Refresh Rate:" + DeviceDisplay.Current.MainDisplayInfo.RefreshRate);
    }
}

