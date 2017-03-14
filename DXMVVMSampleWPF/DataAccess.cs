using DevExpress.Xpf.Grid;
using DXMVVMSampleWPF.ViewModels;
using System;
using System.Collections;
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
	public enum NavigationKey
	{
		Tracks,
		Artists,
		Albums
	}
	public static class Regions
	{
		public static string Navigation { get { return "NavigationRegion"; } }
		public static string Content { get { return "ContentRegion"; } }
	}

	public class DataAccess
	{

		// DO NOT REMOVE THIS !!
		//static TrackList data = new TrackList();
		//public static IEnumerable<TrackViewModel> GetTrackViewModelList()
		//{

		//	foreach (var track in data)
		//		yield return TrackViewModel.Create(track.TrackId,
		//							 track.Name,
		//							 track.AlbumId,
		//							 track.MediaTypeId,
		//							 track.GenreId,
		//							 track.Composer,
		//							 track.Milliseconds,
		//							 track.Bytes);
		//}

		//public static void PersistTrack(TrackViewModel track)
		//{
		//	TrackInfo pTrack = track.TrackId.HasValue ?
		//		   data.First(t => t.TrackId == track.TrackId) :
		//		   new TrackInfo();

		//	pTrack.Name = track.Name;
		//	pTrack.AlbumId = track.AlbumId;
		//	pTrack.MediaTypeId = track.MediaTypeId;
		//	pTrack.GenreId = track.GenreId;
		//	pTrack.Composer = track.Composer;
		//	pTrack.Milliseconds = track.Milliseconds;
		//	pTrack.Bytes = track.Bytes;

		//	if (!track.TrackId.HasValue)
		//		data.Add(pTrack);
		//}

		public static IEnumerable<TrackViewModel> GetTrackViewModelList()
		{
			using (var ctx = new ChinookContext())
			{
				var albumLookupData = (from album in ctx.Album
									   select new LookupItem { Key = album.AlbumId, Value = album.Title }).ToList();
				var mediaLookupData = (from media in ctx.MediaType
									   select new LookupItem() { Key = media.MediaTypeId, Value = media.Name }).ToList();
				var genreLookupData = (from genre in ctx.Genre
									   select new LookupItem { Key = genre.GenreId, Value = genre.Name }).ToList();

				foreach (var track in ctx.Track)
					yield return TrackViewModel.Create(track.TrackId,
										 track.Name,
										 track.AlbumId,
										 track.MediaTypeId,
										 track.GenreId,
										 track.Composer,
										 track.Milliseconds,
										 track.Bytes,
										 albumLookupData,
										 mediaLookupData,
										 genreLookupData);
			}
		}

		public static IEnumerable<TrackViewModel> GetTrackViewModelList(int albumid)
		{
			using (var ctx = new ChinookContext())
			{
				var albumLookupData = (from album in ctx.Album
									   select new LookupItem { Key = album.AlbumId, Value = album.Title }).ToList();
				var mediaLookupData = (from media in ctx.MediaType
									   select new LookupItem() { Key = media.MediaTypeId, Value = media.Name }).ToList();
				var genreLookupData = (from genre in ctx.Genre
									   select new LookupItem { Key = genre.GenreId, Value = genre.Name }).ToList();

				foreach (var track in ctx.Track.Where(x => x.AlbumId == albumid))
					yield return TrackViewModel.Create(track.TrackId,
										 track.Name,
										 track.AlbumId,
										 track.MediaTypeId,
										 track.GenreId,
										 track.Composer,
										 track.Milliseconds,
										 track.Bytes,
										 albumLookupData,
										 mediaLookupData,
										 genreLookupData);
			}
		}


		public static void PersistTrack(TrackViewModel track)
		{
			using (var ctx = new ChinookContext())
			{
				Track pTrack = track.TrackId.HasValue ?
					ctx.Track.First(t => t.TrackId == track.TrackId) :
					new Track();
				pTrack.Name = track.Name;
				pTrack.AlbumId = track.AlbumId;
				pTrack.MediaTypeId = track.MediaTypeId;
				pTrack.GenreId = track.GenreId;
				pTrack.Composer = track.Composer;
				pTrack.Milliseconds = track.Milliseconds;
				pTrack.Bytes = track.Bytes;
				ctx.SaveChanges();
			}
		}
		public static IEnumerable<ArtistViewModel> GetArtistViewModelList()
		{
			using (var ctx = new ChinookContext())
			{
				foreach (var artist in ctx.Artist)
					yield return ArtistViewModel.Create(artist.ArtistId, artist.Name);
			}
		}
		public static void PersistArtist(ArtistViewModel artist)
		{
			using (var ctx = new ChinookContext())
			{
				Artist pArtist = artist.ArtistId.HasValue ?
					ctx.Artist.First(t => t.ArtistId == artist.ArtistId) :
					new Artist();

				pArtist.Name = artist.Name;
				ctx.SaveChanges();
			}

		}
		public static IEnumerable<AlbumViewModel> GetAlbumViewModelList()
		{
			using (var ctx = new ChinookContext())
			{
				foreach (var album in ctx.Album)
					yield return AlbumViewModel.Create(album.ArtistId, album.Title, album.Track.Count());
			}
		}
		public static void PersistAlbum(AlbumViewModel album)
		{
			using (var ctx = new ChinookContext())
			{
				Album pAlbum = album.AlbumId.HasValue ?
					ctx.Album.First(t => t.AlbumId == album.AlbumId) :
					new Album();

				pAlbum.Title = album.Name;
				ctx.SaveChanges();
			}
		}

	}

	public class CustomChildrenSelector : IChildNodesSelector
	{
		public IEnumerable SelectChildren(object item)
		{
			if (item is AlbumViewModel)
				return (item as AlbumViewModel).Items;
			return null;
		}
	}
}
