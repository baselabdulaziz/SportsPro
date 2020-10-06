using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SportsPro.Models
{
    public class Customer
    {
		public int CustomerID { get; set; }

		
		[Required(ErrorMessage = "Required")]
		[StringLength(51, ErrorMessage = "Must be 51 characters or less")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Required")]
		[StringLength(51, ErrorMessage = "Must be 51 characters or less")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Required")]
		[StringLength(51, ErrorMessage = "Must be 51 characters or less")]
		public string Address { get; set; }

		[Required(ErrorMessage = "Required")]
		[StringLength(51, ErrorMessage = "Must be 51 characters or less")]
		public string City { get; set; }

		[Required(ErrorMessage = "Required")]
		[StringLength(51, ErrorMessage = "Must be 51 characters or less")]
		public string State { get; set; }

		[Required(ErrorMessage = "Required")]
		[StringLength(21, ErrorMessage = "Must be 21 characters or less")]
		public string PostalCode { get; set; }

		[Required]
		public string CountryID { get; set; }
		public Country Country { get; set; }

		[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
			ErrorMessage = "Entered phone format is not valid.")]

		public string Phone { get; set; }

		public string Email { get; set; }

		public string FullName => FirstName + " " + LastName;   // read-only property
	}
}