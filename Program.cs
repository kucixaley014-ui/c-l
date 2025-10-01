using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace MyMauiApp;

public static class Program
{
    public static MauiApp CreateMauiApp() => MauiApp.CreateBuilder()
        .UseMauiApp<App>()
        .Build();
}

public class App : Application
{
    public App()
    {
        MainPage = new MainPage();
    }
}
