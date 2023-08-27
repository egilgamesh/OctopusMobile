using Yella.views;

namespace Yella
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			Current!.MainPage = new AppShell();
			//MainPage = new NavigationPage(new IntroPage());
		}
	}
}