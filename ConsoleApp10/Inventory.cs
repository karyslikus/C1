namespace Program
{ 
    public class Inventory
        {
            private readonly List<Product> _products = new();
            public void AddProduct(Product product)
            {
                _products.Add(product);
                Console.WriteLine($"Добавлен товар: {product}");
            }
            public Product? FindProductById(int id)
            {
                return _products.Find(p => p.Id == id);
            }
        }
    }