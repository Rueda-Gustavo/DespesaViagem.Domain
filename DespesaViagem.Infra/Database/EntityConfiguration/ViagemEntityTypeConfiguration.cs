using DespesaViagem.Infra.Models.Viagem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DespesaViagem.Infra.Database.EntityConfiguration
{
    public class ViagemEntityTypeConfiguration : IEntityTypeConfiguration<Viagem>
    {
        public void Configure(EntityTypeBuilder<Viagem> builder)
        {

        }
    }
}
