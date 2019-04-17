using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoughBoysMVC.Models
{
    public class EFCustomerOrderRepository : ICustomerOrderRepository
    {
        private ApplicationDbContext context;
        public EFCustomerOrderRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<CustomerOrder> CustomerOrders => context.CustomerOrders;

        public void SaveCustomerOrder(CustomerOrder customerOrder)
        {
            //context.CustomerOrders.Add(customerOrder);
            //context.SaveChanges();
            if (customerOrder.OrderNo == 0)
            {
                context.CustomerOrders.Add(customerOrder);
            }
            else
            {
                CustomerOrder dbEntry = context.CustomerOrders.FirstOrDefault(c => c.OrderNo == customerOrder.OrderNo);
                if (dbEntry != null)
                {
                    dbEntry.FirstName = customerOrder.FirstName;
                    dbEntry.LastName = customerOrder.LastName;
                    dbEntry.OrderDate = customerOrder.OrderDate;
                    dbEntry.PhoneNo = customerOrder.PhoneNo;
                    dbEntry.PickUpDate = customerOrder.PickUpDate;
                    dbEntry.Quantity = customerOrder.Quantity;
                    dbEntry.DoughnutType = customerOrder.DoughnutType;
                }
            }
            context.SaveChanges();
        }
    }
}
