using OpeningsApp.Logon;
using OpeningsApp.Openings;

namespace OpeningsApp
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
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


        

    }
}
