using Microsoft.AspNetCore.Mvc;

namespace SISOCWEBAPI.Controllers
{
	public class HomeController : ControllerBase
	{
		public HomeController()
		{
		}

		[HttpGet("GetWeatherForecast")]
		public string Get()
		{
			return "dsd";
		}
	}
}
