using Customers.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Customers.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerDbContext _context;

        public CustomerController(CustomerDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var customers = _context.Customers.Include(a => a.Address).ToList();
            return View(customers);
        }
    }
}
