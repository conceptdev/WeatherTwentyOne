﻿using Android.App;
using Android.Content.PM;
using Microsoft.Maui;

namespace WeatherTwentyOne
{
	[IntentFilter(
        new[] { Microsoft.Maui.Essentials.Platform.Intent.ActionAppAction },
        Categories = new[] { Android.Content.Intent.CategoryDefault })]
	[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
	public class MainActivity : MauiAppCompatActivity
	{

		protected override void OnResume()
		{
			base.OnResume();

			Microsoft.Maui.Essentials.Platform.OnResume(this);
		}

		protected override void OnNewIntent(Android.Content.Intent intent)
		{
			base.OnNewIntent(intent);

			Microsoft.Maui.Essentials.Platform.OnNewIntent(intent);
		}
	}
}