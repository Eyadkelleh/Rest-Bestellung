using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rest_Bestellung.Data;
using Rest_BestellungBestellung.Models.MenuItemViewModels;

namespace Rest_Bestellung.Controllers
{
    public class MenuItemsController : Controller
    {
        /// <summary>
        /// here you can put the proprieties you are need to use
        /// </summary>
        private readonly ApplicationDbContext applicationDb;
        private readonly IHostingEnvironment iHostingEnvironment;
        [BindProperty]
        public MenuItemViewModel MenuItemsVM { get; set; }
        public MenuItemsController(ApplicationDbContext dbContext, IHostingEnvironment iHosting )
        {
            applicationDb = dbContext;
            iHostingEnvironment = iHosting;
            MenuItemsVM = new MenuItemViewModel()
            {
                Categories = applicationDb.Category.ToList(),
                MenuItem = new Models.Item()
            };
        }
        // Get: Menu-item
        // Here you well be able to 
        public IActionResult Index()
        {
            var menuItems = applicationDb.MenuItems.Include(m => m.Category).Include(m => m.SubCategory);
            return View();
        }
    }
}