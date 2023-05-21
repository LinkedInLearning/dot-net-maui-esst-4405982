using System.Diagnostics;

namespace PanGestureSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
    {
		Debug.WriteLine("PanGestureRecognizer_PanUpdated");
        Debug.WriteLine(e.StatusType);

    }
}

