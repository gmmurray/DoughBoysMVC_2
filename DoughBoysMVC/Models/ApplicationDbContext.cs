using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace DoughBoysMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerOrder>().HasData(
                new CustomerOrder
                {
                    OrderNo = 200,
                    FirstName = "Greg",
                    LastName = "M",
                    PhoneNo = "1234567890",
                    Email = "email@email.com",
                    DoughnutType = "Glazed",
                    Quantity = 17,
                    PickUpDate = "4/19/2019",
                    OrderDate = "4/16/2019",
                    OrderStatus = false
                }
            );

            modelBuilder.Entity<CustomerOrder>().HasData(
                new CustomerOrder
                {
                    OrderNo = 201,
                    FirstName = "John",
                    LastName = "Doe",
                    PhoneNo = "1234567890",
                    Email = "email@email.com",
                    DoughnutType = "Cinnamon Sugar",
                    Quantity = 29,
                    PickUpDate = "4/19/2019",
                    OrderDate = "4/16/2019",
                    OrderStatus = false
                }
            );

            modelBuilder.Entity<CustomerOrder>().HasData(
                new CustomerOrder
                {
                    OrderNo = 202,
                    FirstName = "Jane",
                    LastName = "Doe",
                    PhoneNo = "1234567890",
                    Email = "email@email.com",
                    DoughnutType = "Glazed",
                    Quantity = 75,
                    PickUpDate = "4/19/2019",
                    OrderDate = "4/16/2019",
                    OrderStatus = false
                }
            );

            modelBuilder.Entity<CustomerOrder>().HasData(
                new CustomerOrder
                {
                    OrderNo = 203,
                    FirstName = "James",
                    LastName = "Jameson",
                    PhoneNo = "1234567890",
                    Email = "email@email.com",
                    DoughnutType = "Glazed",
                    Quantity = 99,
                    PickUpDate = "4/19/2019",
                    OrderDate = "4/16/2019",
                    OrderStatus = false
                }
            );
        }
    }
}
