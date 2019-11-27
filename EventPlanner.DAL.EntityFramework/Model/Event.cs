using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EventPlanner.Dal.Model;

namespace EventPlanner.Dal.EntityFramework.Model
{
	public class Event : EpEvent
	{
		/// <summary>
		/// Name of the event.
		/// </summary>
		[Required, StringLength(100)]
		public new string Name { get; set; }

		/// <summary>
		/// Date event will occur.
		/// </summary>
		[Required]
		public new DateTime Date { get; set; }

		/// <summary>
		/// People who are invited to this event.
		/// </summary>
		[Required]
		public new ICollection<Person> Attendees { get; set; }
	}
}
