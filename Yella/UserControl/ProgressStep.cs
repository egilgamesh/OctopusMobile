using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Yella.UserControl;

public sealed class ProgressStep : INotifyPropertyChanged
{
	public string Title { get; set; }
	public DateTime StartingDate { get; set; }
	public DateTime EndingDate { get; set; }
	public string Description { get; set; }
	public bool Status
	{
		get => status;
		set
		{
			if (value == status)
				return;
			status = value;
			OnPropertyChanged(nameof(status));
		}
	}
	private bool status;
	public event PropertyChangedEventHandler PropertyChanged;

	private void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}