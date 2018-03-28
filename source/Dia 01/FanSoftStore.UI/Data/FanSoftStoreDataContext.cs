using FanSoftStore.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace FanSoftStore.UI.Data
{
    public class FanSoftStoreDataContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NewFanSoftStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
