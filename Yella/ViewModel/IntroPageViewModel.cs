using System.Collections.ObjectModel;
using Yella.Model;

namespace Yella.ViewModel;

public class IntroPageViewModel
{
	public IntroPageViewModel()
	{
		IntoScreens!.Add(new IntroPageModel { Title = "Welcome Yella", Description = "Yella Is delivery system", ImageName = "intro1.png" });
		IntoScreens!.Add(new IntroPageModel { Title = "Welcome Yella", Description = "Yella Is delivery system", ImageName = "intro2.jpeg" });
	}

	public ObservableCollection<IntroPageModel> IntoScreens { get; } = new();
}