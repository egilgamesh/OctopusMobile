using Yella.Model;

namespace Yella.Services;

public static class OrderTransactionAnalysisServices
{
	public static IEnumerable<OrderView> GetOrderTransactionView() => OrderTransactionTypeViews;
	private static readonly List<OrderView> OrderTransactionTypeViews = new()
	{
		new()
		{
			OrderId = "#1",
			OrderDate = DateTime.Now.ToShortDateString(),
			OrderTotal = "20,555 د.ع",
			Status = "عند مندوب التوصيل"
		},
		new()
		{
			OrderId = "#2",
			OrderDate = DateTime.Now.ToShortDateString(),
			OrderTotal = "20,555 د.ع",
			Status = "عند مندوب التوصيل"
		},
		new()
		{
			OrderId = "#3",
			OrderDate = DateTime.Now.ToShortDateString(),
			OrderTotal = "20,555 د.ع",
			Status = "عند مندوب التوصيل"
		},
		new()
		{
			OrderId = "#4",
			OrderDate = DateTime.Now.ToShortDateString(),
			OrderTotal = "20,555 د.ع",
			Status = "عند مندوب التوصيل"
		},
		new()
		{
			OrderId = "#5",
			OrderDate = DateTime.Now.ToShortDateString(),
			OrderTotal = "20,555 د.ع",
			Status = "عند مندوب التوصيل"
		},
		new()
		{
			OrderId = "#6",
			OrderDate = DateTime.Now.ToShortDateString(),
			OrderTotal = "20,555 د.ع",
			Status = "عند مندوب التوصيل"
		},
		new()
		{
			OrderId = "#7",
			OrderDate = DateTime.Now.ToShortDateString(),
			OrderTotal = "20,555 د.ع",
			Status = "عند مندوب التوصيل"
		}
	};
}