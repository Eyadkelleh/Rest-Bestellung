using System.ComponentModel.DataAnnotations;

namespace Rest_Bestellung.Models
{
    public class Category
    {
        [Required]
        public int Id { get; set; }
        [Required]
        // Adding the display attribute like this it will not display (Name) inside the View
        // but it will display as Name, so whatever you want to change what you want to
        // display inside view you can do that using the display
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        [Required]
        // Adding the display attribute like this it will not display (DisplayOder) inside the View
        // but it will display as display space order, so whatever you want to change what you want to
        // display inside view you can do that using the display
        [Display(Name = "Display Order")]
        public int DisplayOder { get; set; }
    }
}