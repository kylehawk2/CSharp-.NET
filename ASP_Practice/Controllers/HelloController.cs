using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ASP_Practice.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}