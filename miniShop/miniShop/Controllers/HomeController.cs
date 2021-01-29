using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using miniShop.Models;
using miniShop.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductService service;

        public HomeController(ILogger<HomeController> logger, IProductService service)
        {
            _logger = logger;
            this.service = service;
        }

        public IActionResult Index(int page = 1)
        {
            var pageSize = 4;
            var products = service.GetProducts();

            var pagingProducts = products.OrderBy(p => p.Id)
                                         .Skip((page-1) * pageSize)
                                         .Take(pageSize);

            var totalProduct = products.Count;
            
            var totalPage = Math.Ceiling((decimal)totalProduct / pageSize);
            ViewBag.TotalPages = totalPage;

            return View(pagingProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
