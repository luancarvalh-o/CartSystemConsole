namespace ShoppingCart.Services;

public class DiscountService
{
    public decimal ApplyDiscount(decimal total)
    {
        return total * 0.9m; // 10%
    }
}