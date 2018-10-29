using GoAustria.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoAustria.Controllers
{
    public class LinkController : Controller
    {
        GoAustriaContext goAustriaContext = new GoAustriaContext();

        public ActionResult Index(int sequence)
        {
            var link = goAustriaContext.Links.FirstOrDefault((l) => l.Sequence == sequence);
            if (link != null)
            {
                return Redirect(link.Url);
            }

            return View();
        }


    }
}