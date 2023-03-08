using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1, 10000)]
        public double ListPrice { get; set;  }
        
        [Required]
        [Range(1,10000)]
        public double Price { get; set; }
        
        [Required]
        [Range(1, 10000)]
        public double Price50 { get; set; }
        
        [Required]
        [Range(1, 10000)]
        public double Price100 { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        //required for foreign key relation with Category
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        [Required]
        //required for foreign key relation with CoverType
        public int CoverTypeID { get; set; }
        public CoverType CoverType { get; set; }
    }
}
