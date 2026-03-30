
// // // Supplier supplier1 = new Supplier("widgets inc.", "contact@widgets.com");
// // // Console.WriteLine(supplier1.GetInfo());
// // // ContactSupplier supplier2 = new ContactSupplier("gadgets inc.", "John Doe", "contact@gadgets.com", "john.doe@gadgets.com");
// // // Console.WriteLine(supplier2.GetInfo());

// // // class ContactSupplier : Supplier
// // // {
// // //     public string ContactName { get; set; }
// // //     public string ContactEmail   { get; set; }

// // //         public ContactSupplier( string name ,string ContactName, string email, string ContactEmail) : base(name, email)   

// // //         {
// // //             this.Name = name;
// // //             this.Email = email;
// // //             this.ContactEmail = ContactEmail;    
// // //             this.ContactName = ContactName;
// // //         }
// // //         public override string GetInfo()
// // //         {
// // //             return $"The supplier {Name} can be contaactedasd at {ContactEmail}";
// // //         }
    
// // // }



// // // public class Supplier
// // // {    public string Name { get; set; }
// // //     public string Email { get; set; }

// // //         public Supplier(string name, string email   )
// // //         {
// // //             this.Name = name;
// // //             this.Email = email;
// // //         }
// // //     public virtual string GetInfo()
// // //     {
// // //         return $"The supplier {Name} can be contacted at {Email}";
// // //     }     
// // // }

// // // interface IContactable
// // // {
// // //  decimal numberContact { get; set; }
// // // }

// // // interface ISave
// // // {
// // //     void Save();
// // // }

// // // public class Supplier : IContactable, ISave
// // // {    public string Name { get; set; }
// // //     public string Email { get; set; }
// // //     public decimal numberContact { get; set; }

// // //         public Supplier(string name, string email   )
// // //         {
// // //             this.Name = name;
// // //             this.Email = email;
// // //         }
// // //     public virtual string GetInfo()
// // //     {
// // //         return $"The supplier {Name} can be contacted at {Email}";
// // //     }     
// // //     public void Save(){
// // //         Console.WriteLine("Saving supplier...");
// // //    }


// // // }



// // //GENERICS

// // var numbers = new MyList<int>(5);
// // numbers.Add(1);
// // numbers.Add(2);
// // numbers.Add(3);
// // numbers.Add(4);
// // numbers.Add(5); 
// // numbers.Add(6); // This will trigger the limit message


// // Console.WriteLine(numbers.GetInfo());
// // Console.WriteLine(numbers.GetContent());
// // public class MyList<T>
// // {
// //     private List<T> _list;
// //     private int _limit;
    
    
// //     public MyList(int limit)
// //     {
// //         _list = new List<T>();
// //         _limit = limit;
// //     }

// //     public void Add(T item)
// //     {
// //         if(_list.Count < _limit)
// //         {
// //             _list.Add(item);
// //         }
// //         else
// //         {
// //             Console.WriteLine("List limit reached. Cannot add more items.");
// //         }
// //     }

// //      public void PrintAll()
// //     {
// //         foreach(var item in _list)
// //         {
// //             Console.WriteLine(item);
// //         }
// //     }

// //     public string GetInfo()
// //     {
// //         return $"This is a list of type {typeof(T).Name} with {_list.Count} items.";
// //     }

// //     public string GetContent(){
// //         return string.Join(", ", _list);
// //     }
// // }


// using System.Text.Json;
// var william = new People("William", 30);
// Console.WriteLine($"Name: {william.Name}, Age: {william.Age}");



// string json = JsonSerializer.Serialize(william);
// Console.WriteLine($"Serialized JSON: {json}");

// string MyJson = @"{""Name"":""William"",""Age"":30}";
// People ? deserializedWilliam = JsonSerializer.Deserialize<People>(MyJson); 

// Console.WriteLine($"Deserialized Name: {deserializedWilliam?.Name}, Deserialized Age: {deserializedWilliam?.Age}");   

// Console.WriteLine($"Deserialized JSON: {MyJson?.ToString()}");

// public class People{
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public People(string name, int age)
//     {
//         this.Name = name;
//         this.Age = age;
//     }
// }

// //PROGRAMACION FUNCIONAL

