using Front.Interfaces;
using Front.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Front.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServices _servicios;

        public HomeController(ILogger<HomeController> logger, IServices services)
        {
            _servicios = services;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var corresponsales = await _servicios.GetCorresponsales();
            corresponsales = corresponsales.OrderBy(a => a.COR_NOMBRE).ToList();
            return View(corresponsales);
        }

        public async Task<IActionResult> GetOficinas(string id)
        {
            var oficinas = await _servicios.GetOficinas(id);
            return PartialView("_SelectOficinas", oficinas);
        }

        public async Task<IActionResult> GetPartialTable(string oficina)
        {
            
            var oficinaList = oficina.ToCharArray();
            var letrasleidas = new List<(string, int)>();
            foreach (var item in oficinaList.ToList())
            {
                var inspeccion = item.ToString();
                if (!String.IsNullOrEmpty(inspeccion) && !String.IsNullOrWhiteSpace(inspeccion))
                {
                    var count = oficinaList.Where(a => a == item).Count();
                    if (!letrasleidas.Select(a => a.Item1).Contains(item.ToString().ToUpper()))
                        letrasleidas.Add((item.ToString().ToUpper(), count));
                }
            }

            List<TablaModel> model = new List<TablaModel>();
            foreach (var item in letrasleidas)
            {
                model.Add(new TablaModel(item.Item1, item.Item2));
            }

            return PartialView("_tablaOficinas", model);
        }
    }
}
