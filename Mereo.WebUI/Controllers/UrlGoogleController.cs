using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Mereo.Domain.Entity;
using Mereo.Domain.Test;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mereo.WebUI.Controllers
{
    public class UrlGoogleController : Controller
    {
        private readonly ILogger<UrlGoogleController> _logger;

        public UrlGoogleController(ILogger<UrlGoogleController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            var urlGoogleAutomaticTest = new UrlGoogleAutomaticTest();
            UrlGoogle urlGoogle = new UrlGoogle("https://google.com", urlGoogleAutomaticTest.TestarTituloGoogle());
            
            return View(urlGoogle);
        }
    }
}