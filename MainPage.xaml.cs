using OpeningsApp.Logon;
using OpeningsApp.Openings;
using OpeningsApp.ViewModel;
using System.ComponentModel;

namespace OpeningsApp
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainPageViewModel();
            BindingContext = viewModel;
        }

        private async void OnLogonButtonClicked(object sender, EventArgs e)
        {
            string enteredEmail = Username.Text;
            string enteredPassword = Password.Text;

            // Validate user credentials against the database
            var user = await App.Database.LoginUserAsync(enteredEmail, enteredPassword);

            if (user != null)
            {
                await Navigation.PushAsync(new PostLogon());
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Login Failed", "Invalid email or password.", "OK");
            }
        }

        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Register());
        }

        private async void OnGuestButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PostLogon());
        }




    }
}
