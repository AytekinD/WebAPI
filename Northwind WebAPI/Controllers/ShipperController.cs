using Microsoft.AspNetCore.Mvc;
using Northwind_WebAPI.Entities;

namespace Northwind_WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ShipperController : ControllerBase
	{
		private readonly NorthwindContext context;

		public ShipperController(NorthwindContext context)
		{
			this.context = context;
		}
		[HttpGet]
		public IActionResult Get()
		{
			var result = context.Shippers.ToList();
			if (result.Any())
			{
				return Ok(result);
			}
			else
			{
				return NotFound();
			}
		}
	}
}
