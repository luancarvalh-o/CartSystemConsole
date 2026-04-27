using ShoppingCart.Models;

namespace ShoppingCart.Services;

public class CartService
{
    private Cart cart = new Cart();

    public Cart GetCart()
    {
        return cart;
    }

    public void AddProduct(Product product, int quantity)
    {
        cart.AddItem(product, quantity);
    }

    public void RemoveProduct(string name)
    {
        cart.RemoveItem(name);
    }

    public decimal GetTotal()
    {
        return cart.Total();
    }
}