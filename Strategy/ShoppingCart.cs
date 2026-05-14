namespace Behavioral_Patterns.Strategy;

public class ShoppingCart
{
    private IDiscountStrategy _discountStrategy;
    private decimal _amount;
    
    public ShoppingCart(decimal amount)
    {
        _amount = amount;
    }
    
    public decimal GetTotal() => _discountStrategy.Calcultate(_amount);
    public void SetDiscount(IDiscountStrategy discountStrategy) => _discountStrategy = discountStrategy;
}