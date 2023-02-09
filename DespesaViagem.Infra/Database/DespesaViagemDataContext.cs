using DespesaViagem.Infra.Database.EntityConfiguration;
using DespesaViagem.Infra.Models.Viagem;
using Microsoft.EntityFrameworkCore;

namespace DespesaViagem.Infra.Database
{
    public class DespesaViagemDataContext : DbContext
    {
        public DbSet<Viagem> Viagems { get; set; }

        public DespesaViagemDataContext(DbContextOptions<DespesaViagemDataContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ViagemEntityTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.
        }
    }
}
