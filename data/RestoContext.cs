using Microsoft.EntityFrameworkCore;
//https://github.com/dotnet/EntityFramework.Docs/blob/master/samples/core/Cosmos/ModelBuilding/OrderContext.cs
namespace data
{
    public class RestoContext : DbContext
    {
        public DbSet<RestoEntity> Restos {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseCosmos(
                    "https://.documents.azure.com:443/",
                    "",
                    databaseName: "");

                 protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultContainer("Store");

            modelBuilder.Entity<RestoEntity>()
                .ToContainer("Restos");

            modelBuilder.Entity<RestoEntity>()
                .HasNoDiscriminator();

            modelBuilder.Entity<RestoEntity>()
                .HasPartitionKey(o => o.PartitionKey);
        }   
    }
}