using System;
using System.Collections.Generic;

namespace EventPlanner.Dal.Model
{
	public class EpEvent
	{
		/// <summary>
		/// Database identifier for this object.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Name of the event.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Date event will occur.
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// People who are invited to this event.
		/// </summary>
		public ICollection<Person> Attendees { get; set; }
	}
}
