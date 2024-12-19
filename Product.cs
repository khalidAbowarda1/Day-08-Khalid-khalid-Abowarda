namespace Day08
{
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(Product? other)
        {
            if (other == null) return 1;
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"{Name}: ${Price}";
        }
    }
}
