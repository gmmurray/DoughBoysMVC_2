using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoughBoysMVC.Models;

namespace DoughBoysMVC.Controllers
{
    public class AdminController : Controller
    {
        private ICustomerOrderRepository repository;

        public AdminController(ICustomerOrderRepository repo)
        {
            repository = repo;
        }


        public ViewResult Orders()
        {
            return View(repository.CustomerOrders.Where(x => !x.OrderStatus));
        }

        [HttpPost]
        public IActionResult Update(int id)
        {
            CustomerOrder order = repository.CustomerOrders.FirstOrDefault(x => x.OrderNo == id);
            if(order != null)
            {
                order.OrderStatus = true;
                repository.SaveCustomerOrder(order);
            }
            
            return RedirectToAction(nameof(Orders));
        }
    }
}