using System.Collections.Generic;
using EventPlanner.Bl.App;
using EventPlanner.Dal.Model;
using Microsoft.AspNetCore.Mvc;

namespace EventPlanner.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EventController : ControllerBase
	{
		// GET: api/Event
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "event1", "event2" };
		}

		// GET: api/Event/5
		[HttpGet("{id}", Name = "Get")]
		public ActionResult<EpEvent> Get(int id)
		{
			var eventApp = AppModule.Container.GetInstance<EpEventApp>();
			return eventApp.Get(id);
		}

		// POST: api/Event
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT: api/Event/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE: api/ApiWithActions/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}