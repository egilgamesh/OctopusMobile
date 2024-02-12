using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Yella.UserControl;

public sealed class ProgressViewModel : INotifyPropertyChanged
{
	private ObservableCollection<ProgressStep> steps;
	public ObservableCollection<ProgressStep> Steps
	{
		get => steps;
		set
		{
			if (Equals(value, steps))
				return;
			steps = value;
			OnPropertyChanged(nameof(Steps));
			OnPropertyChanged(nameof(OverallProgress));
		}
	}

	public ProgressViewModel() =>
		// Initialize steps
		Steps = new ObservableCollection<ProgressStep>
		{
			new()
			{
				Title = "Step 1",
				StartingDate = DateTime.Now,
				EndingDate = DateTime.Now.AddDays(2),
				Status = true
			},
			new()
			{
				Title = "Step 2",
				StartingDate = DateTime.Now.AddDays(2),
				EndingDate = DateTime.Now.AddDays(4),
				Status = true
			},
			new()
			{
				Title = "Step 3",
				StartingDate = DateTime.Now.AddDays(4),
				EndingDate = DateTime.Now.AddDays(6),
				Status = true
			}
		};

	public double OverallProgress
	{
		get
		{
			if (Steps == null || Steps.Count == 0)
				return 0;
			var completedSteps = Steps.Where(step => step!.Status).Sum(_ => 100 / Steps.Count);
			return (double)completedSteps;
		}
	}
	public event PropertyChangedEventHandler PropertyChanged;

	public void OnPropertyChanged(string propertyName) =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}