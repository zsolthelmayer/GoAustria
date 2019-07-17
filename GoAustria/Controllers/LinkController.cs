using GoAustria.Context;
using GoAustria.Models;
using GoAustria.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace GoAustria.Controllers
{
    public class LinkController : Controller
    {        
        
   
        public ActionResult Index()
        {
            using (GoAustriaContext db = new GoAustriaContext()) {

                var usr = db.Users.FirstOrDefault(u => u.Username == "admin");
                if (usr == null) {
                    User admin = new User()
                    {
                        Username = "admin",
                        Password = EncryptPassword("admin")
                    };

                    db.Users.Add(admin);
                    db.SaveChanges();
                }
            }
                return View();
        }

		public ActionResult Aszf()
		{
			return View();
		}


		public ActionResult Adatkezeles()
		{
			return View();
		}

		public ActionResult Order()
		{
			return View();
		}

		public ActionResult ComingSoon()
		{
			return View();
		}

  

        public ActionResult Blog(int? page)
        {
            ApplicationDbContext ap = new ApplicationDbContext();
            List<Blog> lista = new List<Blog>();
            foreach (var item in ap.Blogs.ToList()) {
                if (item.Active == true) {
                    lista.Add(new Blog {
                        Author = item.Author,
                        Title = item.Title,
                        Content = item.Content
                        


                    });
                }
            }
                
                
                return View(lista.ToPagedList(page ?? 1,2));
            
            
            
        }
        public ActionResult BlogAdmin()
        {
            return View();
        }

        public ActionResult Generic()
        {
            return View();
        }
        public ActionResult BlogEdit()
        {
            return View();
        }

        public ActionResult BlogEditView()
        {
            return View();
        }

        public ActionResult BlogEditList()
        {
            return View();
        }


        [ValidateInput(false)]
        [HttpPost]
        public ActionResult BlogEdit(Blog b)
        {
            if (ModelState.IsValid)
            {

                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    Blog blog = db.Blogs.SingleOrDefault(s => s.Id == b.Id);
                    blog.Content = b.Content;
                    blog.Active = b.Active;
                    db.SaveChanges();


                }


            }
            return View();

        }




        public ActionResult Create()
        {
            return View();
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Create(Blog b)
        {
            if (ModelState.IsValid)
            {

                using (var ctx = new ApplicationDbContext())

                using (ApplicationDbContext db = new ApplicationDbContext())
                {


                    ctx.Blogs.Add(b);
                    ctx.SaveChanges();
                    return RedirectToAction("Index");


                }
               

            }
            return View();

        }

        public ActionResult Linkgyujtemeny()
		{
			byte[] contents = System.IO.File.ReadAllBytes(Server.MapPath(Url.Content("~/Content/linkgyujtemeny.pdf")));
			Response.AddHeader("Content-Disposition", "inline; filename=linkgyujtemeny.pdf");
			return File(contents, "application/pdf");
		}


		public ActionResult Link(int id)
        {
            using (GoAustriaContext db = new GoAustriaContext())
            {
                var link = db.Links.FirstOrDefault((l) => l.Sequence == id);
                if (link != null)
                {
                    return Redirect(link.Url);
                }

                return View();
            }
        }

        public ActionResult Login() {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user) {
            using (GoAustriaContext db = new GoAustriaContext())
            {
                String pwd = EncryptPassword(user.Password);
                var usr = db.Users.FirstOrDefault(u => u.Username == user.Username && u.Password == pwd);
                if (usr != null)
                {
                    Session["UserId"] = user.UserId.ToString();
                    Session["Username"] = user.Username.ToString();
                    return RedirectToAction("Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is wrong.");
                }
            }

            return View();
        }

        public ActionResult Admin() {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

        public ActionResult Error()
        {
            return View();
        }

        private static String EncryptPassword(String password) {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }
    }
}