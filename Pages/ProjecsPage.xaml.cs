using System.Windows.Input;

namespace PortfoilioApp.Pages;


public class Project
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }

    public ICommand ViewDetailsCommand { get; set; }


    public Project()
    {
        // Initialize the command with the logic to show project details
        ViewDetailsCommand = new Command(ViewDetails);
    }

    private void ViewDetails()
    {
        // Logic to handle project detail view
        App.Current.MainPage.DisplayAlert("Project Details", $"You clicked on {Title}", "OK");
    }

}



public partial class ProjecsPage : ContentPage
{
	public ProjecsPage()
	{
		InitializeComponent();
        // List of projects
        var projects = new List<Project>
        {
            new Project
            {
                Title = "Loan Management Software",
                Description = "A Loan Management app built using Python and Django.",
                Image = "screenshotloan.png" // Add this image to Resources folder
            },
            new Project
            {
                Title = "GYM Management System",
                Description = "A GYM Management System built using Python and Django  .",
                Image = "screenshotgym.png" // Add this image to Resources folder
            },
               new Project
            {
                Title = "Student Management System",
                Description = "A Student Management System built using Python .",
                Image = "screenshotstud.png" // Add this image to Resources folder
            },
               new Project
            {
                Title = "Lagosstate Complaint Management System",
                Description = "A Complaint Management System built using Html,Css and PHP  .",
                Image = "screenshotlag.png" // Add this image to Resources folder
            }
        };

        ProjectsCollectionView.ItemsSource = projects;
    }


}
