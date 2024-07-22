namespace OpeningsApp.Logon;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}
    private async void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(RegisterFirstName.Text) ||
               string.IsNullOrWhiteSpace(RegisterLastName.Text) ||
               string.IsNullOrWhiteSpace(RegisterEmail.Text) ||
               string.IsNullOrWhiteSpace(RegisterPassword.Text))
        {
            await DisplayAlert("Error", "All fields are required.", "OK");
            return;
        }
        // Create a new user instance with data from the form
        var newUser = new UserClass
        {
            FirstName = RegisterFirstName.Text,
            LastName = RegisterLastName.Text,
            Email = RegisterEmail.Text,
            Password = RegisterPassword.Text
        };

        // Check if the user already exists
        var existingUser = await App.Database.GetUserByEmailAsync(newUser.Email);
        if (existingUser != null)
        {
            await DisplayAlert("Error", "User with this email already exists.", "OK");
            return;
        }

        // Register the user
        await App.Database.RegisterUserAsync(newUser);
        await DisplayAlert("Success", "User registered successfully!", "OK");

        // Navigate to main page
        await Navigation.PushAsync(new MainPage());
    }

}