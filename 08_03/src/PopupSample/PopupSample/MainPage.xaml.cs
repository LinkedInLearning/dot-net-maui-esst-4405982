using System.Diagnostics;

namespace PopupSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnAlertClicked(object sender, EventArgs e)
	{
        await DisplayAlert("アラート", "基本的なアラート", "OK");
    }
    private async void OnYesNoAlertClicked(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("選択?", "どちらかを選択してください", "A", "B");

        // 1つ目の選択肢＝True、2つ目の選択肢＝False
        Debug.WriteLine("Answer= " + answer);
    }
    private async void OnActionSheetClicked(object sender, EventArgs e)
    {
        string action = await DisplayActionSheet("1つ選択してください", "キャンセル", null, "A", "B", "C");
        Debug.WriteLine("Action: " + action);
    }
    private async void OnPromptClicked(object sender, EventArgs e)
    {
        string result = await DisplayPromptAsync("プロンプト", "文字を入力してください");

        Debug.WriteLine("Prompt: " + result);
    }
    
}

