using System.Diagnostics;

namespace TapGestureSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}


    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		Debug.WriteLine("TapGestureRecognizer_Tapped");
		Debug.WriteLine(e.GetPosition(null).Value.X);
        Debug.WriteLine(e.GetPosition(null).Value.Y);

    }
}

