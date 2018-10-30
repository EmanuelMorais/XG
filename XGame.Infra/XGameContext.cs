using System;
using System.Data.Entity;
using XGame.Domain.Entities;

namespace XGame.Infra
{
    public class XGameContext : DbContext
    {

        public XGameContext():base("connectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            
        }

        public IDbSet<Player> Player { get; set; }

        public IDbSet<Platform> Platform { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Configure(x => x.HasMaxLength(100));
            modelBuilder.Configurations.AddFromAssembly(typeof(XGameContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
