using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoughBoysMVC.Models
{
    public interface ICustomerOrderRepository
    {
        IEnumerable<CustomerOrder> CustomerOrders { get; }
    }
}
