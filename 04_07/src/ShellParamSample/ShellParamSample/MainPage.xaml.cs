namespace ShellParamSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnNextPageClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//SubPage", false, new Dictionary<string, object>
		{
			{ "sample", "test" }
		});
    }
}

