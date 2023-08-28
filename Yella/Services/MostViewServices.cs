using Yella.Model;

namespace Yella.Services;

public static class MostViewServices
{
	public static IEnumerable<MostView> GetPopularView() => PopularViews;
	private static readonly List<MostView> PopularViews = new()
	{
		new MostView { ImageName = "orders" },
		new MostView { ImageName = "courier.png" },
		new MostView { ImageName = "returnsorder.png" },
		new MostView { ImageName = "completedorder.png" }
	};
}