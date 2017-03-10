using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.ComponentModel.DataAnnotations;

namespace DXMVVMSampleWPF.ViewModels
{
	[POCOViewModel]
	public class AlbumViewModel
	{
		protected AlbumViewModel()
		{
		}
		protected AlbumViewModel(int? albumId, string name)
		{
			this.AlbumId = albumId;
			this.Name = name;

			//calculated fields here

			//lookup data here
		}

		public static AlbumViewModel Create()
		{
			var t = new TrackList()[15];

			return ViewModelSource.Create(() => new AlbumViewModel(-1, "Don Wibier"));
		}

		public static AlbumViewModel Create(int? albumId, string name)
		{
			return ViewModelSource.Create(() => new AlbumViewModel(albumId, name));
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

		public AlbumViewModel Clone()
		{
			return AlbumViewModel.Create(AlbumId, Name);
		}

		public void Assign(AlbumViewModel source)
		{
			this.AlbumId = source.AlbumId;
			this.Name = source.Name;
		}
	}
}