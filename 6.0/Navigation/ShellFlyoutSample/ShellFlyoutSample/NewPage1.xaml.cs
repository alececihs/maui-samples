namespace ShellFlyoutSample;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

	private void GoBackBtn_Clicked(object sender, EventArgs e)
	{
		Navigation.PopModalAsync();
	}
}