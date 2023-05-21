
namespace HandlerSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

#if ANDROID
        Microsoft.Maui.Handlers.ButtonHandler.Mapper.AppendToMapping(nameof(IView.Background),
            (handler, view) =>
            {
                (handler.PlatformView as Android.Views.View).SetBackgroundColor(Android.Graphics.Color.Brown);
            });
#endif

        MainPage = new AppShell();
    }
}
