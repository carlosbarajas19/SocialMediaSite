using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaSite.Controllers
{
    public class PageController : Controller
    {
        public IActionResult UserPage()
        {
            return View();
        }
    }
}
