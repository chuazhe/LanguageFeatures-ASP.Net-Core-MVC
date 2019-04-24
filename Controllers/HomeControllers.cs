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
                // ?? mean if null, change to this value
                string name = p?.Name ?? "<No Name>"; // string can set to null so don need ?, product is a object so also nid ?
                decimal? price = p?.Price ?? 0; //decimal cannot set to null so put ?
                string relatedName = p?.Related?.Name ?? "<None>"; // Related is a object, so nid ?

                /*
                results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}",
                name, price, relatedName));*/

                // String Interpolation
                /*String interpolation supports all the format specifiers that are available with the string.Format
                  method. The format specifiers are included as part of the hole, so $"Price: {price:C2}" would format the
                  price value as a currency value with two decimal digits.*/
                results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            }
            return View(results);
        }
    }
}