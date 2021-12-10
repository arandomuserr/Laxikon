namespace BackendAPIs.Models.RequestsAndResponses
{
    public class ProductDetails
    {
        public int Id { get; set; }

        public decimal WeightInKgs { get; set; }

        public decimal SalePrice { get; set; }

        public decimal RegularPrice { get; set; }

        public string Category { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public string[] ImageURl { get; set; }
    }
}