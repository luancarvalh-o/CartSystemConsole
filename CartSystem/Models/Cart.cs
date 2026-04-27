

namespace ShoppingCart.Models;

public class Cart
{
    private List<ItemCart> items = new List<ItemCart>();
    
    public IReadOnlyList<ItemCart> Items => items;

    public void AddItem(Product product, int quantity)
    {
        var existingItem = items.FirstOrDefault(i => i.CartProduct.Name == product.Name);

        if(existingItem != null)
        existingItem.ChangeQuantity(existingItem.Quantity + quantity);
        else
        items.Add(new ItemCart(product, quantity));
    }

    public void RemoveItem(string name)
    {
        var item = items.FirstOrDefault(i => i.CartProduct.Name == name);
        if (item != null)
        items.Remove(item);
    }

    public decimal Total()
    {
        return items.Sum(i => i.Subtotal());
    }

    public bool IsEmpty()
    {
        return !items.Any();
    }
}