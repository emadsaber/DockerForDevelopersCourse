namespace MyStore.Entities
{
    public class Product
    {
        public Product(int id, string name, string description, decimal price, int quantity, int categoryId)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            CategoryId = categoryId;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category{ get; set; }
    }
}
