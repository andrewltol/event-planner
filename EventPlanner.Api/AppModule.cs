using EventPlanner.Bl.App;
using EventPlanner.Dal.EntityFramework.Service;
using EventPlanner.Dal.Service;
using SimpleInjector;

namespace EventPlanner.Api
{
	public static class AppModule
	{
		public static Container Container { get; private set; }

		public static void CreateContainer()
		{
			Container = new Container();

			// Register the services
			Container.Register<IEventService, EventService>();

			// Register BL classes
			Container.Register<EpEventApp>();

			Container.Verify();
		} 
	}
}
