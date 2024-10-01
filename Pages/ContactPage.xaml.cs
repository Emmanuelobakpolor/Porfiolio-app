namespace PortfoilioApp.Pages;

public partial class ContactPage : ContentPage
{
	public ContactPage()
	{
		InitializeComponent();
	}

    private void GitHub_Clicked(object sender, EventArgs e)
    {
        Launcher.OpenAsync(new Uri("https://github.com/Emmanuelobakpolor"));
    }

    private void Twitter_Clicked(object sender, EventArgs e)
    {
        Launcher.OpenAsync(new Uri("https://twitter.com/___kkingg"));
    }

    private void LinkedIn_Clicked(object sender, EventArgs e)
    {
        Launcher.OpenAsync(new Uri("https://www.linkedin.com/in/emmanuel-obakpolor"));
    }
}