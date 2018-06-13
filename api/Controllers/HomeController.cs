using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    public class HomeController : Controller
    {
        [Route("/version")]
        [HttpGet]
        public string GetVersion() => "1.0.0v";
    }
}