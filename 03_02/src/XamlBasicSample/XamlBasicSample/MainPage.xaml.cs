namespace XamlBasicSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public string Text { get; set; } = "Button";

    public MainPage()
	{
		InitializeComponent();

		this.BindingContext = this;
	}
}

