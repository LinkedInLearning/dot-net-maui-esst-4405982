using System.Diagnostics;

namespace GeolocationSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));

        CancellationTokenSource source = new CancellationTokenSource();

        Location location = await Geolocation.Default.GetLocationAsync(request, source.Token);

		latitude.Text = "緯度:" + location.Latitude;
		longitude.Text = "経度:" + location.Longitude;
    }
}

