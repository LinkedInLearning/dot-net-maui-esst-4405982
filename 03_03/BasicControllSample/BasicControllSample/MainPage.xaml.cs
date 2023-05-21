namespace BasicControllSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	MainPageViewModel viewModel;
	public MainPage()
	{
		InitializeComponent();

		viewModel = new MainPageViewModel();
		viewModel.Items.Add(new Item() { Text = "a"});
		viewModel.Items.Add(new Item() { Text = "b"});
		viewModel.Items.Add(new Item() { Text = "c"});

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
	}
}

