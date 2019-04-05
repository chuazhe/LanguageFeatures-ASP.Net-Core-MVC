using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> results = new List<string>();
            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name; // string can set to null so need ?
                decimal? price = p?.Price; //decimal cannot set to null so put ?
                string relatedName = p?.Related?.Name;

                results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}",
                name, price, relatedName));
            }
            return View(results);
        }
    }
}