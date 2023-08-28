using System.Collections.ObjectModel;
using Yella.Model;

namespace Yella.ViewModel;

public class PopularViewersViewModel
{
	public PopularViewersViewModel()
	{
		PopularViews!.Add(new MostView { ImageName = "orders" });
		PopularViews.Add(new MostView { ImageName = "courier.png" });
		PopularViews.Add(new MostView { ImageName = "returnsorder.png" });
		PopularViews.Add(new MostView { ImageName = "completedorder.png" });
	}

	public ObservableCollection<MostView> PopularViews { get; } = new();
}