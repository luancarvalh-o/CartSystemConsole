using ShoppingCart.Models;

namespace ShoppingCart.Data;

public static class Data
{
    public static List<Product> Products = new List<Product>
    {
        new Product("Mouse", 80),
        new Product("Teclado", 150),
        new Product("Monitor", 900)
    };
}