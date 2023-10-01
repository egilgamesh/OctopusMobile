using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Platforms.Android
{
	// ReSharper disable once HollowTypeName
	public class CustomShellHandler : ShellRenderer
	{
		protected override IShellItemRenderer CreateShellItemRenderer(ShellItem item) =>
			new CustomShellItemRenderer(this);
	}
}