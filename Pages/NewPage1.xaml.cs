using Microsoft.Maui.Controls;

namespace PortfoilioApp.Pages;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private async void GoToProjectsPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.ProjecsPage());
    }

    // Navigate to Contact Page
    private async void GoToContactPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.ContactPage());
    }


}