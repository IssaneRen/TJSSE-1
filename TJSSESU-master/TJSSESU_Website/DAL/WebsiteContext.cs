using System.Data.Entity;
using TJSSESU_Website.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TJSSESU_Website.DAL
{
    public class WebsiteContext : DbContext
    {
        public WebsiteContext() : base("WebsiteContext") { }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Answer> answers { get; set; }
        public DbSet<Application> applications { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<ExecuteTask>executeTasks { get; set; }
        public DbSet<File> files { get; set; }
        public DbSet<News> news { get; set; }
        public DbSet<Position> positions { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<Task> tasks { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Detail> details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.HasDefaultSchema("TEST");
            modelBuilder.Entity<Answer>().HasKey(t => new { t.adminID, t.questionID });
            modelBuilder.Entity<ExecuteTask>().HasKey(t => new { t.taskID, t.SID });
        }
        
    }
}