﻿using System;
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
                CustomerOrderRepository.AddCustomer(customer);
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
