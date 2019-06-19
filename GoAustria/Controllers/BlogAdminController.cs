using GoAustria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;


namespace GoAustria.WebAPI.Controllers
{
    public class BlogAdminController : ApiController
    {
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();

        // GET: api/Blogs
        public IEnumerable<Blog> GetAllBlogs()
        {
            return applicationDbContext.Blogs.ToList();
        }

        public IHttpActionResult GetBlog(int id)
        {
            var blog = applicationDbContext.Blogs.FirstOrDefault((l) => l.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return Ok(blog);
        }

        // POST api/Links
        public void Post([FromBody]Blog blog)
        {
            applicationDbContext.Blogs.Add(blog);
            applicationDbContext.SaveChanges();
        }

        // PUT api/Links/5 (Save)
        public void Put(int id, [FromBody]Blog newBlog)
        {
            var blog = applicationDbContext.Blogs.FirstOrDefault((l) => l.Id == id);
            if (blog != null)
            {
                blog.Title = newBlog.Title;
                blog.Content = newBlog.Content;
                blog.Author = newBlog.Author;
                blog.Active = newBlog.Active;
                applicationDbContext.SaveChanges();
            }
        }


        // DELETE api/Links/5
        public void Delete(int id)
        {
            var link = applicationDbContext.Blogs.FirstOrDefault((l) => l.Id == id);
            if (link != null)
            {
                applicationDbContext.Blogs.Remove(link);
                applicationDbContext.SaveChanges();
            }
        }


    }
}