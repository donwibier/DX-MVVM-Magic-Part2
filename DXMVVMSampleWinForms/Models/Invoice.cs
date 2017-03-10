using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

[Table("Invoice")]
public partial class Invoice
{
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public Invoice()
	{
		InvoiceLine = new HashSet<InvoiceLine>();
	}

	public int InvoiceId { get; set; }

	public int CustomerId { get; set; }

	public DateTime InvoiceDate { get; set; }

	[StringLength(70)]
	public string BillingAddress { get; set; }

	[StringLength(40)]
	public string BillingCity { get; set; }

	[StringLength(40)]
	public string BillingState { get; set; }

	[StringLength(40)]
	public string BillingCountry { get; set; }

	[StringLength(10)]
	public string BillingPostalCode { get; set; }

	[Column(TypeName = "numeric")]
	public decimal Total { get; set; }

	public virtual Customer Customer { get; set; }

	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public virtual ICollection<InvoiceLine> InvoiceLine { get; set; }
}

