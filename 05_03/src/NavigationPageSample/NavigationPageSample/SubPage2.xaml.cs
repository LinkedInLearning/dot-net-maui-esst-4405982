namespace NavigationPageSample;

public partial class SubPage2 : ContentPage
{
	public SubPage2()
	{
		InitializeComponent();
	}
    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}