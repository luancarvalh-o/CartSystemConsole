namespace ShoppingCart.Models;

public class Product
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    public Product(string name, decimal price)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Nome Inválido");

        if (price < 0)
            throw new ArgumentException("Preço não pode ser negativo");

        Name = name;
        Price = price;
    }

}
