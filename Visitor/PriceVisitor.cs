namespace Behavioral_Patterns.Visitor;

public class PriceVisitor: IProductVisitor
{
    public decimal TotalPrice { get; set; }
    public void VisitBook(Book book)
    {
        TotalPrice += book.Price;
    }

    public void VisitElectronics(Electronics electronics)
    {
        TotalPrice += electronics.Price;
    }
    
    public decimal GetTotal() => TotalPrice;
}

public class ExportVisitor: IProductVisitor
{
    public void VisitBook(Book book)
    {
        Console.WriteLine($"[BOOK] {book.Title} - ${book.Price}");
    }

    public void VisitElectronics(Electronics electronics)
    {
        Console.WriteLine($"[ELECTRONICS] {electronics.Title} - ${electronics.Price} - Warranty: {electronics.Warranty} years");
    }
}