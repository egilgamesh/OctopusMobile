using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Yella.views;

namespace Yella;

public partial class LoginPage : ContentPage
{
	public LoginPage() => InitializeComponent();

	//int count;
	private async void LoginValidation(object sender, EventArgs e)
	{
		if (IsUserCredentialLoginValid())
		{
			//DisplayAlert("Connected", "alert", "Hi");
			var cancellationTokenSource = new CancellationTokenSource();
			await Toast.Make("Howdy, I'm a Toast!", ToastDuration.Long, 16).
				Show(cancellationTokenSource.Token).ConfigureAwait(false);
		}
		//count++;
		//CounterBtn!.Text = count == 1
		//	? $"Clicked {count} time"
		//	: $"Clicked {count} times";
		//SemanticScreenReader.Announce(CounterBtn.Text);
		await Navigation!.PushAsync(new MainPage(), true)!.ConfigureAwait(false);
	}

	private bool IsUserCredentialLoginValid() =>
		UsernameTxt!.Text == "admin" && PasswordTxt!.Text == "admin";
}