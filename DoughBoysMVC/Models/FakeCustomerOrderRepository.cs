using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoughBoysMVC.Models
{
    public class FakeCustomerOrderRepository : ICustomerOrderRepository
    {
        public IEnumerable<CustomerOrder> CustomerOrders => new List<CustomerOrder>
        {
            new CustomerOrder {FirstName = "Greg", LastName = "Murray", Email = "greg@mail.com", OrderDate = "01/01/1111", DoughnutType = "Glazed", OrderNo = 1, PhoneNo = "1234", PickUpDate = "02/02/2222", Quantity = 3}
        };
    }
}
