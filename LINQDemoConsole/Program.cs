using LINQDemoConsole;
using System.Security.Cryptography;

List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

#region Query Syntax 

////Creating the Query Syntax
//var querySyntax = from obj in list
//                  where obj > 2
//                  select obj;

////Executing the Query Syntax
//foreach (var item in querySyntax)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("--------------------");

#endregion Query Syntax

#region Method Syntax

////Creating the Method Syntax
//var methodSyntax = list.Where(obj => obj > 2);

////Executing the Method Syntax
//foreach (var item in methodSyntax)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("--------------------");

#endregion Method Syntax

#region Mixed Syntax

////Creating the Method Syntax
//var mixedSyntax = (from obj
//                 in list
//                   select obj).Max();

////Returns maximum value from the list
//Console.WriteLine("Max value = " + mixedSyntax);

#endregion Mixed Syntax

#region Simple Example - IEnumerable 

//List<Employee> _employees = new List<Employee>()
//{
//    new Employee() { Id=1, Name="Tom" },
//    new Employee() { Id=2, Name="John" }
//};

//IEnumerable<Employee> query = from emp in _employees
//                              where emp.Id == 1
//                              select emp;

//#region Simple Example - IQueryable 

//IQueryable<Employee> query1 = _employees.AsQueryable().Where(x => x.Id == 1);

//#endregion

//foreach (var item in query1)
//{
//    Console.WriteLine("Id: " + item.Id + " and Name: " + item.Name);
//}

#endregion

#region Operators

#region Select in LINQ - Projection

//List<Employee> employees = new List<Employee>()
//{
//    new Employee() { Id=1, Name="Tom", Email="tom1@gmail.com" },
//    new Employee() { Id=2, Name="John", Email="john2@gmail.com" },
//    new Employee() { Id=3, Name="Mark", Email="mark3@gmail.com" },
//    new Employee() { Id=4, Name="Kim", Email="kim4@gmail.com" },
//    new Employee() { Id=5, Name="Adam", Email="adam5@gmail.com" }
//};

//var basicQuery = (from emp in employees
//                  select emp).ToList();

//var basicMethod = employees.ToList();

////Operations
//var basicPropQuery = (from emp in employees
//                      select emp.Id).ToList();

//var basicPropQueryWithOp1 = (from emp in employees
//                             select emp.Id + 1).ToList();

//var basicPropQueryWithOp2 = (from emp in employees
//                             select emp.Id.ToString()).ToList();

//var basicPropMethod = employees.Select(emp => emp.Id).ToList();

////Fetching selective fields
//var selectQuery = (from emp in employees
//                   select new Employee()
//                   {
//                       Id = emp.Id,
//                       Email = emp.Email
//                   }).ToList();

//foreach (var item in selectQuery)
//{
//    Console.WriteLine($"Id = {item.Id}, Name = {item.Name}, Email = {item.Email}");
//}

//var selectQuery1 = (from emp in employees
//                    select new Student()
//                    {
//                        StudentId = emp.Id,
//                        StudentFullName = emp.Name,
//                        StudentEmail = emp.Email
//                    }).ToList();

////Method Syntax
//var selectMethod = employees.Select(emp => new Student()
//{
//    StudentId = emp.Id,
//    StudentFullName = emp.Name,
//    StudentEmail = emp.Email
//}).ToList();

//foreach (var item in selectMethod)
//{
//    Console.WriteLine($"Id = {item.StudentId}, Name = {item.StudentFullName}, Email = {item.StudentEmail}");
//}

////Anonymous Syntax
//var anonymousQuery = (from emp in employees
//                      select new
//                      {
//                          CustomId = emp.Id,
//                          CustomName = emp.Name,
//                          CustomEmail = emp.Email
//                      }).ToList();

//var anonymousMethod = employees.Select(emp => new
//{
//    CustomId = emp.Id,
//    CustomName = emp.Name,
//    CustomEmail = emp.Email
//}).ToList();

//foreach (var item in anonymousMethod)
//{
//    Console.WriteLine($"Id = {item.CustomId}, Name = {item.CustomName}, Email = {item.CustomEmail}");
//}

////Select By Index
//var query = employees.Select((emp, index) => new { Index = index, FullName = emp.Name }).ToList();

//foreach (var item in query)
//{
//    Console.WriteLine($"Index = {item.Index}, FullName = {item.FullName}");
//}

#endregion

#region SelectMany in LINQ

//List<string> strList = new List<string>() { "Nitish", "Kaushik" };

//var methodResult = strList.SelectMany(x => x).ToList();

//var queryResult = (from rec in strList
//                  from ch in rec
//                  select ch).ToList();

//var dataSource = new List<Employee>()
//{
//    new Employee() { Id=1, Name="Tom", Email="tom123@gmail.com", Programming = new List<string>() {"C#", "PHP","JAVA"} },
//    new Employee() { Id=2, Name="Kim", Email="kim456@gmail.com", Programming = new List<string>() {"LINQ#", "C#", "MVC"} },
//    new Employee() { Id=3, Name="Harry", Email="harry789@gmail.com", Programming = new List<string>() {"LINQ", "VB","SQL"} }
//};

//var methodSyntax = dataSource.SelectMany(emp => emp.Programming).ToList();

//foreach(var item in methodSyntax)
//{
//    Console.WriteLine($"Programming - {item}");
//}

//var querySyntax = (from emp in dataSource
//                   from skill in emp.Programming
//                   select skill).ToList();

//foreach (var item in querySyntax)
//{
//    Console.WriteLine($"Programming - {item}");
//}

//var dataSource = new List<Employee>() { 
//    new Employee() { Id=1, Name="Tom", Email="tom123@gmail.com", Programming = new List<Techs>() {
//        new Techs() { Technology="C#"},
//        new Techs() { Technology="PHP"},
//        new Techs() { Technology=".Net"}
//    } },
//    new Employee() { Id=1, Name="John", Email="john845@gmail.com", Programming = new List<Techs>() {
//        new Techs() { Technology="C#"},
//        new Techs() { Technology="VB"},
//        new Techs() { Technology="SQL"}
//    } },
//    new Employee() { Id=1, Name="Mark", Email="mark99999@gmail.com", Programming = new List<Techs>() {
//        new Techs() { Technology="LINQ"},
//        new Techs() { Technology="MVC"},
//        new Techs() { Technology="C#"}
//    } },
//    new Employee() { Id=1, Name="Kim", Email="kim654@gmail.com", Programming = new List<Techs>() },
//    new Employee() { Id=1, Name="Adam", Email="adam985@gmail.com", Programming = new List<Techs>() }
//};

//var methodQuery = dataSource.SelectMany(emp => emp.Programming).ToList();

//var querySyntax = (from emp in dataSource
//                   from pro in emp.Programming
//                   select pro).ToList();

#endregion

#region Filtering - Where + Of Type

/* WHERE */

////Example #1
//var dataSource = list;

//var querySyntax = (from number in dataSource
//                   where number <= 5 || number > 9
//                   select number).ToList();

//var methodSyntax = dataSource.Where(num => num > 5).ToList();

////Example #2
//var dataSource = new List<string>() { "Tom", "Harry", "Adam", "Ponting", "Sachin" };

//var querySyntax = (from str in dataSource
//                   where str.Length == 3
//                   select str).ToList();

//var methodSyntax = dataSource.Where(str => str == "Tom" || str.Length > 4).ToList();

////Example #3
//var dataSource = new List<Employee>() {
//    new Employee() { Id=1, Name="Tom", Email="tom123@gmail.com", Programming = new List<Techs>() {
//        new Techs() { Technology="C#"},
//        new Techs() { Technology="PHP"},
//        new Techs() { Technology=".Net"},
//        new Techs() { Technology="MVC"},
//        new Techs() { Technology="SQL"}
//    } },
//    new Employee() { Id=2, Name="John", Email="john845@gmail.com", Programming = new List<Techs>() {
//        new Techs() { Technology="C#"},
//        new Techs() { Technology="VB"},
//        new Techs() { Technology="SQL"}
//    } },
//    new Employee() { Id=3, Name="Mark", Email="mark99999@gmail.com", Programming = new List<Techs>() {
//        new Techs() { Technology="LINQ"},
//        new Techs() { Technology="MVC"}
//    } },
//    new Employee() { Id=4, Name="Kim", Email="kim654@gmail.com", Programming = new List<Techs>() },
//    new Employee() { Id=5, Name="Adam", Email="adam985@gmail.com", Programming = new List<Techs>() }
//};

//var querySyntax = (from employee in dataSource
//                   where employee.Programming.Count == 0
//                   select employee).ToList();   //Employees with no programming skills

//var querySyntax1 = (from employee in dataSource
//                   where employee.Programming.Count == 2
//                   select employee).ToList();   //Employees with 2 programming skills

//var querySyntax2 = (from employee in dataSource
//                    where employee.Programming.Count == 2
//                    && employee.Id == 4
//                    select employee).ToList();   //No matching Employee --> Empty list returned

//var methodSyntax = dataSource.Where(employee => employee.Programming.Count > 3 || employee.Name == "Kim").ToList();

/* OF TYPE */



#endregion

#endregion

Console.ReadLine();