using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DXMVVMSampleWPF.ViewModels
{

	[POCOViewModel]
	public class NavigationItemViewModel
	{
		public virtual string Title { get; set; }
		public NavigationKey NavigationKey { get; set; }
		protected NavigationItemViewModel(string title, NavigationKey navigationKey)
		{
			Title = title;
			NavigationKey = navigationKey;

			ViewInjectionManager.Default.RegisterNavigatedEventHandler(this, () =>
			{
				ViewInjectionManager.Default.Navigate(Regions.Content, this.NavigationKey);
			});

		}
		public static NavigationItemViewModel Create(string title, NavigationKey navigationKey)
		{
			return ViewModelSource.Create(() => new NavigationItemViewModel(title, navigationKey));
		}

	}
}