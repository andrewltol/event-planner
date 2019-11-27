namespace EventPlanner.Dal.Model
{
	/// <summary>
	/// Represents an individual.
	/// </summary>
	public class Person
	{
		/// <summary>
		/// Unique identifier for the person object.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Given name of the individual.
		/// </summary>
		public string GivenName { get; set; }

		/// <summary>
		/// Family name of the individual.
		/// </summary>
		public string FamilyName { get; set; }
	}
}
