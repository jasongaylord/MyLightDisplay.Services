using System.Data.Entity;

namespace MyLightDisplay.Services
{
    public partial class Lights : DbContext
    {
        public Lights()
            : base("name=Lights")
        {
        }

        public virtual DbSet<MusicLog> MusicLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
