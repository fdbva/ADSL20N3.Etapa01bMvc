using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ADSL20N3.Etapa01bMvc.Models;

namespace ADSL20N3.Etapa01bMvc.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello Index";
        }

        public string HelloWorld()
        {
            var result = "Hello World";
            return result;
        }
    }
}
