using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using DevExpress.Mvvm.POCO;
using System.Threading.Tasks;

namespace DXMVVMSampleWPF.ViewModels
{
	[POCOViewModel]
	public class ArtistListViewModel
	{
		public virtual ObservableCollection<ArtistViewModel> Items
		{
			get;
			/* We only want to set this through the ViewModel code */
			protected set;
		}
		//CurrentTrack is only needed for Winforms app since the WinForms Grid doesn't have a RowDblClick event
		public virtual ArtistViewModel CurrentItem { get; set; }
		public virtual bool IsLoading
		{
			get;
			protected set;
		}

		protected ArtistListViewModel()
		{
#if(WPF)
			ViewInjectionManager.Default.RegisterNavigatedEventHandler(this, () => {
					ViewInjectionManager.Default.Navigate(Regions.Navigation, NavigationKey.Artists);
				});
#endif
		}

		public static ArtistListViewModel Create()
		{
			return ViewModelSource.Create(() => new ArtistListViewModel());
		}

		[ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
		public virtual IDialogService DialogService { get { return null; } }
		[ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
		protected virtual IDispatcherService DispatcherService { get { return null; } }


		public void EditItem(ArtistViewModel item)
		{
			var editItem = item.Clone();
			if (DialogService.ShowDialog(
				MessageButton.OKCancel, "Edit Artist", "ArtistView", editItem) == MessageResult.OK)
			{
				item.Assign(editItem);
				DataAccess.PersistArtist(item);
			}
		}

		public Task LoadTracks()
		{
			IsLoading = true;

			return Task.Factory.StartNew((state) =>
			{
				var results = new ObservableCollection<ArtistViewModel>(DataAccess.GetArtistViewModelList());
				// Update on UI Thread
				((IDispatcherService)state).BeginInvoke(() => {
					Items = results;
					IsLoading = false;
				});

			}, DispatcherService);
		}
	}
}