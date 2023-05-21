namespace AnimationSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnScalingClicked(object sender, EventArgs e)
	{
        await image.ScaleTo(2, 2000);
    }
    private async void OnInitialClicked(object sender, EventArgs e)
    {
        await image.ScaleTo(1, 0);
        await image.FadeTo(1, 0);
        await image.RotateTo(0, 0);


    }
    private async void OnRotateToClicked(object sender, EventArgs e)
    {
        await image.RotateTo(360, 2000);
    }
    private async void OnFadeClicked(object sender, EventArgs e)
    {
        await image.FadeTo(0.2, 2000);
    }
    
}

