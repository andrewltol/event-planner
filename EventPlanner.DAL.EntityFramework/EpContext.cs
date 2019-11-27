using Microsoft.EntityFrameworkCore;
using EventPlanner.Dal.EntityFramework.Model;

namespace EventPlanner.Dal.EntityFramework
{
	/// <summary>
	/// Entity Framework context to provide access to the database.
	/// </summary>
	public class EpEfContext : DbContext
	{
		public DbSet<Event> Events { get; set; }
		public DbSet<Person> Persons { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
			optionsBuilder.UseSqlServer(@"Server=eventplanner-dev-free.cya2wh1pgofq.us-east-2.rds.amazonaws.com;Database=EP-Dev;User Id=administrator;Password=administrator");
			//optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=StoreDB;");
		}
	}
}
