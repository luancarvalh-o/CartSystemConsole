using ShoppingCart.Data;
using ShoppingCart.Services;
using ShoppingCart.Models;

class Program
{
    static CartService cartService = new CartService();

    static void Main()
    {
        Menu();
    }

    static void Line()
    {
        Console.WriteLine("----------------------------");
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("1 - List Products");
        Console.WriteLine("2 - Add to Cart");
        Console.WriteLine("3 - View Cart");
        Console.WriteLine("4 - Remove Product");
        Console.WriteLine("5 - Checkout");
        Console.WriteLine("0 - Exit");

        var option = Console.ReadLine();

        switch (option)
        {
            case "1": ListProducts(); break;
            case "2": AddProduct(); break;
            case "3": ViewCart(); break;
            case "4": RemoveProduct(); break;
            case "5": Checkout(); break;
            case "0": return;
        }

        Console.ReadKey();
        Menu();  
    }

    static void ListProducts()
    {
        Line();

        foreach (var p in Data.Products)
        {
            Console.WriteLine($"{p.Name} - R${p.Price}");
        }

        Line();
    }

   static void AddProduct()
{
    Console.Write("Product name: ");
    var name = Console.ReadLine();

    Console.Write("Price: ");
    decimal price = decimal.Parse(Console.ReadLine());

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    var existingProduct = Data.Products.FirstOrDefault(p => p.Name == name);

    Product product;

    if (existingProduct != null)
    {
        product = existingProduct;
    }
    else
    {
        product = new Product(name, price);
        Data.Products.Add(product);
    }

    cartService.AddProduct(product, quantity);

    Console.WriteLine("Product added to cart!");
}

    static void ViewCart()
    {
        var cart = cartService.GetCart();

        if (cart.IsEmpty())
        {
            Console.WriteLine("Cart is empty.");
            return;
        }

        Line();

        foreach (var item in cart.Items)
        {
            Console.WriteLine($"{item.CartProduct.Name} x{item.Quantity} = R${item.Subtotal()}");
        }

        Console.WriteLine($"Total: R${cartService.GetTotal()}");

        Line();
    }

    static void RemoveProduct()
    {
        Console.Write("Product name: ");
        var name = Console.ReadLine();

        cartService.RemoveProduct(name);
    }

    static void Checkout()
    {
        var total = cartService.GetTotal();
        var discountService = new DiscountService();

        var finalTotal = discountService.ApplyDiscount(total);

        Line();
        Console.WriteLine($"Total with discount: R${finalTotal}");
        Line();
    }
}