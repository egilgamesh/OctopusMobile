﻿using Android.App;
using Android.Runtime;

// ReSharper disable once CheckNamespace
namespace Yella
{
	[Application]
	public class MainApplication : MauiApplication
	{
		public MainApplication(IntPtr handle, JniHandleOwnership ownership)
			: base(handle, ownership) { }

		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}