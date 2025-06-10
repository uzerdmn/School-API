

using Microsoft.AspNetCore.Mvc;


namespace school_api.Src.API.Controllers
{
    public class WelcomeController : Controller
    {

        [HttpGet]
        [Route("[Controller]/SayWelcome")]
        public async Task<IActionResult> SayWelcome()
        {
            return (Ok("Welcome"));
        }
    }
}