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

			String mailBody = value.PaymentMethod == 0 ? Constants.TRANSFER_MAIL : Constants.CASH_ON_DELIVERY_MAIL;

			mailBody = mailBody
				.Replace("$NAME$", value.OrdSurname + " " + value.OrdFirstname)
				.Replace("$DATE$", now.ToString("yyyy.MM.dd"))
				.Replace("$ORDER_NUMBER$", value.OrderDateTime.ToString("yyyyMMddHHmmss"))
				.Replace("$ORDER_DATE$", now.ToString("yyyy.MM.dd HH:mm:ss"))
				.Replace("$QTY$", value.Qty.ToString())
				.Replace("$PRICE$", value.Price.Replace("Ft", ""))
				.Replace("$TRANS_PRICE$", value.PostalFee.Replace("Ft", ""))
				.Replace("$SUM_PRICE$", 
					(int.Parse(value.PostalFee.Replace("Ft", "").Trim()) + 
					int.Parse(value.Price.Replace("Ft", "").Trim())
					).ToString())
				.Replace("$EMAIL$", value.OrdEmail)
				.Replace("$PHONE$", value.OrdPhone)
				.Replace("$TRANS_ADDRESS$", value.TransCountry + "," + value.TransPostalCode + ", " + value.TransCity + "," + value.TransAddress)
				.Replace("$INV_NAME$",value.InvName)
				.Replace("$INV_COUNTRY$", value.InvCountry)
				.Replace("$INV_POSTAL_CODE$", value.InvPostalCode)
				.Replace("$INV_CITY$", value.InvCity)
				.Replace("$INV_ADDRESS$", value.InvAddress);



			new MessageHelper().SendMessage("info@ausztriamunka.hu", value.OrdEmail, "Megrendelés - (Rendelésszám: " + now.ToString("yyyyMMddHHmmss")+ ")", mailBody);
			new MessageHelper().SendMessage("info@ausztriamunka.hu", "info@ausztriamunka.hu", "Megrendelés - (Rendelésszám: " + now.ToString("yyyyMMddHHmmss") + ")", mailBody);

		}

	}
}