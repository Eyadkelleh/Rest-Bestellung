using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Rest_Bestellung.Models
{
    public class Item
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public string Image { get; set; }
        public string Spicyness { get; set; }
        public enum EScipy
        {
            NA=0,
            Spicy =1,
            VerySpicy = 2
        }
        [Range(1,Int32.MaxValue,ErrorMessage = "Price should be greater that (1)$")]
        public double Price { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ForeignKey("Category")]
        public virtual Category Category { get; set; }


        [Display(Name = "SubCategory")]
        public int SubCategoryId { get; set; }
        [ForeignKey("SubCategory")]
        public virtual SubCategory SubCategory { get; set; }

    }
}
