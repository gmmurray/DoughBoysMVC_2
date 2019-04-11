using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DoughBoysMVC.Models
{
    public class CustomerOrder
    {
        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        public string PhoneNoID { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [RegularExpression(".+\\@.+\\..+", 
        ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        
        public int OrderNo { get; set; }

        [Required(ErrorMessage = "Please select a pick-up date.")]
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

                return (int)Quantity * DoughnutPrice;
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

        [Required(ErrorMessage = "Please select a doughnut to pre-order.")]
        public string DoughnutType { get; set; }

        [Required(ErrorMessage = "Please enter the quantity of doughnuts.")]
        [Range(1,100, ErrorMessage = "Please enter a valid quantity of doughnuts (1-100)")]
        public int? Quantity { get; set; }
    }
}
