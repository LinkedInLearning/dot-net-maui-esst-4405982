using System.Diagnostics;

namespace ThemeSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnThemeChangeClicked(object sender, EventArgs e)
	{
		if (Application.Current.RequestedTheme == AppTheme.Unspecified)
		{
			Debug.WriteLine("Dark → Light");

			Application.Current.UserAppTheme = AppTheme.Light;
		}
		else
		{
            Debug.WriteLine("Light → Dark");

            Application.Current.UserAppTheme = AppTheme.Dark;
        }
	}
}

