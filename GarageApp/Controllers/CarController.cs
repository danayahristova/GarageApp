using GarageApp.Data;
using GarageApp.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GarageApp.Controllers
{
    public class CarController : Controller
    {
        private readonly GarageDbContext dbContext;
        public CarController(GarageDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var cars = dbContext.Cars.Include(c => c.Garage).ToList();
            
            return View(cars);
        }

        public IActionResult Details(int id)
        {
            Car? car = dbContext.Cars
                .Include(c => c.Garage)
                .FirstOrDefault(c => c.Id == id);

            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }
        public IActionResult Search(string make)
        {
            make = (make ?? string.Empty).Trim();

            var query = dbContext.Cars.Include(c => c.Garage).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(make))
            {
                query = query.Where(c => c.Make.Contains(make));
            }

            var cars = query
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .ToList();

            // Option 1 (simplest): reuse the Index view
            return View("Index", cars);

            // Option 2 (if you want a separate view):
            // return View(cars);
        }
    }
}
