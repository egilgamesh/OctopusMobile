using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Yella.views;

public partial class LoginPage : ContentPage
{
	public LoginPage() => InitializeComponent();

	private async void LoginValidation(object sender, EventArgs e)
	{
		var cancellationTokenSource = new CancellationTokenSource();
		if (IsUserCredentialLoginValid())
		{
			//DisplayAlert("Connected", "alert", "Hi");
			await Navigation!.PushAsync(new HomePage(), true)!.ConfigureAwait(false);
		}
		await Toast.Make("Your Credential Wrong!, Please contact your Help Desk.", ToastDuration.Long, 16).
			Show(cancellationTokenSource.Token).ConfigureAwait(false);
	}

	private bool IsUserCredentialLoginValid() =>
		UsernameTxt!.Text == "admin" && PasswordTxt!.Text == "admin";
}