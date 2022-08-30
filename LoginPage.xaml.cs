using FL.Login.Models;
using FL.Login.Pages;
using FL.Login.Services;

namespace FL.Login;

public partial class LoginPage : ContentPage
{
	readonly ILoginRepository _loginRepository = new LoginService();
	public LoginPage()
	{
		InitializeComponent();
	}
	private async void Login_Clicked(object sender, EventArgs e)
	{
		string EmailField = txtUserName.Text;
		string PasswordField= txtPassword.Text;

		if(EmailField == null || PasswordField == null)
		{
			await DisplayAlert("Warning", "Please Input Username & Password", "Ok");
			return;
		}
		UserInfo userInfo = await _loginRepository.Login(EmailField, PasswordField);
		if(userInfo != null)
		{
			await Navigation.PushAsync(new HomePage());
		}
		else
		{
            await DisplayAlert("Warning", " Username & Password is Incorrect", "Ok");
        }
	}
}