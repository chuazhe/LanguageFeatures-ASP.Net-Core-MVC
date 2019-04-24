namespace LanguageFeatures.Models
{
    public class Product
    {
        //Automatically Implemented Properties
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }

        public bool InStock { get; } = true; // read only

        public static Product[] GetProducts()
        {
            //object initializer
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M
            };
            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 48.95M
            };
            kayak.Related = lifejacket;
            return new Product[] { kayak, lifejacket, null };
        }
    }
}