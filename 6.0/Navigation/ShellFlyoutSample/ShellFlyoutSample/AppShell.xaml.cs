namespace ShellFlyoutSample;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    public void HideNumbers()
    {
        Two.IsVisible = false;
        Three.IsVisible = false;
        Four.IsVisible = false;
    }
    public void ShowNumbers()
    { 
        Two.IsVisible = true;
        Three.IsVisible = true;
        Four.IsVisible = true;
    }
}
