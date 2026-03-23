
//Sale sale = new SaleWithTax(100.00m,10);
//var message = sale.GetInfo();

//Console.WriteLine(message);

//class SaleWithTax : Sale
//{
//    public decimal TaxRate { get; set; }
//    public SaleWithTax(decimal Total, decimal TaxRate) : base(Total)
//    {
//        this.TaxRate = TaxRate;
//    }
//    public override string GetInfo()
//    {
//        decimal totalWithTax = Total + (Total * TaxRate);
//        return $"The total of the sale with tax is {totalWithTax:C}";
//    }
//    public string GetInfo(string message) {
//        return message;
//    }
//    public string GetInfo(string message,int id)
//    {
//        return message + id;
//    }
//}


//class Sale
//{
//    public decimal Total { get; set; }

//    public Sale( decimal Total)
//    {
//        this.Total = Total;
//    }
//    public virtual string GetInfo()
//    {
//        return $"The total of the sale is {Total:C}";
//    }
//} 

//var sale = new Sale(100);
//var beer = new Beer();

//Some(sale);
//Some(beer);

 
//void Some( ISave save)
//{
//    save.Save();
//}

//interface ISale
//{
//    decimal Total { get; set; }

//}
//interface ISave
//{
//    public void Save();
//}

//public class Sale : ISale, ISave
//{
//    public decimal Total { get; set; }
//    public Sale(decimal Total)
//    {
//        this.Total = Total;
//    }
//    public void Save()
//    {
//        Console.WriteLine("Sale saved");
//    }   
//}
//public class Beer : ISave
//{
//    public void Save()
//    {
//        Console.WriteLine("Beer saved");
//    }
//}


var myList = new MyList<string>(10);
var numbers = new MyList<int>(5);
var beers  = new MyList<Beer>(3);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);


beers.Add(new Beer { Name = "Corona", Price = 4.50m });
beers.Add(new Beer { Name = "Aguila", Price = 2.50m });
beers.Add(new Beer { Name = "Poker", Price = 3.50m });
beers.Add(new Beer { Name = "Budweiser", Price = 3.50m });

Console.WriteLine(numbers.GetContent());
Console.WriteLine(beers.GetContent());


public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }   
    public void Add(T item)
    {
        if (_list.Count < _limit)
        {
            _list.Add(item);
        }
        else
        {
            Console.WriteLine("Limit reached");
        }
    }
    public string GetContent()
    {
        return string.Join(", ", _list);
    }
}

public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Price:C})";
    }
}