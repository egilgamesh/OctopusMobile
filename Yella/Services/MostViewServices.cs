using Yella.Model;

namespace Yella.Services;

public static class MostViewServices
{
	public static IEnumerable<MostView> GetPopularView() => PopularViews;
	private static readonly List<MostView> PopularViews = new()
	{
		new MostView { ImageName = "orders", Title = "الطلبات المسجلة"},
		new MostView { ImageName = "courier.png", Title = "مندوب التوصيل"},
		new MostView { ImageName = "returnsorder.png", Title = "الراجع"},
		new MostView { ImageName = "completedorder.png", Title = "الطلبات المكتملة"}
	};
}