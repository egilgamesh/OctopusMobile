using CommunityToolkit.Maui.Alerts;
using System.Windows.Input;
#if ANDROID
using Yella.Platforms.Android;
#endif

namespace Yella;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		BindingContext = this;
	}

	public ICommand CenterViewCommand { get; set; }

	protected override void OnBindingContextChanged()
	{
		CenterViewCommand = new Command(async () =>
		{
#if ANDROID
			this.ShowBottomSheet(GetBottomSheetView(), true);
#endif
			//await Toast.Make("CenterViewCommand invoked!").Show().ConfigureAwait(false);
		});
		base.OnBindingContextChanged();
	}

	private void OnCounterClicked(object sender, EventArgs e) { }

	private View GetBottomSheetView()
	{
		var view = (View)BottomSheetTemplate!.CreateContent();
		view!.BindingContext = BindingContext;
		return view;
	}

	private void OnNextClicked(object sender, EventArgs e)
	{
		step++;
		if (step == 2) { }
	}

	private int step = 0;
}