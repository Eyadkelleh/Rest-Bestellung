using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rest_Bestellung.Data;

namespace Rest_Bestellung.Controllers
{
    public class SubCategoriesController : Controller
    {
        // Adding connection to database:
        private readonly ApplicationDbContext _db;
        // Contractual to use dependency injection
        // So with this we've done with the dependency injection to inject the application D-B context inside our
        public SubCategoriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Get Action
        public async Task<IActionResult> Index()
        {
            //So what this will do is when it is loading all the subcategories from the database it will also fill
            // the corresponding category details inside the category vailable.
            var subCategory = _db.SubCategory.Include(s => s.Category);
            return View(await subCategory.ToListAsync());
        }
    }
}