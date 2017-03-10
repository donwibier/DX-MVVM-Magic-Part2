using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace DXMVVMSampleWinForms.ViewModels
{
	[POCOViewModel]
	public class TrackListViewModel
	{
		public virtual ObservableCollection<TrackViewModel> Tracks
		{
			get;
			/* We only want to set this through the ViewModel code */
			protected set;
		}
		//CurrentTrack is only needed for Winforms app since the WinForms Grid doesn't have a RowDblClick event
		public virtual TrackViewModel CurrentTrack { get; set; }
		public virtual bool IsLoading
		{
			get;
			protected set;
		}

		protected TrackListViewModel()
		{
		}

		public static TrackListViewModel Create()
		{
			return ViewModelSource.Create(() => new TrackListViewModel());
		}

		[ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
		public virtual IDialogService DialogService { get { return null; } }
		[ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
		protected virtual IDispatcherService DispatcherService { get { return null; } }


		public void EditTrack(TrackViewModel track)
		{
			var trackClone = track.Clone();
			if (DialogService.ShowDialog(
				MessageButton.OKCancel, "Edit Track", "TrackView", trackClone) == MessageResult.OK)
			{
				track.Assign(trackClone);
				DataAccess.PersistTrack(track);
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
					Tracks = results;		  
					IsLoading = false;
				});
				
			}, DispatcherService);
		}
	}
}