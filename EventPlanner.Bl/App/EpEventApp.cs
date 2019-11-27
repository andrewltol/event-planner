using EventPlanner.Dal.Model;
using EventPlanner.Dal.Service;

namespace EventPlanner.Bl.App
{
	public class EpEventApp
	{
		private IEventService _eventService;

		public EpEventApp(IEventService eventService)
		{
			_eventService = eventService;
		}

		public EpEvent Get(int id)
		{
			return _eventService.Get(id);
		}
	}
}
