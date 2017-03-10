using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DXMVVMSampleWPF.ViewModels
{
	[POCOViewModel]
	public class TrackViewModel
	{
		protected TrackViewModel()
		{
		}
		protected TrackViewModel(int? trackId, string name, int? albumId, int mediaTypeId, int? genreId,
											string composer, int milliSeconds, int? bytes)
		{
			this.TrackId = trackId;
			this.Name = name;
			this.AlbumId = albumId;
			this.MediaTypeId = mediaTypeId;
			this.GenreId = genreId;
			this.Composer = composer;
			this.Milliseconds = milliSeconds;
			this.Bytes = bytes;
		}

		public static TrackViewModel Create()
		{
			var t = new TrackList()[15];

			return ViewModelSource.Create(() => new TrackViewModel(t.TrackId, t.Name, t.AlbumId, t.MediaTypeId, t.GenreId,
											t.Composer, t.Milliseconds, t.Bytes));
		}

		public static TrackViewModel Create(int? trackId, string name, int? albumId, int mediaTypeId, int? genreId,
											string composer, int milliSeconds, int? bytes)
		{
			return ViewModelSource.Create(() => new TrackViewModel(trackId, name, albumId, mediaTypeId, genreId, composer, milliSeconds, bytes));
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
		public int? TrackId { get; set; }
		public virtual string Name { get; set; }
		public virtual int? AlbumId { get; set; }
		public virtual int MediaTypeId { get; set; }
		public virtual int? GenreId { get; set; }
		public virtual string Composer { get; set; }
		public virtual int Milliseconds { get; set; }
		public virtual int? Bytes { get; set; }

		public TrackViewModel Clone()
		{
			return TrackViewModel.Create(TrackId, Name, AlbumId, MediaTypeId, GenreId, Composer, Milliseconds, Bytes);
		}

		public void Assign(TrackViewModel source)
		{
			this.TrackId = source.TrackId;
			this.Name = source.Name;
			this.AlbumId = source.AlbumId;
			this.MediaTypeId = source.MediaTypeId;
			this.GenreId = source.GenreId;
			this.Composer = source.Composer;
			this.Milliseconds = source.Milliseconds;
			this.Bytes = source.Bytes;
		}
	}
}