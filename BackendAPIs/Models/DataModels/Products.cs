using System.ComponentModel.DataAnnotations;

namespace BackendAPIs.DataModels
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        public decimal Weight { get; set; }

        public decimal SalePrice { get; set; }

        public decimal RegularPrice { get; set; }

        public string Category { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public string ImageURl { get; set; }
    }
}