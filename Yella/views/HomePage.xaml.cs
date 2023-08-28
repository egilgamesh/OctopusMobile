namespace Yella.views;

public partial class HomePage : ContentPage
{
	public HomePage() => InitializeComponent();

	private async void ProfilePic_Clicked(object sender, TappedEventArgs e)
	{
		// Reveal our menu and move the main content out of the view
		_ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration,
			Easing.CubicIn);
		await MainContentGrid.ScaleTo(0.8, AnimationDuration);
		_ = MainContentGrid.FadeTo(0.8, AnimationDuration);
	}

	private const uint AnimationDuration = 800u;
}