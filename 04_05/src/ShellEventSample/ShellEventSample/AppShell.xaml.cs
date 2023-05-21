using System.Diagnostics;

namespace ShellEventSample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}
    protected override async void OnNavigating(ShellNavigatingEventArgs args)
    {
        base.OnNavigating(args);

        Debug.WriteLine("OnNavigating");
    }
    private void Shell_Navigated(object sender, ShellNavigatedEventArgs e)
    {
        Debug.WriteLine("Shell_Navigated");
    }

    private void Shell_Navigating(object sender, ShellNavigatingEventArgs e)
    {
        Debug.WriteLine("Shell_Navigating");

        //e.Cancel();

    }
}
