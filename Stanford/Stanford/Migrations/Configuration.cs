namespace Stanford.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Stanford.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Stanford.Context.QuestionContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Stanford.Context.QuestionContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            context.Questions.AddOrUpdate(
                    p => p.Id,

                    new Question {Q = "q1", A = "a1", B = "b1"},
                    new Question {Q = "q2", A = "a2", B = "b2"}


                );
        }
    }
}
