namespace BindablePropertySample;

public partial class MainPage : ContentPage
{
	int count = 0;

	MainPageViewModel2 viewModel;

    public MainPage()
	{
		InitializeComponent();
        viewModel = new MainPageViewModel2() { Text = "Bindable" };

		BindingContext = viewModel;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

		viewModel.Text = "Update";
		
	}
}

