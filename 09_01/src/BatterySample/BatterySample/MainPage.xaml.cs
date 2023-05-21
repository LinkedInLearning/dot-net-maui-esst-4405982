using System.Diagnostics;

namespace BatterySample;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnBatteryClicked(object sender, EventArgs e)
	{
        // Androidでバッテリー情報を取得するにはマニフェストの追加が必要です
        // @see https://learn.microsoft.com/ja-jp/dotnet/maui/platform-integration/device/battery?view=net-maui-7.0&tabs=android
        Battery.Default.BatteryInfoChanged += Battery_BatteryInfoChanged;
	}

	private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
	{
		Debug.WriteLine("Battery_BatteryInfoChanged");
        Debug.WriteLine(e.ChargeLevel);
		battery.Text = e.ChargeLevel.ToString();
	}
}

