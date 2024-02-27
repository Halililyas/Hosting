using Entity.Concreate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DcFramworkCore.DbContext
{
	public class Context:IdentityDbContext<User>
	{

        public Context(DbContextOptions options):base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Product>().
				HasOne(C => C.Category)
				.WithMany(p => p.Products)
				.HasForeignKey(c => c.CategoryId)
				.OnDelete(DeleteBehavior.Restrict)
				.IsRequired();

		}


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
