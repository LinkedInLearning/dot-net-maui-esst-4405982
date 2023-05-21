
using System.Diagnostics;

namespace VibrationSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
	    if (Vibration.Default.IsSupported == true)
		{
            Vibration.Default.Vibrate(TimeSpan.FromSeconds(2));
        }
		else
		{
			Debug.WriteLine("Vibrate not Supported");
		}
    }
}

