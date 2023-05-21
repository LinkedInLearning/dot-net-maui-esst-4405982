namespace ShellParamSample;

[QueryProperty(nameof(Sample), "sample")]

public partial class SubPage : ContentPage
{
    public string Sample { get; set; }
    public SubPage()
	{
		InitializeComponent();
	}

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {

    }
}