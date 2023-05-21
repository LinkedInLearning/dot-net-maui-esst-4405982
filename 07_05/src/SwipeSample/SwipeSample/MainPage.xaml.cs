using System.Diagnostics;

namespace SwipeSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
    {
		Debug.WriteLine("SwipeGestureRecognizer_Swiped");
        Debug.WriteLine(e.Direction);

		direction.Text = e.Direction.ToString();

    }
}

