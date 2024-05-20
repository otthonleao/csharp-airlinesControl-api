using AirlinesControl.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirlinesControl.EntityConfigurations;

    public class MaintenanceConfiguration : IEntityTypeConfiguration<Maintenance>
{
    public void Configure(EntityTypeBuilder<Maintenance> builder)
    {
        builder.ToTable("TB_MAINTENANCE");
        builder.HasKey(m => m.Id);
        
        builder.Property(m => m.DataHora).IsRequired();
        builder.Property(m => m.Tipo).IsRequired();
        builder.Property(m => m.Observacoes).HasMaxLength(100);
    }
}
