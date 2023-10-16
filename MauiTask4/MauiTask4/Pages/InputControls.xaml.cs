namespace MauiTask4.Pages;

public partial class InputControls : ContentPage
{
	public InputControls()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        sliderValueLabel.Text = e.NewValue.ToString();
    }
}