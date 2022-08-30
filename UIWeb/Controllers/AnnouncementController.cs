using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UIWeb.Controllers
{
    [AllowAnonymous]
    public class AnnouncementController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> List()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            return View();
        }
    }
}
