using Controle_Patrimonial.Domain;
using Microsoft.EntityFrameworkCore;


namespace Infra.SqlServer
{
    public class SqlServerContex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ControlePatrimonial");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Patrimonios)
                .WithOne(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.CheckIns)
                .WithOne(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder.Entity<Bloco>()
                .HasMany(e => e.Patrimonios)
                .WithOne(e => e.Bloco)
                .HasForeignKey(e => e.BlocoId)
                .IsRequired();

            modelBuilder.Entity<Patrimonio>()
                .HasMany(e => e.CheckIns)
                .WithMany(e => e.Patrimonios)
                .UsingEntity<CheckInPatrimonio>();
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Patrimonio> Patrimonios { get; set;}
        public DbSet<CheckIn> CheckIns { get; set; }
        public DbSet<CheckInPatrimonio> CheckInPatrimonios { get; set; }
        public DbSet<Bloco> Blocos { get; set; }

    }
}
