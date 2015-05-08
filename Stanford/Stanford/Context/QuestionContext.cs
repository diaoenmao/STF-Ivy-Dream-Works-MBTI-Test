using Stanford.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Stanford.Context
{
    public class QuestionContext : DbContext
    {

        public QuestionContext() : base("QuestionContext")
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<ChrTrait> Traits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}