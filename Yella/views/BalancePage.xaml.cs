using Yella.Services;

namespace Yella.views;

public partial class BalancePage : ContentPage
{
	public BalancePage() => InitializeComponent();
	private void OrderTypeTransaction_OnTapped(object sender, TappedEventArgs e) { }

	protected override void OnAppearing()
	{
		base.OnAppearing();
		BalanceDetails!.ItemsSource = OrderTransactionAnalysisServices.GetOrderTransactionView();
	}
}