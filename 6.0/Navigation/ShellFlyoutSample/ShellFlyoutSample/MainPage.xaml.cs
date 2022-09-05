namespace ShellFlyoutSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void HideMenuItemsBtn_Clicked(object sender, EventArgs e)
	{
		AppShell appShell = Shell.Current as AppShell;
		appShell.HideNumbers();
	}

	private void ShowMenuItemsBtn_Clicked(object sender, EventArgs e)
	{
        AppShell appShell = Shell.Current as AppShell;
		appShell.ShowNumbers();
    }

	private void PushModal_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new NewPage1());
	}
}

