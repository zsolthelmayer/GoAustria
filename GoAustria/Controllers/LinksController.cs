using GoAustria.Context;
using GoAustria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GoAustria.WebAPI.Controllers
{
    public class LinksController : ApiController
    {
        GoAustriaContext goAustriaContext = new GoAustriaContext();

        // GET api/Links
        public IEnumerable<Link> GetAllLinks()
        {            
            return goAustriaContext.Links.ToList();
        }

        public IHttpActionResult GetLink(int id) {
            var link = goAustriaContext.Links.FirstOrDefault((l) => l.Id == id);
            if (link == null) {
                return NotFound();
            }

            return Ok(link);
        }


        // POST api/Links
        public void Post([FromBody]Link link)
        {
            goAustriaContext.Links.Add(link);
            goAustriaContext.SaveChanges();
        }

        // PUT api/Links/5
        public void Put(int id, [FromBody]Link newLink)
        {
            var link = goAustriaContext.Links.FirstOrDefault((l) => l.Id == id);
            if (link != null)
            {
                link.Sequence = newLink.Sequence;
                link.Title = newLink.Title;
                link.Url = newLink.Url;              
                goAustriaContext.SaveChanges();
            }
        }

        // DELETE api/Links/5
        public void Delete(int id)
        {
            var link = goAustriaContext.Links.FirstOrDefault((l) => l.Id == id);
            if (link != null) {
                goAustriaContext.Links.Remove(link);
                goAustriaContext.SaveChanges();
            }
        }
    }
}