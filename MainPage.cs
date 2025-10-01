using Microsoft.Maui.Controls;

namespace MyMauiApp;

public class MainPage : ContentPage
{
    public MainPage()
    {
        Content = new Label
        {
            Text = "Hello, MAUI Android!",
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center
        };
    }
}
