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
    private async void OnFourKnightsGameClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FourKnightsGamePage());
    }
    private async void OnPetrovsDefenseClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PetrovsDenfensePage());
    }
    private async void OnPhilidorDefenseClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PhilidorDefensePage());
    }
    private async void OnElephantGambitClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ElephantGambitPage());
    }
    private async void OnLatvianGambitClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LatvianGambitPage());
    }
    private async void OnCenterGameClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CenterGamePage());
    }
    private async void OnDanishGambitClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DanishGamePage());
    }
    private async void OnViennaGameClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync (new ViennaGamePage());
    }
    private async void OnBishopsOpeningClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BishopsOpeningPage());
    }
    private async void OnKingsGambitClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new KingsGambitPage());
    }


}