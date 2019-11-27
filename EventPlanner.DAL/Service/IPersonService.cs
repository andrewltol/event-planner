using System.Collections.Generic;
using EventPlanner.Dal.Model;

namespace EventPlanner.Dal.Service
{
	public interface IPersonService
	{
		/// <summary>
		/// Creates a new person.
		/// </summary>
		/// <param name="person">Person object to save.</param>
		void Add(Person person);

		/// <summary>
		/// Gets all people.
		/// </summary>
		/// <returns>List of all people.</returns>
		IReadOnlyCollection<Person> Get();

		/// <summary>
		/// Gets a specified person.
		/// </summary>
		/// <param name="id">Id of the person to get.</param>
		/// <returns>Person found.</returns>
		Person Get(int id);
	}
}
