namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- Управление инвентарем ---");
            Inventory inventory = new Inventory();
            inventory.AddProduct(new Product(1, "Молоко", 80.50m));
            inventory.AddProduct(new Product(2, "Хлеб", 40.00m));
            inventory.AddProduct(new Product(3, "Сыр", 450.99m));
            Console.WriteLine("\n--- Поиск товара с ID 2 ---");
            Product? foundProduct = inventory.FindProductById(2);
            if (foundProduct != null)
            {
                Console.WriteLine($"Найден товар: {foundProduct}");
            }
            else
            {
                Console.WriteLine("Товар с ID 2 не найден.");
            }
            Console.WriteLine("\n--- Поиск товара с ID 99 ---");
            Product? notFoundProduct = inventory.FindProductById(99);
            if (notFoundProduct != null)
            {
                Console.WriteLine($"Найден товар: {notFoundProduct}");
            }
            else
            {
                Console.WriteLine("Товар с ID 99 не найден.");
            }
        }
    }
}