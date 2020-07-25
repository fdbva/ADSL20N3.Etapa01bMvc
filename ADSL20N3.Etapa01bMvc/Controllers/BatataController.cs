using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ADSL20N3.Etapa01bMvc.Controllers
{
    public class BatataController : Controller
    {
        [HttpGet]
        public string Assada(int quantidade)
        {
            return "Olá da Batata assada x" + quantidade;
        }

        public IActionResult Frita()
        {
            var quantidade = 4;
            return View(quantidade);
        }
    }
}
