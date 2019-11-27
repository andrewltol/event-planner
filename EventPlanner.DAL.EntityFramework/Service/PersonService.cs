using System.Collections.Generic;
using System.Linq;
using EventPlanner.Dal.Model;
using EventPlanner.Dal.Service;

using DbPerson = EventPlanner.Dal.EntityFramework.Model.Person;

namespace EventPlanner.Dal.EntityFramework.Service
{
	public class PersonService : IPersonService
	{
		public void Add(Person person)
		{
			using (var context = new EpEfContext())
			{
				var dbPerson = new DbPerson
				{
					FamilyName = person.FamilyName,
					GivenName = person.GivenName
				};
				context.Persons.Add(dbPerson);
				context.SaveChanges();
			}
		}

		public IReadOnlyCollection<Person> Get()
		{
			using (var context = new EpEfContext())
			{
				return context.Persons.ToArray();
			}
		}

		public Person Get(int id)
		{
			using (var context = new EpEfContext())
			{
				var person = context.Persons.First(p => p.Id == id);
				return person;
			}
		}
	}
}
