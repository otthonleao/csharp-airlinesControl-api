using AirlinesControl.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirlinesControl.EntityConfigurations;

    public class AircraftConfiguration : IEntityTypeConfiguration<Aircraft>
{
    public void Configure(EntityTypeBuilder<Aircraft> builder)
    {
        builder.ToTable("TB_AIRCAFT");
        builder.HasKey(a => a.Id);
        
        builder.Property(a => a.Fabricante).IsRequired().HasMaxLength(50);
        builder.Property(a => a.Modelo).IsRequired().HasMaxLength(50);
        builder.Property(a => a.Codigo).IsRequired().HasMaxLength(10);
        // Relacionamento entre as tabelas
        builder.HasMany(a => a.Maintenances).WithOne(m => m.Aircraft).HasForeignKey(m => m.AircraftId);
    }


}
