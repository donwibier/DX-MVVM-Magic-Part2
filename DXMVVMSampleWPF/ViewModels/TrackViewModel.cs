using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DXMVVMSampleWPF.ViewModels
{
	[POCOViewModel]
	public class TrackViewModel
	{
		protected TrackViewModel()
		{
		}
		protected TrackViewModel(int? trackId, string name, int? albumId, int mediaTypeId, int? genreId,
											string composer, int milliSeconds, int? bytes,
											IList<LookupItem> albumLookupData,
											IList<LookupItem> mediaLookupData,
											IList<LookupItem> genreLookupData)
		{
			this.TrackId = trackId;
			this.Name = name;
			this.AlbumId = albumId;
			this.MediaTypeId = mediaTypeId;
			this.GenreId = genreId;
			this.Composer = composer;
			this.Milliseconds = milliSeconds;
			this.Bytes = bytes;

			//calculated fields here

			//lookup data here
			this.AlbumLookupData = albumLookupData;
			this.MediaLookupData = mediaLookupData;
			this.GenreLookupData = genreLookupData;
		}

		public static TrackViewModel Create()
		{
			var t = new TrackList()[15];

			return ViewModelSource.Create(() => new TrackViewModel(t.TrackId, t.Name, t.AlbumId, t.MediaTypeId, t.GenreId,
											t.Composer, t.Milliseconds, t.Bytes, null, null, null));
		}

		public static TrackViewModel Create(int? trackId, string name, int? albumId,
											int mediaTypeId, int? genreId,
											string composer, int milliSeconds, int? bytes,
											IList<LookupItem> albumLookupData,
											IList<LookupItem> mediaLookupData,
											IList<LookupItem> genreLookupData)
		{
			return ViewModelSource.Create(() => new TrackViewModel(trackId, name, albumId, mediaTypeId,
				genreId, composer, milliSeconds, bytes,
				albumLookupData, mediaLookupData, genreLookupData));
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

		public virtual IList<LookupItem> AlbumLookupData { get; protected set; }
		public virtual IList<LookupItem> MediaLookupData { get; protected set; }
		public virtual IList<LookupItem> GenreLookupData { get; protected set; }

		public TrackViewModel Clone()
		{
			return TrackViewModel.Create(TrackId, Name, AlbumId, MediaTypeId, GenreId, Composer, Milliseconds, Bytes,
											AlbumLookupData, MediaLookupData, GenreLookupData);
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

			this.AlbumLookupData = source.AlbumLookupData;
			this.MediaLookupData = source.MediaLookupData;
			this.GenreLookupData = source.GenreLookupData;
		}
	}
}