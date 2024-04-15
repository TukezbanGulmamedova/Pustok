using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pustok.Models;

namespace Pustok.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }



  //      protected override void OnModelCreating(ModelBuilder modelBuilder)
  //      {
  //          modelBuilder.Entity<Category>().HasQueryFilter(x => !x.SoftDelete);
  //          base.OnModelCreating(modelBuilder);
  //      }

		//public static implicit operator AppContext(AppDbContext)
		//{
		//	throw new NotImplementedException();
		//}
	}
}
