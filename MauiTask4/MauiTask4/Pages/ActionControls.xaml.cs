namespace MauiTask4.Pages;

public partial class ActionControls : ContentPage
{
	public ActionControls()
	{
		InitializeComponent();
	}

    private void demoButton_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Coding Droplets", "You have clicked the Demo Button", "OK");
    }

    private void demoImageButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You have clicked the Download Button", "OK");
    }

    private void demoSearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", $"Youve searched for {demoSearchBar.Text}", "OK");

    }

    private void facebookSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You have clicked Facebook Button", "OK");
    }

    private void instagramSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You have clicked Instagram Button", "OK");

    }

    private void twitterSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You have clicked Twitter Button", "OK");

    }

    private void linkedinSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You have clicked Linkedin Button", "OK");

    }
}