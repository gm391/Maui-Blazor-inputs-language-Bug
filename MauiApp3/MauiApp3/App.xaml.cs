using System.Globalization;

namespace MauiApp3;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("fr-FR");
        MainPage = new MainPage();
	}
}
