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
        
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Save (Product pro)
        {

            //if(pro.Id == 0 || string.IsNullOrEmpty(pro.Name) || pro.Price == 0)
            if(!ModelState.IsValid)
                ViewBag.Validacao = "produto invalido para cadastro";

            return View();
        }

    }
}