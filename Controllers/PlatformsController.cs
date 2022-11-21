using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CommandsService.Controllers
{
	[Route("api/c/[controller]")]
	[ApiController]
	public class PlatformsController : ControllerBase
	{
		public PlatformsController()
		{

		}

		[HttpPost]
		public ActionResult TestInboundConnection()
		{
			Debug.WriteLine("Command Service - Inbound post");
			return Ok("test");
		}
	}
}
