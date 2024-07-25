using OpeningsApp.Openings;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Maui.Controls;

namespace OpeningsApp.Logon;



public partial class PostLogon : ContentPage
{
    private List<Button> allButtons;
    public PostLogon()
    {
        InitializeComponent();
        CacheAllButtons();

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
        await Navigation.PushAsync(new ViennaGamePage());
    }
    private async void OnBishopsOpeningClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BishopsOpeningPage());
    }
    private async void OnKingsGambitClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new KingsGambitPage());
    }

    private void CacheAllButtons()
    {
        allButtons = new List<Button>
            {
                CreateButton("Italian Game", Color.FromArgb("#A0522D"), async () => await Navigation.PushAsync(new ItalianGamePage())),
                CreateButton("Ruy Lopez", Color.FromArgb("#FFDEAD"), async () => await Navigation.PushAsync(new RuyLopezPage())),
                CreateButton("Scotch Game", Color.FromArgb("#A0522D"), async () => await Navigation.PushAsync(new ScotchGamePage())),
                CreateButton("Ponziani Opening", Color.FromArgb("#FFDEAD"), async () => await Navigation.PushAsync(new PonzianiOpeningPage())),
                CreateButton("Four Knights Game", Color.FromArgb("#A0522D"), async () => await Navigation.PushAsync(new FourKnightsGamePage())),
                CreateButton("Petrov's Defense", Color.FromArgb("#FFDEAD"), async () => await Navigation.PushAsync(new PetrovsDenfensePage())),
                CreateButton("Philidor Defense", Color.FromArgb("#A0522D"), async () => await Navigation.PushAsync(new PhilidorDefensePage())),
                CreateButton("Elephant Gambit", Color.FromArgb("#FFDEAD"), async () => await Navigation.PushAsync(new ElephantGambitPage())),
                CreateButton("Latvian Gambit", Color.FromArgb("#A0522D"), async () => await Navigation.PushAsync(new LatvianGambitPage())),
                CreateButton("Center Game", Color.FromArgb("#FFDEAD"), async () => await Navigation.PushAsync(new CenterGamePage())),
                CreateButton("Danish Gambit", Color.FromArgb("#A0522D"), async () => await Navigation.PushAsync(new DanishGamePage())),
                CreateButton("Vienna Game", Color.FromArgb("#FFDEAD"), async () => await Navigation.PushAsync(new ViennaGamePage())),
                CreateButton("Bishop's Opening", Color.FromArgb("#A0522D"), async () => await Navigation.PushAsync(new BishopsOpeningPage())),
                CreateButton("King's Gambit", Color.FromArgb("#FFDEAD"), async () => await Navigation.PushAsync(new KingsGambitPage()))
            };

        foreach (var button in allButtons)
        {
            ButtonsContainer.Children.Add(button);
        }
    }

    private Button CreateButton(string text, Color backgroundColor, Func<Task> action)
    {
        return new Button
        {
            Text = text,
            BackgroundColor = backgroundColor,
            FontSize = 24,
            TextColor = Color.FromArgb("#000000"),
            Margin = new Thickness(0, 5),
            Command = new Command(async () => await action())
        };
    }

    private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
    {
        var searchText = e.NewTextValue.ToLower();
        ButtonsContainer.Children.Clear();

        foreach (var button in allButtons)
        {
            if (button.Text.ToLower().Contains(searchText))
            {
                ButtonsContainer.Children.Add(button);
            }
        }
    }



}