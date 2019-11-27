using System.Collections.Generic;
using EventPlanner.Dal.Model;

namespace EventPlanner.Dal.Service
{
	/// <summary>
	/// Service providing access to events.
	/// </summary>
	public interface IEventService
	{
		/// <summary>
		/// Creates a new event.
		/// </summary>
		/// <param name="item">Event data.</param>
		void Add(EpEvent item);

		/// <summary>
		/// Gets a specified event.
		/// </summary>
		/// <param name="id">Id of event to retrieve.</param>
		/// <returns>Event with specified id.</returns>
		EpEvent Get(int id);

		/// <summary>
		/// Retrieves all upcomiong planned events for a person.
		/// </summary>
		/// <param name="personId">Id of person to retrieve events for.</param>
		/// <returns>List of events planned for the person specified.</returns>
		IReadOnlyCollection<EpEvent> GetFutureEvents(int personId);

	}
}
