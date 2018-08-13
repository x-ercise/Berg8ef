using System.Data.Entity;
using Berg8.Model.DTO;
using Berg8.EF.Configuration;

namespace Berg8.EF
{
    public class WorkflowContext : DbContext
    {
        public DbSet<Workflow> Workflow { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<CommandItem> CommandItem { get; set; }

        private WorkflowContext(string connectionString) : base(connectionString)
        {
            //Database.SetInitializer<WorkflowContext>(null);
            Database.SetInitializer<WorkflowContext>(new DropCreateDatabaseAlways<WorkflowContext>());
        }
        public static WorkflowContext CreateInstance(string connectionString)
        {
            WorkflowContext instance = new WorkflowContext(connectionString);
            return instance;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            string schema = "dbo";
            modelBuilder.HasDefaultSchema(schema);
            modelBuilder.Configurations.Add(WorkflowConfigulartion.CreateInstance(schema));
            modelBuilder.Configurations.Add(ActivityConfiguration.CreateInstance(schema));
            modelBuilder.Configurations.Add(StateConfiguration.CreateInstance(schema));
            modelBuilder.Configurations.Add(CommandItemConfiguration.CreateInstance(schema));
        }
    }
}
