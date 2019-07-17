using GoAustria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;


namespace GoAustria.WebAPI.Controllers
{
    public class BlogEditController : ApiController
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

        // PUT api/BlogAdmin/5 (Save)
        [ValidateInput(false)]
        public void Put(int id, [FromBody]Blog newBlog)
        {

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Blog blog = db.Blogs.SingleOrDefault(s => s.Id == id);
                blog.Content = newBlog.Content;
                blog.Active = newBlog.Active;
                blog.Author = newBlog.Author;
                blog.Title = newBlog.Title;
                db.SaveChanges();

             
            }


            // var blog = applicationDbContext.Blogs.FirstOrDefault((l) => l.Id == id);
            // if (blog != null)
            //{
            //blog.Title = newBlog.Title;
            //  blog.Content = newBlog.Content;
            //     blog.Author = newBlog.Author;
            //  blog.Active = newBlog.Active;
            //  applicationDbContext.SaveChanges();


        }
    }
}