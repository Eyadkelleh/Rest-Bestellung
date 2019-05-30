using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rest_Bestellung.Data;
using Rest_Bestellung.Models;
using Rest_Bestellung.Models.SubCategoryViewModels;

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
        // SubCategory Create Action

        public IActionResult Create()
        {
            // the subcategories and category field model and we'll have to pass that model to the view.
            SubCategoryAndCategoryViewModel modeSubCategoriesController = new SubCategoryAndCategoryViewModel()
            {
                CategoryList = _db.Category.ToList(),
                SubCategory = new SubCategory(),
                SubCategoryList = _db.SubCategory.OrderBy(p => p.Name).Select(p => p.Name).ToList()

            };
            return View(modeSubCategoriesController);
        }

    }
}