using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoughBoysMVC.Models
{
    public class CustomerOrder
    {
        public string PhoneNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int OrderNo { get; set; }
        public string PickUpDate { get; set; }

        private string orderDate;
        public string OrderDate
        {
            get
            {

                return DateTime.Today.ToString("d");
            }
            set
            {
                orderDate = value;
            }
        }
        public double TotalCost //{ get; set; } 
        {
            get
            {
                return Quantity * DoughnutPrice;
            }
        }

        public double DoughnutPrice
        {
            get
            {
                if (DoughnutType == "glazed")
                    return 2.99;
                else
                    return 0.1;
            }
        }
        public string DoughnutType { get; set; }
        public int Quantity { get; set; }
    }
}
