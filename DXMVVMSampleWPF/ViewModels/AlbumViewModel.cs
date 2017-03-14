using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace DXMVVMSampleWPF.ViewModels
{
	[POCOViewModel]
	public class AlbumViewModel
	{
		protected AlbumViewModel()
		{
		}
		protected AlbumViewModel(int? albumId, string name, int trackcount)
		{
			this.AlbumId = albumId;
			this.Name = name;
			this.TrackCount = trackcount;

			//calculated fields here

			//lookup data here
		}

		public static AlbumViewModel Create()
		{
			var t = new TrackList()[15];

			return ViewModelSource.Create(() => new AlbumViewModel(-1, "Don Wibier", 0));
		}

		public static AlbumViewModel Create(int? albumId, string name, int trackcount)
		{
			return ViewModelSource.Create(() => new AlbumViewModel(albumId, name, trackcount));
		}
		public bool CanResetName()
		{
			return !String.IsNullOrEmpty(Name);
		}
		public void ResetName()
		{
			if (MessageBoxService.ShowMessage("Are you sure you want to reset the Name value?",
								"Question",
								MessageButton.YesNo,
								MessageIcon.Question,
								MessageResult.No) == MessageResult.Yes)
				Name = "";
		}

		[ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
		protected virtual IMessageBoxService MessageBoxService { get { return null; } }
		protected virtual ICurrentWindowService CurrentWindowService { get { return null; } }

		[Editable(false)]
		public int? AlbumId { get; set; }
		public virtual string Name { get; set; }

		public virtual int TrackCount { get; set; }

		private ObservableCollection<TrackViewModel> _Items = null;
		public virtual ObservableCollection<TrackViewModel> Items
		{
			get
			{
				if (_Items == null)
				{
					_Items = new ObservableCollection<TrackViewModel>(DataAccess.GetTrackViewModelList(this.AlbumId ?? 0));
				}
				return _Items;
			}
			set { _Items = value; }
		}

		public AlbumViewModel Clone()
		{
			return AlbumViewModel.Create(AlbumId, Name, TrackCount);
		}

		public void Assign(AlbumViewModel source)
		{
			this.AlbumId = source.AlbumId;
			this.Name = source.Name;
			this.TrackCount = source.TrackCount;
			this.Items = source.Items;
		}
	}
}