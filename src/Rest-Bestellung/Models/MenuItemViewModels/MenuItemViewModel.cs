using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rest_Bestellung.Models;

namespace Rest_BestellungBestellung.Models.MenuItemViewModels
{
    public class MenuItemViewModel
    {
        public Item MenuItem { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<SubCategory> SubCategories { get; set; }

    }
}
