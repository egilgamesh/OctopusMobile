using System.Collections.ObjectModel;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using Yella.Model;
using Yella.Services;
using Yella.ViewModel;

namespace Yella.views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		Series = new ObservableCollection<ISeries>(GaugeGenerator.BuildSolidGauge(new GaugeItem(30, Builder), new GaugeItem(
			GaugeItem.Background, series =>
			{
				series!.InnerRadius = 75;
				series.Fill = new SolidColorPaint(new SKColor(100, 181, 246, 90));
			})));
	}

	private void Builder(PieSeries<ObservableValue> series)
	{
		series!.Fill = new SolidColorPaint(SKColors.YellowGreen);
		series.DataLabelsSize = 50;
		series.DataLabelsPaint = new SolidColorPaint(SKColors.Red);
		series.DataLabelsPosition = PolarLabelsPosition.ChartCenter;
		series.InnerRadius = 75;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		LstPopularView!.ItemsSource = MostViewServices.GetPopularView();
	}

	public ObservableCollection<ISeries> Series { get; set; }

	private async void ProfilePic_Clicked(object sender, TappedEventArgs e)
	{
		// Reveal our menu and move the main content out of the view
		_ = MainContentGrid.TranslateTo(-Width * 0.5, this.Height * 0.1, AnimationDuration,
			Easing.CubicIn);
		await MainContentGrid.ScaleTo(0.8, AnimationDuration).ConfigureAwait(false);
		_ = MainContentGrid.FadeTo(0.8, AnimationDuration);
	}

	private const uint AnimationDuration = 800u;
	private void View_SelectionChanged(object sender, SelectionChangedEventArgs e) { }

	public async void GridArea_Tapped(object sender, System.EventArgs e) =>
		await CloseMenu().ConfigureAwait(false);

	private async Task CloseMenu()
	{
		//Close the menu and bring back back the main content
		_ = MainContentGrid.FadeTo(1, AnimationDuration);
		_ = MainContentGrid.ScaleTo(1, AnimationDuration);
		await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn).
			ConfigureAwait(false);
	}

	private void TapGestureRecognizer_OnTapped(object sender, TappedEventArgs e)
	{
		DisplayAlert("hee", "he", "he");
	}
}