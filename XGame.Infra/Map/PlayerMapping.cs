using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using XGame.Domain.Entities;

namespace XGame.Infra.Map
{
    public class PlayerMapping : EntityTypeConfiguration<Player>
    {
        public PlayerMapping()
        {
            ToTable("Player");
            Property(p => p.Email.Address).HasMaxLength(200).IsRequired().HasColumnAnnotation("Index",new IndexAnnotation(new IndexAttribute()));
            Property(p => p.Name.FirstName).HasMaxLength(80).IsRequired().HasColumnName("FirstName");
            Property(p => p.Name.LastName).HasMaxLength(80).IsRequired().HasColumnName("LastName");
            Property(p => p.Password).HasMaxLength(20).IsRequired().HasColumnName("Password");
        }

    }
}
