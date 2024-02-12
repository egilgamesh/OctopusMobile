using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Yella.UserControl;

public sealed class ProgressViewModel : INotifyPropertyChanged
{
	public ObservableCollection<ProgressStep> Steps { get; set; }

	public ProgressViewModel() =>
		// Initialize steps
		Steps = new ObservableCollection<ProgressStep>
		{
			new()
			{
				Title = "Step 1",
				StartingDate = DateTime.Now,
				EndingDate = DateTime.Now.AddDays(2)
			},
			new()
			{
				Title = "Step 2",
				StartingDate = DateTime.Now.AddDays(2),
				EndingDate = DateTime.Now.AddDays(4)
			},
			new()
			{
				Title = "Step 3",
				StartingDate = DateTime.Now.AddDays(4),
				EndingDate = DateTime.Now.AddDays(6)
			}
		};

	public event PropertyChangedEventHandler PropertyChanged;
}