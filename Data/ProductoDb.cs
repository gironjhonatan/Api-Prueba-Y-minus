using Microsoft.EntityFrameworkCore;
using WebAPIPrueba.Models;


namespace WebAPIPrueba.Data
{
    public class ProductoDb : DbContext
    {

        public ProductoDb(DbContextOptions<ProductoDb> options) : base(options)
        {
        }
        public DbSet<Producto> Productos => Set<Producto>();
    }
}