namespace Behavioral_Patterns.Visitor;

public class Store
{
    private List<IProduct> _products = [];
    
    public void Add(IProduct product)
    {
        _products.Add(product);  
    }

    public void Accept(IProductVisitor visitor)
    {
        foreach (var product in _products)
        {
            product.Accept(visitor);
            
        }
    }
}

public class Book : IProduct
{
    public string _title { get; private set; }
    public decimal _price { get; private set; }

    public Book(string title, decimal price)
    {
        _title = title;
        _price = price;
    }
    
    public void Accept(IProductVisitor visitor)
    {
        visitor.VisitBook(this);
    }
}

public class Electronics: IProduct
{
    public string Title { get; private set; }
    public decimal Price { get; private set; }
    public int Warranty { get; private set; }

    public Electronics(string title, decimal price, int warranty)
    {
        Title = title;
        Price = price;
        Warranty = warranty;
    }
    
    public void Accept(IProductVisitor visitor)
    {
        visitor.VisitElectronics(this);
    }
}