using System.Diagnostics;

namespace SensorSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnAccelerometerClicked(object sender, EventArgs e)
	{
        if (Accelerometer.Default.IsSupported)
        {
            if (!Accelerometer.Default.IsMonitoring)
            {
                Accelerometer.Default.ReadingChanged += Default_ReadingChanged;
                Accelerometer.Default.Start(SensorSpeed.UI);
            }

        }
        else
        {
            Debug.WriteLine("Accelerometer not support");

        }
    }

    private void OnCompassClicked(object sender, EventArgs e)
    {
        if (Compass.Default.IsSupported)
        {
            if (!Compass.Default.IsMonitoring)
            {
                Compass.Default.ReadingChanged += Default_CompassReadingChanged;
                Compass.Default.Start(SensorSpeed.UI);
            }

        }
        else
        {
            Debug.WriteLine("Accelerometer not support");

        }
    }

    private void Default_CompassReadingChanged(object sender, CompassChangedEventArgs e)
    {
        Debug.WriteLine("Compass:" + e.Reading);
    }

    private void Default_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
    {
        Debug.WriteLine("Accelerometer:" + e.Reading);
    }
}

