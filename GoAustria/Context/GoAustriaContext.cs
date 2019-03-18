using GoAustria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoAustria.Context
{
    public class GoAustriaContext : DbContext
    {
        public DbSet<Link> Links {set; get;}
        public DbSet<User> Users { set; get; }
		public DbSet<Order> Orders { set; get; }
	}
}