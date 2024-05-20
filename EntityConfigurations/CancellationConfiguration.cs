using AirlinesControl.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirlinesControl.EntityConfigurations;

    public class CancellationConfiguration : IEntityTypeConfiguration<Cancellation>
{
    public void Configure(EntityTypeBuilder<Cancellation> builder)
    {
        builder.ToTable("TB_CANCELLATION");
        builder.HasKey(c => c.Id);
        
        builder.Property(c => c.Motivo).IsRequired().HasMaxLength(100);
        // Relacionamento entre as tabelas
        builder.Property(c => c.DataHoraNotificacao).IsRequired();
    }
}
