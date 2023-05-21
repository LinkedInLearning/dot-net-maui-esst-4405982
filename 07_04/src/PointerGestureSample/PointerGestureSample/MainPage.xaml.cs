using System.Diagnostics;

namespace PointerGestureSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void PointerGestureRecognizer_PointerEntered(object sender, PointerEventArgs e)
    {
        Debug.WriteLine("PointerGestureRecognizer_PointerEntered");
    }

    private void PointerGestureRecognizer_PointerExited(object sender, PointerEventArgs e)
    {
        Debug.WriteLine("PointerGestureRecognizer_PointerExited");
        xpoint.Text = (e.GetPosition(image).Value.X).ToString();
        ypoint.Text = (e.GetPosition(image).Value.Y).ToString();

    }

    private void PointerGestureRecognizer_PointerMoved(object sender, PointerEventArgs e)
    {
        Debug.WriteLine("PointerGestureRecognizer_PointerMoved");
        xpoint.Text = (e.GetPosition(image).Value.X).ToString();
        ypoint.Text = (e.GetPosition(image).Value.Y).ToString();
    }
}

