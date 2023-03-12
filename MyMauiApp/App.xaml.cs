namespace MyMauiApp;

/// <summary>
/// This is the code-behind for the App.xaml file. 
/// This file defines the App class. This class represents your application at runtime. 
/// The constructor in this class creates an initial window and assigns it to the MainPage property; 
/// this property determines which page is displayed when the application starts running. 
/// Additionally, this class enables you to override common platform-neutral application lifecycle event handlers. 
/// Events include OnStart, OnResume, and OnSleep. These handlers are defined as members of the Application base class. 
/// The code below shows examples:
/// </summary>

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

    protected override void OnStart()
    {
        base.OnStart();
    }

    protected override void OnResume()
    {
        base.OnResume();
    }

    protected override void OnSleep()
    {
        base.OnSleep();
    }
}