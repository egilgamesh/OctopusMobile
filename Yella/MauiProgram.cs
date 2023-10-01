using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
#if ANDROID
using Platforms.Android;
#endif

namespace Yella;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>().UseMauiCommunityToolkit().ConfigureFonts(fonts =>
		{
			fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			fonts.AddFont("Alexandria.ttf", "Alexandria");
			fonts.AddFont("CairoPlay.ttf", "CairoPlay");
		});
#if ANDROID
		//handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
		builder.ConfigureMauiHandlers(handlers =>
		{
			handlers.AddHandler<Shell, CustomShellHandler>();
		});
#endif
#if DEBUG
		builder.Logging.AddDebug();
#endif

		//Enable it if you want textbox without underline
		//		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry),
		//			(handler, view) =>
		//			{
		//#if ANDROID
		//            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
		//#endif
		//			});
		return builder.Build();
	}
}