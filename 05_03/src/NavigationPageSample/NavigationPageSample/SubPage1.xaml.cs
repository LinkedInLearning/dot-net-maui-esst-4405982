namespace NavigationPageSample;

public partial class SubPage1 : ContentPage
{
	public SubPage1()
	{
		InitializeComponent();
	}

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SubPage2());
    }
}