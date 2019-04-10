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
    }
}
