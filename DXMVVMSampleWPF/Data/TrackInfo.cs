using System;
using System.ComponentModel;

public class TrackInfo : INotifyPropertyChanged
{
    public TrackInfo() { }
    public TrackInfo(int trackId, string name, int albumId, int mediaTypeId,
                        int genreId, string composer, int milliseconds, int bytes)
    {
        TrackId = trackId;
        Name = name;
        AlbumId = albumId;
        MediaTypeId = mediaTypeId;
        GenreId = genreId;
        Composer = composer;
        Milliseconds = milliseconds;
        Bytes = bytes;
    }

    int trackId;
    public int TrackId
    {
        get { return trackId; }
        set
        {
            if (trackId == value)
                return;
            trackId = value;
            OnPropertyChanged("TrackId");
        }
    }

    string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (name == value)
                return;
            name = value;
            OnPropertyChanged("Name");
        }
    }
    int? albumId;
    public int? AlbumId
    {
        get { return albumId; }
        set
        {
            if (albumId == value)
                return;
            albumId = value;
            OnPropertyChanged("AlbumId");
        }
    }
    int mediaTypeId;
    public int MediaTypeId
    {
        get { return mediaTypeId; }
        set
        {
            if (mediaTypeId == value)
                return;
            mediaTypeId = value;
            OnPropertyChanged("MediaTypeId");
        }
    }
    int? genreId;
    public int? GenreId
    {
        get { return genreId; }
        set
        {
            if (genreId == value)
                return;
            genreId = value;
            OnPropertyChanged("GenreId");
        }
    }
    string composer;
    public string Composer
    {
        get { return composer; }
        set
        {
            if (composer == value)
                return;
            composer = value;
            OnPropertyChanged("Composer");
        }
    }
    int milliseconds;
    public int Milliseconds
    {
        get { return milliseconds; }
        set
        {
            if (milliseconds == value)
                return;
            milliseconds = value;
            OnPropertyChanged("Milliseconds");
        }
    }
    int? bytes;
    public int? Bytes
    {
        get { return bytes; }
        set
        {
            if (bytes == value)
                return;
            bytes = value;
            OnPropertyChanged("Bytes");
        }
    }



    public override string ToString()
    {
        return String.Format("Name: {0}, Milliseconds: {1}, Composer: {2}",
          Name, Milliseconds, Composer);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        var handler = PropertyChanged;
        if (handler != null)
            handler(this, new PropertyChangedEventArgs(propertyName));
    }
}