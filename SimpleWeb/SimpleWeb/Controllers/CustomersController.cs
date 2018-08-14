using SimpleWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleWeb.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customerService = new CustomerService();
            var customers = customerService.GetCustomers();

            ViewData.Model = customers;

            return View();
        }

        public ActionResult Details(int id)
        {
            var customerService = new CustomerService();
            var filteredCustomer = customerService.GetCustomers()
                .Where(customer => customer.Id.Equals(id)).FirstOrDefault();

            ViewData.Model = filteredCustomer;

            return View();
        }
    }
}