namespace ComissaoVenda.Models
{
    using System.Data.Entity;

    public partial class ComissaoVendaContext : DbContext
    {
        public ComissaoVendaContext()
            : base("name=ComissaoVendaContext")
        {
        }

        public virtual DbSet<VEI001_MARCA> VEI001_MARCA { get; set; }
        public virtual DbSet<VEI002_MODELO> VEI002_MODELO { get; set; }
        public virtual DbSet<VEI003_COMBUSTIVEL> VEI003_COMBUSTIVEL { get; set; }
        public virtual DbSet<VEI004_MODELO_VERSAO> VEI004_MODELO_VERSAO { get; set; }
        public virtual DbSet<VND001_VENDEDOR> VND001_VENDEDOR { get; set; }
        public virtual DbSet<VND002_VENDA> VND002_VENDA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VEI001_MARCA>()
                .Property(e => e.NmeMarca)
                .IsUnicode(false);

            modelBuilder.Entity<VEI001_MARCA>()
                .HasMany(e => e.VEI002_MODELO)
                .WithRequired(e => e.VEI001_MARCA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VEI002_MODELO>()
                .Property(e => e.CodModelo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VEI002_MODELO>()
                .Property(e => e.NmeModelo)
                .IsUnicode(false);

            modelBuilder.Entity<VEI002_MODELO>()
                .HasMany(e => e.VEI004_MODELO_VERSAO)
                .WithRequired(e => e.VEI002_MODELO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VEI003_COMBUSTIVEL>()
                .Property(e => e.NmeCombustivel)
                .IsUnicode(false);

            modelBuilder.Entity<VEI003_COMBUSTIVEL>()
                .HasMany(e => e.VEI004_MODELO_VERSAO)
                .WithRequired(e => e.VEI003_COMBUSTIVEL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VEI004_MODELO_VERSAO>()
                .Property(e => e.VlrPrecoTabelado)
                .HasPrecision(10, 2);

            modelBuilder.Entity<VEI004_MODELO_VERSAO>()
                .HasMany(e => e.VND002_VENDA)
                .WithRequired(e => e.VEI004_MODELO_VERSAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VND001_VENDEDOR>()
                .Property(e => e.NmeVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<VND001_VENDEDOR>()
                .HasMany(e => e.VND002_VENDA)
                .WithRequired(e => e.VND001_VENDEDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VND002_VENDA>()
                .Property(e => e.VlrPrecoVenda)
                .HasPrecision(10, 2);
        }

        public System.Data.Entity.DbSet<ComissaoVenda.Models.RELATORIO> RELATORIOs { get; set; }
    }
}
