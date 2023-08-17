using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Yella.ViewModel;

public class BaseViewModel : INotifyPropertyChanged
{
	protected bool SetProperty<T>(ref T backingStore, T value,
		Action onChanged = null, [CallerMemberName] string propertyName = "")
	{
		if (EqualityComparer<T>.Default.Equals(backingStore, value))
			return false;
		backingStore = value;
		onChanged?.Invoke();
		OnPropertyChanged(propertyName);
		return true;
	}

	#region INotifyPropertyChanged
	public event PropertyChangedEventHandler PropertyChanged;

	protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
	{
		var changed = PropertyChanged;
		changed?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
	#endregion
}