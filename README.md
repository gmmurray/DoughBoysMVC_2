# DoughBoysMVC_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoughBoysMVC.Models
{
    public class CustomerOrderRepository
    {
        private static List<CustomerOrder> customerOrders = new List<CustomerOrder>();
        public static IEnumerable<CustomerOrder> CustomerOrders { get; }
        public static void AddCustomer(CustomerOrder customerOrder)
        {
            customerOrders.Add(customerOrder);
        }
    }
}
