using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Timer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		[HttpGet]

		public void Send()
		{
            Console.WriteLine("Hello");
        }
	}
}
