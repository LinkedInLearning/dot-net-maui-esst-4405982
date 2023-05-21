namespace BindablelayoutSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		this.BindingContext = new Team()
		{
            Users = new List<string>() { "ABC", "DEF", "GHI"}
		};
	}
}

public class Team
{
    public List<string> Users { get; set; }
}
