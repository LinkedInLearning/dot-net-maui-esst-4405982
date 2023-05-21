using System.Diagnostics;

namespace PinchSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    double currentScale = 1;
    double startScale = 1;

    private void PinchGestureRecognizer_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
    {
        // Androidエミュレーターでのピンチ操作はCtrキーを押しながらマウスをドラッグ

        Debug.WriteLine("PinchGestureRecognizer_PinchUpdated");
        Debug.WriteLine(e.Status);
        if (e.Status == GestureStatus.Started)
        {
            startScale = image.Scale;
            currentScale = startScale;
        }
        else if (e.Status == GestureStatus.Running)
        {
            Debug.WriteLine(e.Scale);
            currentScale -= 1 - e.Scale;
        }
        else if (e.Status == GestureStatus.Completed)
        {
            Debug.WriteLine(currentScale);
            image.Scale = currentScale;
        }
    }
}

