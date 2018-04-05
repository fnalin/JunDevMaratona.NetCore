using FanSoftStore.UI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FanSoftStore.UI.Data
{
    public class FanSoftStoreDataContext : DbContext
    {
        private readonly IConfiguration _config;

        public FanSoftStoreDataContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("FanSoftStoreConn"));
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoProduto> TipoProdutos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
