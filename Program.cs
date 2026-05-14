using Behavioral_Patterns.State;
using Behavioral_Patterns.Strategy;
using Behavioral_Patterns.Template_Method;
using Behavioral_Patterns.Visitor;

public class Program
{
    public static void Main(string[] args)
    {
        Store store = new Store();
        store.Add(new Book("Clean Code", 35.00m));
        store.Add(new Book("Design Patterns", 45.00m));
        store.Add(new Electronics("Laptop", 1200.00m, 2));

        PriceVisitor price = new PriceVisitor();
        store.Accept(price);
        Console.WriteLine($"Total: ${price.GetTotal()}");

        ExportVisitor export = new ExportVisitor();
        store.Accept(export);
    }
}