using EventPlanner.Dal.EntityFramework;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace EventPlanner.Api
{
	public class Program
	{
		public static void Main(string[] args)
		{
			AppModule.CreateContainer();

			SetupDatabase();

			CreateWebHostBuilder(args).Build().Run();
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
				WebHost.CreateDefaultBuilder(args)
						.UseStartup<Startup>();

		private static void SetupDatabase()
		{
			using (var context = new EpEfContext())
			{
				context.Database.EnsureCreated();
			}
		}
	}
}
