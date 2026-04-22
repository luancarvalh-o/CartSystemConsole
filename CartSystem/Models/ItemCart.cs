namespace ShoppingCart.Models;

public class ItemCart
{
    public Product CartProduct { get; private set; }
    public int Quantity { get; private set; }

    public ItemCart(Product cartproduct, int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentException("Quantidade Inválida!");

        CartProduct = cartproduct;
        Quantity = quantity;
    }

    public void ChangeQuantity(int quantity)
    {

        if (quantity <= 0)
            throw new ArgumentException("Quantidade Inválida!");

        Quantity = quantity;
    }

    public decimal Subtotal()
    {
        return CartProduct.Price * Quantity;
    }

}
