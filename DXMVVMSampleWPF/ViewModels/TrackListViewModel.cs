using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using DevExpress.Xpf.Reports.UserDesigner.Extensions;

namespace DXMVVMSampleWPF.ViewModels
{
	[POCOViewModel]
	public class TrackListViewModel
	{
		public virtual ObservableCollection<TrackViewModel> Items
		{
			get;
			/* We only want to set this through the ViewModel code */
			protected set;
		}
		//CurrentTrack is only needed for Winforms app since the WinForms Grid doesn't have a RowDblClick event
		public virtual TrackViewModel CurrentItem { get; set; }
		public virtual bool IsLoading
		{
			get;
			protected set;
		}

		protected TrackListViewModel()
		{
			ViewInjectionManager.Default.RegisterNavigatedEventHandler(this, () => {
					ViewInjectionManager.Default.Navigate(Regions.Navigation, NavigationKey.Tracks);
				});
		}

		public static TrackListViewModel Create()
		{
			return ViewModelSource.Create(() => new TrackListViewModel());
		}

		[ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
		public virtual IDialogService DialogService { get { return null; } }
		[ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
		protected virtual IDispatcherService DispatcherService { get { return null; } }

		[ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
		protected virtual IReportManagerService ReportManagerService { get { return null; } }


		public void EditItem(TrackViewModel item)
		{
			var editItem = item.Clone();
			if (DialogService.ShowDialog(
				MessageButton.OKCancel, "Edit Track", "TrackView", editItem) == MessageResult.OK)
			{
				item.Assign(editItem);
				DataAccess.PersistTrack(item);
			}
		}

		public Task LoadTracks()
		{
			IsLoading = true;

			return Task.Factory.StartNew((state) =>
			{
				var results = new ObservableCollection<TrackViewModel>(DataAccess.GetTrackViewModelList());
				// Update on UI Thread
				((IDispatcherService)state).BeginInvoke(() => {
					Items = results;
					IsLoading = false;
				});

			}, DispatcherService);
		}
	}
}