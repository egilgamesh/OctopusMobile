using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;

namespace Yella;

// ReSharper disable once HollowTypeName
public class CustomShellHandler : ShellRenderer
{
	protected override IShellItemRenderer CreateShellItemRenderer(ShellItem item)
	{
		return new CustomShellItemRenderer(this);
	}
}