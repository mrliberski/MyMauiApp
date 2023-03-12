using Microsoft.Extensions.Logging;

///Each native platform has a different starting point that creates and initializes the application. 
///You can find this code under the Platforms folder in the project. This code is platform-specific, 
///but at the end it calls the CreateMauiApp method of the static MauiProgramclass. 
///You use the CreateMauiApp method to configure the application by creating an app builder object. 
///At a minimum, you need to specify which class describes your application. 
///You do this with the UseMauiApp generic method of the app builder object; 
///the type parameter specifies the application class. The app builder also provides methods for tasks such as registering fonts, 
///configuring services for dependency injection, registering custom handlers for controls, and more. 
///The following code shows an example of using the app builder to register a font:



namespace MyMauiApp;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
