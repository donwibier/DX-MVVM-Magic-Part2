using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.Mvvm;
using DXMVVMSampleWPF.Views;
using DXMVVMSampleWPF.ViewModels;

namespace DXMVVMSampleWPF
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private void OnAppStartup_UpdateThemeName(object sender, StartupEventArgs e)
		{
			DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName();

			InitViewInjection();
		}
		void InitViewInjection()
		{
			ViewInjectionManager.Default.Inject(Regions.Content,
				NavigationKey.Tracks,
				() => TrackListViewModel.Create(),
				typeof(TrackListView));
			ViewInjectionManager.Default.Inject(Regions.Navigation,
				NavigationKey.Tracks,
				() => NavigationItemViewModel.Create("Tracks", NavigationKey.Tracks),
				typeof(NavigationItemView));

			ViewInjectionManager.Default.Inject(Regions.Content,
				NavigationKey.Artists,
				() => ArtistListViewModel.Create(),
				typeof(ArtistListView));

			ViewInjectionManager.Default.Inject(Regions.Navigation,
				NavigationKey.Artists,
				() => NavigationItemViewModel.Create("Artists", NavigationKey.Artists),
				typeof(NavigationItemView));

			ViewInjectionManager.Default.Inject(Regions.Content,
				NavigationKey.Albums,
				() => AlbumTreeViewModel.Create(),
				typeof(AlbumTreeView));

			ViewInjectionManager.Default.Inject(Regions.Navigation,
				NavigationKey.Albums,
				() => NavigationItemViewModel.Create("AlbumTree", NavigationKey.Albums),
				typeof(NavigationItemView));

			ViewInjectionManager.Default.Navigate(Regions.Navigation, NavigationKey.Tracks);

		}
	}
}