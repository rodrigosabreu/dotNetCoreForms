using Microsoft.AspNetCore.Mvc;
using dotNetCoreForms.Models;

namespace dotNetCoreForms.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Save (Product pro)
        {
            return View();
        }

    }
}