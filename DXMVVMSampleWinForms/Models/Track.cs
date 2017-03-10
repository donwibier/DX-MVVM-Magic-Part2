using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

[Table("Track")]
public partial class Track
{
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public Track()
	{
		InvoiceLine = new HashSet<InvoiceLine>();
		Playlist = new HashSet<Playlist>();
	}

	public int TrackId { get; set; }

	[Required]
	[StringLength(200)]
	public string Name { get; set; }

	public int? AlbumId { get; set; }

	public int MediaTypeId { get; set; }

	public int? GenreId { get; set; }

	[StringLength(220)]
	public string Composer { get; set; }

	public int Milliseconds { get; set; }

	public int? Bytes { get; set; }

	[Column(TypeName = "numeric")]
	public decimal UnitPrice { get; set; }

	public virtual Album Album { get; set; }

	public virtual Genre Genre { get; set; }

	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public virtual ICollection<InvoiceLine> InvoiceLine { get; set; }

	public virtual MediaType MediaType { get; set; }

	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public virtual ICollection<Playlist> Playlist { get; set; }
}
