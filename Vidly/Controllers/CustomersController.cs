using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }
        
        public ViewResult Details(int Id)
        {
            var customer = GetCustomerById(Id);
            return View(customer);            
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Jim James", Info = "This is information about Jim James, a valued customer" },
                new Customer { Id = 2, Name = "Will Oldham", Info = "This is information about Will Oldham, a very old customer of ours" }
            };
        }

        private Customer GetCustomerById(int IdToFind)
        {
            foreach(Customer customer in GetCustomers())
            {
                if(customer.Id == IdToFind)
                {
                    return customer;
                }
            }
            return null;
        }




    }
}