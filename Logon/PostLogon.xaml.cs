using OpeningsApp.Openings;

namespace OpeningsApp.Logon;

public partial class PostLogon : ContentPage
{
	public PostLogon()
	{
		InitializeComponent();
	}
    private async void OnItalianGameClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new ItalianGamePage());
    }
    private async void OnRuyLopezClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new RuyLopezPage());
    }
    private async void OnScotchGameClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new ScotchGamePage());
    }
    private async void OnPonzianiOpeningClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new PonzianiOpeningPage());
    }
}