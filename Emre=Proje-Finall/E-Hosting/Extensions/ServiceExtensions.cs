using Business.Abstract;
using Business.Concerete;
using DcFramworkCore.DbContext;
using Microsoft.EntityFrameworkCore;

namespace E_Hosting.Extensions
{
	public static class ServiceExtensions
	{
		public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) => services.AddDbContext<Context>
			(options => options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

		public static void ConfigureRepositoryManager(this IServiceCollection services) =>
		services.AddScoped<IRepositoryManager, RepositoryManager>();

		public static void ConfigureServiceManager(this IServiceCollection services) =>
			services.AddScoped<IService, ServiceManager>();
	}
}
