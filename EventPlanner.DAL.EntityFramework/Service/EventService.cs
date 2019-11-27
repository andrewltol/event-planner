using System;
using System.Collections.Generic;
using System.Linq;
using EventPlanner.Dal.Model;
using EventPlanner.Dal.Service;

using DbEvent = EventPlanner.Dal.EntityFramework.Model.Event;

namespace EventPlanner.Dal.EntityFramework.Service
{
	public class EventService : IEventService
	{
		public void Add(EpEvent item)
		{
			using (var context = new EpEfContext())
			{
				var dbEvent = new DbEvent
				{
					Date = item.Date,
					Name = item.Name
				};
				context.Events.Add(dbEvent);
				context.SaveChanges();
			}
		}

		public EpEvent Get(int id)
		{
			using (var context = new EpEfContext())
			{
				return context.Events.First(e => e.Id == id);
			}
		}

		public IReadOnlyCollection<EpEvent> GetFutureEvents(int personId)
		{
			using (var context = new EpEfContext())
			{
				var utcNow = DateTime.UtcNow;
				return context.Events.Where(e => e.Date > utcNow).ToList();
			}
		}
	}
}
