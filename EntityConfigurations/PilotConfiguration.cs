using AirlinesControl.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirlinesControl.EntityConfigurations;

    public class PilotConfiguration : IEntityTypeConfiguration<Pilot>
{
    public void Configure(EntityTypeBuilder<Pilot> builder)
    {
        builder.ToTable("TB_PILOTS");
        builder.HasKey(p => p.Id);
        
        builder.Property(p => p.Nome).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Matricula).IsRequired().HasMaxLength(10);

        // Relacionamento entre as tabelas
        builder.HasIndex(p => p.Matricula).IsUnique();
    }
}
