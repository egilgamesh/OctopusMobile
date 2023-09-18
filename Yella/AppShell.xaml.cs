using Microsoft.Maui.Controls;
using SimpleToolkit.Core;
using Yella.views;

namespace Yella;

public partial class AppShell : SimpleToolkit.SimpleShell.SimpleShell
{
	public AppShell()
	{
		InitializeComponent();
		AddTab(typeof(HomePage), PageType.HomePage);
		AddTab(typeof(BalancePage), PageType.Balance);
		AddTab(typeof(NewOrderPage), PageType.NewOrder);
		AddTab(typeof(TrackPage), PageType.Track);
		AddTab(typeof(SettingsPage), PageType.Settings);
		Loaded += AppShellLoaded;
	}

	private static void AppShellLoaded(object sender, EventArgs e)
	{
		var shell = sender as AppShell;
		shell.Window.SubscribeToSafeAreaChanges(safeArea =>
		{
			shell.pageContainer.Margin = safeArea;
			shell.tabBarView.Margin = safeArea;
			shell.bottomBackgroundRectangle.IsVisible = safeArea.Bottom > 0;
			shell.bottomBackgroundRectangle.HeightRequest = safeArea.Bottom;
		});
	}

	private void AddTab(Type page, PageType pageEnum)
	{
		Tab tab = new Tab { Route = pageEnum.ToString(), Title = pageEnum.ToString() };
		tab.Items.Add(new ShellContent { ContentTemplate = new DataTemplate(page) });
		tabBar.Items.Add(tab);
	}

	private void TabBarViewCurrentPageChanged(object sender, TabBarEventArgs e) =>
		Shell.Current!.GoToAsync("///" + e.CurrentPage.ToString());
}

public enum PageType
{
	HomePage,
	Balance,
	NewOrder,
	Track,
	Settings
}