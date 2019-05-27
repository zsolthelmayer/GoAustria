namespace GoAustria.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GoAustria.Context.GoAustriaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GoAustria.Context.GoAustriaContext";
        }

        protected override void Seed(GoAustria.Context.GoAustriaContext context)
        {
           
        }
    }
}
