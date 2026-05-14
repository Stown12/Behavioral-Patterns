namespace Behavioral_Patterns.Strategy;

public interface IDiscountStrategy
{
    Decimal Calculate(decimal price);
}

public class NoDiscount: IDiscountStrategy
{
    public decimal Calculate(decimal price) => price;
}

public class PercentageDiscount: IDiscountStrategy
{
    private int _percentage;
    public PercentageDiscount(int percentage)
    {
        _percentage = percentage;
    }
    
    public decimal Calculate(decimal price) => price - (price * _percentage / 100);
}

public class FixedDiscount: IDiscountStrategy
{
    private decimal _fixed;
    public FixedDiscount(decimal fixedDiscount)
    {
        _fixed = fixedDiscount;
    }
    
    public decimal Calculate(decimal price) => price - _fixed;
}