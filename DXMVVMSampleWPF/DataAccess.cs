using DXMVVMSampleWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXMVVMSampleWPF
{
	public class LookupItem
	{
		public int Key { get; set; }
		public string Value { get; set; }
	}
	public class DataAccess
	{
		static TrackList data = new TrackList();
		public static IEnumerable<TrackViewModel> GetTrackViewModelList()
		{

			foreach (var track in data)
				yield return TrackViewModel.Create(track.TrackId,
									 track.Name,
									 track.AlbumId,
									 track.MediaTypeId,
									 track.GenreId,
									 track.Composer,
									 track.Milliseconds,
									 track.Bytes);
		}

		public static void PersistTrack(TrackViewModel track)
		{
			TrackInfo pTrack = track.TrackId.HasValue ?
				   data.First(t => t.TrackId == track.TrackId) :
				   new TrackInfo();

			pTrack.Name = track.Name;
			pTrack.AlbumId = track.AlbumId;
			pTrack.MediaTypeId = track.MediaTypeId;
			pTrack.GenreId = track.GenreId;
			pTrack.Composer = track.Composer;
			pTrack.Milliseconds = track.Milliseconds;
			pTrack.Bytes = track.Bytes;

			if (!track.TrackId.HasValue)
				data.Add(pTrack);
		}
	}
}
