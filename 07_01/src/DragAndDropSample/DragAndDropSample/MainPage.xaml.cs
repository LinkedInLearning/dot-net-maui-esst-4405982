
using Microsoft.Maui.ApplicationModel.DataTransfer;
using System.Diagnostics;

namespace DragAndDropSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
    {
        Debug.WriteLine("DragGestureRecognizer_DragStarting");
        e.Data.Properties.Add("Text", label.Text);


    }

    private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
    {
        Debug.WriteLine("DropGestureRecognizer_Drop");
        var text = e.Data.Properties["Text"];
    }
}

