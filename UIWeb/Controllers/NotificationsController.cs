﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UIWeb.Controllers
{
    [AllowAnonymous]
    public class NotificationsController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> List()
        {
            return View();
        }
    }
}
