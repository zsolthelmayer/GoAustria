using GoAustria.Context;
using GoAustria.Models;
using GoAustria.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GoAustria.Controllers
{
	public class OrdersController : ApiController
	{
		GoAustriaContext goAustriaContext = new GoAustriaContext();

		// GET api/<controller>
		public IEnumerable<Order> GetAllOrders()
		{
			return goAustriaContext.Orders.ToList();
		}


		// POST api/<controller>
		public void Post([FromBody]Order value)
		{
			value.OrderDateTime = DateTime.Now;
			goAustriaContext.Orders.Add(value);
			goAustriaContext.SaveChanges();

			DateTime now = DateTime.Now;

			String body = @"
Kedves " + value.OrdSurname + " " + value.OrdFirstname + @"!

A mai napon (" + now.ToString("yyyy.MM.dd") + @".) a következő rendelést adtad le internetes áruházunkban:

Rendelési adatok
Rendelésszám:	" + value.OrderDateTime.ToString("yyyyMMddHHmmss") + @"
Rendelés dátuma:	" + now.ToString("yyyy.MM.dd HH:mm:ss") + @"

Termék neve	Mennyiség	Fogyasztói ár	Összesen
Munkavállalás Ausztriában Lépésről Lépésre Könyv	" + value.Qty + @" db	" + value.Price + @"
Szállítási költség:	" + value.PostalFee + @"
Összesen:	" + (int.Parse(value.PostalFee.Replace("Ft","").Trim()) + int.Parse(value.Price.Replace("Ft", "").Trim()))  + @" Ft

Megrendelő adatai
E-mail:	" + value.OrdEmail + @"
Telefonszám:		" + value.OrdPhone + @"

Szállítási adatok
Házhoz szállítás	" + value.TransCountry + "," + value.TransPostalCode + ", " + value.TransCity + "," + value.TransAddress + @"

Számlázási adatok
Név:		" + value.InvName + @"
Ország:		" + value.InvCountry + @"
Irányítószám:		" + value.InvPostalCode + @"
Település:		" + value.InvCity + @"
Utca, házszám:		" + value.InvAddress + @"

Szállítási mód
 	Házhoz szállítás

Fizetési mód
 	" + (value.PaymentMethod == 1 ? "Átutalás" : "Utánvét") + @" 
Számlatulajdonos neve: Kóbor Alexandra E.V.
Az átutalást a következő bankszámlaszámra kérjük: 11600006-00000000-83591781 
Ezt írd a közleménybe: " + value.InvName + @", " + now.ToString("yyyyMMddHHmmss") + @" 

Köszönjük megrendelésedet! 
Kérdés esetén keress minket bizalommal az info@ausztriamunka.hu email címen.


Legyen ma is szép napod! 

Kóbor Alexandra E.V.
www.ausztriamunka.hu
				";

			new MessageHelper().SendMessage("info@ausztriamunka.hu", value.OrdEmail, "Megrendelés - (Rendelésszám: " + now.ToString("yyyyMMddHHmmss")+ ")", body);
			new MessageHelper().SendMessage("info@ausztriamunka.hu", "info@ausztriamunka.hu", "Megrendelés - (Rendelésszám: " + now.ToString("yyyyMMddHHmmss") + ")", body);

		}

	}
}