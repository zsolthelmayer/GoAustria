using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoAustria.Models
{
	public class Order
	{
			
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { set; get; }

		public int Qty { set; get; }

		public String Price { set; get; }


		public String OrdFirstname { set; get; }
		public String OrdSurname { set; get; }
		public String OrdEmail { set; get; }
		public String OrdPhone { set; get; }

		public String TransName { set; get; }
		public String TransPostalCode { set; get; }
		public String TransCity { set; get; }
		public String TransAddress { set; get; }
		public String TransCountry { set; get; }
		public String TransPhone { set; get; }

		public String InvName { set; get; }
		public String InvPostalCode { set; get; }
		public String InvCity { set; get; }
		public String InvAddress { set; get; }
		public String InvCountry { set; get; }
		public String InvPhone { set; get; }
		public String InvTaxNum { set; get; }

		public int PaymentMethod { set; get; }
		public String PostalFee { set; get; }

		public String Comment { set; get; }

		public DateTime OrderDateTime { set; get; }
		
	}
}