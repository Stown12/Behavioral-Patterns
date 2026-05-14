namespace Behavioral_Patterns.Visitor;

public interface IProductVisitor
{
    void VisitBook(Book book);
    void VisitElectronics(Electronics electronics);
}

public interface IProduct
{
    void Accept(IProductVisitor visitor);
}