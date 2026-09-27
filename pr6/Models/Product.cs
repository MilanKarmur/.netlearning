//using System.ComponentModel.DataAnnotations;

//namespace pr6.Models
//{
//    public class Product
//    {
//    }
//}


using System.ComponentModel.DataAnnotations;

namespace pr6.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(0.01, 100000)]
        public decimal Price { get; set; }

        public string Category { get; set; }

        public int Stock { get; set; }
    }
}
