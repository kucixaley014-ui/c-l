namespace MyMauiApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var label = new Label
        {
            Text = "Hello, MAUI Android!",
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center
        };

        Content = label;
    }
}
