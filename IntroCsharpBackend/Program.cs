
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


//var myList = new MyList<string>(10);
//var numbers = new MyList<int>(5);
//var beers  = new MyList<Beer>(3);

//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);
//numbers.Add(5);
//numbers.Add(6);


//beers.Add(new Beer { Name = "Corona", Price = 4.50m });
//beers.Add(new Beer { Name = "Aguila", Price = 2.50m });
//beers.Add(new Beer { Name = "Poker", Price = 3.50m });
//beers.Add(new Beer { Name = "Budweiser", Price = 3.50m });

//Console.WriteLine(numbers.GetContent());
//Console.WriteLine(beers.GetContent());


//public class MyList<T>
//{
//    private List<T> _list;
//    private int _limit;

//    public MyList(int limit)
//    {
//        _limit = limit;
//        _list = new List<T>();
//    }   
//    public void Add(T item)
//    {
//        if (_list.Count < _limit)
//        {
//            _list.Add(item);
//        }
//        else
//        {
//            Console.WriteLine("Limit reached");
//        }
//    }
//    public string GetContent()
//    {
//        return string.Join(", ", _list);
//    }
//}

//public class Beer
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }

//    public override string ToString()
//    {
//        return $"{Name} ({Price:C})";
//    }
//}



//SERIALIZACION Y DESERIALIZACION

//using System.Text.Json;
//var hector = new People { Name = "Hector", Age = 30 };

//string json = JsonSerializer.Serialize(hector);
//Console.WriteLine(json);

//string MyJson = @"{
//    ""Name"":""Hector"",
//    ""Age"":30
//}
//";

//People? juan = JsonSerializer.Deserialize<People>(MyJson); 
//Console.WriteLine(juan?.Name);
//Console.WriteLine(juan?.Age);
//public class People
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//FUNCIONES PURAS

//int Sub(int a, int b)
//{
//    return a + b;
//}
//DateTime GetCurrentDate()
//{
//    return DateTime.Now;
//}

//Console.WriteLine(GetCurrentDate());


//var beer1 = new Beer { Name = "Corona" };

//Beer ToUpper(Beer beer1)
//{
//    var beer2 = new Beer { Name =
//            beer1.Name.ToUpper() };
//    return beer2;
//}

//Console.WriteLine(beer1.Name);
//Console.WriteLine(ToUpper(beer1).Name);
//class Beer
//{
//    public string Name { get; set; }
//}

//var show = Show2;
//Someday(show, "algun dia");

//void Show()
//{
//    Console.WriteLine("Hello World"); 
//}
//string Show2(string message)
//{
//    return message;
//}
//show("hola");

//void Some (Action<string> action, string message)
//{
//    action("Hello from Some");
//    Console.WriteLine(message);
//}

//void Someday(Func<string, string> fn,string message)
//{
//    Console.WriteLine("Hello from Some");
//    Console.WriteLine(fn(message));
//}

//LAMBDA EXPRESSIONS


