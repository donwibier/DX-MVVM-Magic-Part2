using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

[Table("InvoiceLine")]
public partial class InvoiceLine
{
	public int InvoiceLineId { get; set; }

	public int InvoiceId { get; set; }

	public int TrackId { get; set; }

	[Column(TypeName = "numeric")]
	public decimal UnitPrice { get; set; }

	public int Quantity { get; set; }

	public virtual Invoice Invoice { get; set; }

	public virtual Track Track { get; set; }
}

