using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Data;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var product = new Product { Name = "Iphone X", Price = 6000, Description = "İyi Telefon" };

            ViewBag.Category = "Telefonlar";

            return View(product);//model
        }
        public IActionResult list()
        {
           

            
        var productsViewModel = new ProductViewModel//her ikisinide kullanmak için progda viewmodels klasörü açtım içine category ve list ekledim
        {
            Products = ProductRepository.Products
        };

            return View(productsViewModel);//burdanda viewe gönderdim ve şimdi productsviewmodeli @model ..... olarak başa yazacağım
        }
        public IActionResult Details(int id)
        {

            var p = new Product();
            p.Name = "Samsung";
            p.Price = 3000;
            p.Description = "İyi telefon";
        
            return View(p);
        }


    }
}