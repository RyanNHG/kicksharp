using Microsoft.AspNetCore.Mvc;

namespace KickSharp.Routes.Home
{
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            var model = new Model()
            {
                Title = "Oh boy.",
                Subtitle = "I did it!"
            };

            return View(model);
        }
    }
}