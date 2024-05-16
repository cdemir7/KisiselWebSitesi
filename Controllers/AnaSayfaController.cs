using Microsoft.AspNetCore.Mvc;

namespace KisiselWebSitesi.Controllers
{
	public class AnaSayfaController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
