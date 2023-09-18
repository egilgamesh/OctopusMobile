using System.Windows.Input;
using Maui.BindableProperty.Generator.Core;

namespace Yella;

public partial class OctopusTabBar : TabBar
{
	[AutoBindable]
	private ICommand? centerViewCommand;
	[AutoBindable]
	private ImageSource? centerViewImageSource;
	[AutoBindable]
	private string? centerViewText;
	[AutoBindable]
	private bool centerViewVisible;
	[AutoBindable]
	public Color? centerViewBackgroundColor;
}