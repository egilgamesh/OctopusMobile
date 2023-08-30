using Yella.Model;

namespace Yella.Services;

public static class MostViewServices
{
	public static IEnumerable<MostView> GetPopularView() => PopularViews;
	private static readonly List<MostView> PopularViews = new()
	{
		new MostView { ImageName = "testord", Title = "الطلبات المسجلة"},
		new MostView { ImageName = "delieverman", Title = "مندوب التوصيل"},
		new MostView { ImageName = "returnsorderstore.png", Title = "الراجع"},
		new MostView { ImageName = "deliveredorders.png", Title = "الطلبات المكتملة"}
	};
}