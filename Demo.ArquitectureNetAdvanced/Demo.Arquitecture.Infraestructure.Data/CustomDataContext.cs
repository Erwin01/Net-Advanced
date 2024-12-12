using Demo.Arquitecture.Aplication.DTO;
using Demo.Arquitecture.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Demo.Arquitecture.Infraestructure.Data
{
    public class CustomDataContext : DbContext
    {
        public CustomDataContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shooping> Shoopings { get; set; }
        public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual DbSet<PetDTO> Pets { get; set; }
    }
}
