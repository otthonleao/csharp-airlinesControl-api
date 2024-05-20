using AirlinesControl.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirlinesControl.EntityConfigurations;

    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
{
    public void Configure(EntityTypeBuilder<Flight> builder)
    {
        builder.ToTable("TB_FLIGHTS");
        builder.HasKey(v => v.Id);
        
        builder.Property(v => v.Origem).IsRequired().HasMaxLength(3);
        builder.Property(v => v.Destino).IsRequired().HasMaxLength(3);
        builder.Property(v => v.DataHoraPartida).IsRequired();
        builder.Property(v => v.DataHoraChegada).IsRequired();
        // Relacionamento entre as tabelas
        builder.HasOne(v => v.Pilot).WithMany(p => p.Voos).HasForeignKey(v => v.PilotId);
        builder.HasOne(v => v.Aircraft).WithMany(a => a.Voos).HasForeignKey(v => v.AircraftId);
        builder.HasOne(v => v.Cancellation).WithOne(c => c.Voo).HasForeignKey<Cancellation>(c => c.VooId);
    }
}
