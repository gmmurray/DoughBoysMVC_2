using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoughBoysMVC.Models;

namespace DoughBoysMVC.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerOrderRepository repository;
        public HomeController(ICustomerOrderRepository repoService)
        {
            repository = repoService;
        }
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Menu()
        {
            return View();
        }

        [HttpGet]
        public ViewResult PreOrder()
        {
            return View();
        }

        [HttpPost]
        public ViewResult PreOrder(CustomerOrder customer)
        {
             if (ModelState.IsValid)
             {
                Random random = new Random();
                CustomerOrderRepository.AddCustomer(customer);
                customer.OrderNo = random.Next();
                repository.SaveCustomerOrder(customer);
                return View("Confirmation", customer);
             }
            
            else {
                return View();
            }
        }

        public ViewResult Questions()
        {
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult Confirmation()
        {
            return View();
        }
    }
}
