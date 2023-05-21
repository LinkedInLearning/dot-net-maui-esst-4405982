using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

#if WINDOWS
using System.Diagnostics;
#endif

namespace HandlerSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        LabelHandler.Mapper.AppendToMapping(nameof(IView.Background), (handler, view) =>
        {
            if (view is Label)
            {

#if WINDOWS
				// TextBlock
				handler.PlatformView.FontSize = 40;
				handler.PlatformView.Text = "Label Windows";
#elif ANDROID
                // TextView
                handler.PlatformView.Text = "Label Android";
#endif
            }

            if (view is MyLabel)
            {

#if WINDOWS
				// TextBlock
				handler.PlatformView.Text = "My Label Windows";
#elif ANDROID
                // TextView
                handler.PlatformView.TextSize = 40;
                handler.PlatformView.Text = "My Label Android";
#endif
            }
        });

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
