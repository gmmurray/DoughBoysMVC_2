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

        
        public decimal TotalCost 
        {
            get
            {
                return Quantity * DoughnutPrice;
            }
        }

        public decimal DoughnutPrice
        {
            get
            {
                if (DoughnutType == "Glazed")
                    return 2.49M;
                else if (DoughnutType == "Chocolate Sprinkle")
                    return 2.99M;
                else if (DoughnutType == "Traditional Cake")
                    return 2.99M;
                else if (DoughnutType == "Strawberry Iced")
                    return 2.99M;
                else if (DoughnutType == "Cinnamon Sugar")
                    return 2.99M;
                else if (DoughnutType == "Powdered Cake")
                    return 3.49M;
                else if (DoughnutType == "Glazed Old Fashioned")
                    return 3.99M;
                else if (DoughnutType == "Glazed Blueberry Cake")
                    return 3.99M;
                else if (DoughnutType == "Birthday Cake Creme Filled")
                    return 4.99M;
                else if (DoughnutType == "Cinnamon Apple Filled")
                    return 4.99M;
                else if (DoughnutType == "Glazed Blueberry Filled")
                    return 4.99M;
                else if (DoughnutType == "Glazed Lemon Filled")
                    return 4.99M;
                else
                    return 0.1M;
            }
        }
        public string DoughnutType { get; set; }
        public int Quantity { get; set; }
    }
}
