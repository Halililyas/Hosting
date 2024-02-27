using DcFramworkCore.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace E_Hosting.ContextFactory
{
	public class RepositoryContextFactory : IDesignTimeDbContextFactory<Context>
	{
		public Context CreateDbContext(string[] args)
		{
			//configureBuilder
			var configurebuilder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();
			//DBcontextOptiosnBuilder

			var builder = new DbContextOptionsBuilder<Context>()
				.UseSqlServer(configurebuilder.GetConnectionString("sqlConnection"), prj => prj.MigrationsAssembly("E-Hosting"));
			return new Context(builder.Options);
		}
	}
}
