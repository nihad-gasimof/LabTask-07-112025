
using LabTask071125;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


//        List<Student> students = new List<Student>
//        {
//            new Student { Name = "Nihad", Age = 19, score = 85 },
//            new Student { Name = "Aysel", Age = 22, score = 90 },
//            new Student { Name = "Murad", Age = 21, score = 78 },
//            new Student { Name = "Leman", Age = 23, score = 95 },
//            new Student { Name = "Rashad", Age = 20, score = 88 }
//        };

//        var result = students
//            .Where(s => s.Age > 20)          
//            .OrderByDescending(s => s.score)   
//            .Select(s => s.Name);


//foreach (var name in result)
//        {
//            Console.WriteLine(name);
//        }






//List<Product> products = new List<Product>
//{
//    new Product { Category = "Elektronika", Name = "Telefon", Price = 1200 },
//    new Product { Category = "Elektronika", Name = "Noutbuk", Price = 2200 },
//    new Product { Category = "Mebel", Name = "Stol", Price = 300 },
//    new Product { Category = "Mebel", Name = "Kreslo", Price = 250 },
//    new Product { Category = "Geyim", Name = "Köynək", Price = 50 },
//    new Product { Category = "Geyim", Name = "Cins", Price = 90 }
//};

//var groupedProducts = products
//    .GroupBy(p => p.Category); 

//foreach (var group in groupedProducts)
//{
//    Console.WriteLine($"Kateqoriya: {group.Key}");

//    foreach (var product in group)
//    {
//        Console.WriteLine($"   {product.Name} - {product.Price} AZN");
//    }


//}



//List<Worker> workers = new List<Worker>
//{
//    new Worker {Department="Sagliq",Salary=300},
//    new Worker {Department="Sagliq",Salary=3600},
//    new Worker {Department="Bilinmir",Salary=400},
//    new Worker {Department="Bilinmir",Salary=700},
//    new Worker {Department="Maas",Salary=500},
//    new Worker {Department="Maas",Salary=1500}
//};
//var workersgroup = workers
//    .GroupBy(x => x.Department)
//    .Select(w => new
//    {
//        Department = w.Key,
//        AvarageSalary=w.Average(x => x.Salary),
//    });

//Console.WriteLine(" maaşlar:");
//foreach (var dept in workersgroup)
//{
//    Console.WriteLine($"{dept.Department} sobesi → orta maaş: {dept.AvarageSalary} AZN");
//}


//List<Book> books = new List<Book>();

//if (File.Exists("book.json"))
//{
//    string jsonFromFile = File.ReadAllText("book.json");
//    books = JsonConvert.DeserializeObject<List<Book>>(jsonFromFile);
//    Console.WriteLine("Fayl oxundu");
//}

//foreach (var book in books)
//{
//    Console.WriteLine(book.Name); 
//}
//Book book1 = new Book
//{
//    Name = "Dadada",
//    Price = 40
//};
//Book book2 = new Book
//{
//    Name = "Dadada1",
//    Price = 40
//};
//books.Add(book1);
//books.Add(book2);
//string jsonToFIle = JsonConvert.SerializeObject(books, Formatting.Indented);
//File.WriteAllText("book.json", jsonToFIle);
//Console.WriteLine("Fayl yazildi");

List<Student> students = new List<Student>
{
    //new Student { Name = "Nihad", Age = 19, score = 85 },
    //new Student { Name = "Aysel", Age = 22, score = 90 },
    //new Student { Name = "Murad", Age = 21, score = 78 },
    //new Student { Name = "Leman", Age = 23, score = 95 },
    //new Student { Name = "Rashad", Age = 20, score = 88 }
};

if (File.Exists("student.json"))
{
    string JsonFromFile = File.ReadAllText("student.json");
    students = JsonConvert.DeserializeObject<List<Student>>(JsonFromFile);
    Console.WriteLine("Fayl oxundu");

}
else
{
    Console.WriteLine("Fayl oxuna bilmedi");
    Console.WriteLine("Yeni fayl yaradildi");
}
foreach (var student in students)
{
    Console.WriteLine(student.Name);
}

Student student1 = new Student { Name = "Aysel", Age = 22, score = 90 };
Student student2=new Student { Name = "Murad", Age = 21, score = 78 };
Student student3 = new Student { Name = "Leman", Age = 23, score = 95 };
Student student4 = new Student { Name = "Rashad", Age = 20, score = 88 };
students.AddRange(student1,student2,student3,student4);
string JsonToFile=JsonConvert.SerializeObject(students);
File.WriteAllText("student.json", JsonToFile);




