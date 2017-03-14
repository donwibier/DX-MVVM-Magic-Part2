using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace DXMVVMSampleWPF.ViewModels
{
	[POCOViewModel]
	public class AlbumViewModel
	{
		protected AlbumViewModel()
		{
		}
		protected AlbumViewModel(int? albumId, string name, IEnumerable<TrackViewModel> tracks)
		{
			this.AlbumId = albumId;
			this.Name = name;
			
			this.Items = (tracks == null) ? new ObservableCollection<TrackViewModel>() :  new ObservableCollection<TrackViewModel>(tracks);

			//calculated fields here

			//lookup data here
		}

		public static AlbumViewModel Create()
		{
			return ViewModelSource.Create(() => new AlbumViewModel(-1, "No Name", null));
		}

		public static AlbumViewModel Create(int? albumId, string name, IEnumerable<TrackViewModel> tracks)
		{
			return ViewModelSource.Create(() => new AlbumViewModel(albumId, name, tracks));
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

		public virtual ObservableCollection<TrackViewModel> Items { get; set; }

		public AlbumViewModel Clone()
		{
			return AlbumViewModel.Create(AlbumId, Name, Items);
		}

		public void Assign(AlbumViewModel source)
		{
			this.AlbumId = source.AlbumId;
			this.Name = source.Name;
			
			this.Items = source.Items;
		}
	}
}