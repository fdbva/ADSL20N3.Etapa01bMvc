using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace ADSL20N3.Etapa01bMvc.Controllers
{
    public class BatataController : Controller
    {
        private readonly IBatataService _batataService;

        public BatataController(
            IBatataService batataService)
        {
            _batataService = batataService;
        }

        [HttpGet]
        public string Assada(int quantidade)
        {
            return _batataService.OlaComQuantidade(quantidade);
        }

        public IActionResult Frita()
        {
            var quantidade = 4;
            return View(quantidade);
        }
    }
}
