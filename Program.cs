using Behavioral_Patterns.State;
using Behavioral_Patterns.Strategy;
using Behavioral_Patterns.Template_Method;

public class Program
{
    public static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart(150.00m);

        cart.SetDiscount(new NoDiscount());
        Console.WriteLine($"No discount: ${cart.GetTotal()}");

        cart.SetDiscount(new PercentageDiscount(10)); // 10% off
        Console.WriteLine($"10% off: ${cart.GetTotal()}");

        cart.SetDiscount(new FixedDiscount(20)); // $20 off
        Console.WriteLine($"$20 off: ${cart.GetTotal()}");
    }
}