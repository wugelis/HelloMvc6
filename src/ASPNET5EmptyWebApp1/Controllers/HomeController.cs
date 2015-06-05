using ASPNET5EmptyWebApp1.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET5EmptyWebApp1.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View(new Customer() { Id = 1, CustomerName = "Gelis", Email = "gelis.wu@mentortrust.com", Password = "" });
            //return View(new List<Customer>(new Customer[] {
            //    new Customer() { Id = 1, CustomerName = "Gelis", Email = "gelis.wu@mentortrust.com", Password = ""}
            //}));
        }
    }
}
