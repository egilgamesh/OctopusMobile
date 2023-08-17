using Yella.views;

namespace Yella
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			//MainPage = new AppShell();
			MainPage = new NavigationPage(new IntroPage());
		}
	}
}