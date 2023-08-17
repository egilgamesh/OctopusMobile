using Yella.ViewModel;

namespace Yella.views;

public partial class IntroPage : ContentPage
{
	public IntroPage()
	{
		InitializeComponent();
		BindingContext = new IntroPageViewModel();
	}
}