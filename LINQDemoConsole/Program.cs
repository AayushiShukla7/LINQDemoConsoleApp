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

List<Employee> employees = new List<Employee>()
{
    new Employee() { Id=1, Name="Tom", Email="tom1@gmail.com" },
    new Employee() { Id=2, Name="John", Email="john2@gmail.com" },
    new Employee() { Id=3, Name="Mark", Email="mark3@gmail.com" },
    new Employee() { Id=4, Name="Kim", Email="kim4@gmail.com" },
    new Employee() { Id=5, Name="Adam", Email="adam5@gmail.com" }
};

var basicQuery = (from emp in employees
                  select emp).ToList();

var basicMethod = employees.ToList();

//Operations
var basicPropQuery = (from emp in employees
                      select emp.Id).ToList();

var basicPropQueryWithOp1 = (from emp in employees
                             select emp.Id + 1).ToList();

var basicPropQueryWithOp2 = (from emp in employees
                             select emp.Id.ToString()).ToList();

var basicPropMethod = employees.Select(emp => emp.Id).ToList();

//Fetching selective fields
var selectQuery = (from emp in employees
                   select new Employee()
                   {
                       Id = emp.Id,
                       Email = emp.Email
                   }).ToList();

//foreach (var item in selectQuery)
//{
//    Console.WriteLine($"Id = {item.Id}, Name = {item.Name}, Email = {item.Email}");
//}

var selectQuery1 = (from emp in employees
                    select new Student()
                    {
                        StudentId = emp.Id,
                        StudentFullName = emp.Name,
                        StudentEmail = emp.Email
                    }).ToList();

//Method Syntax
var selectMethod = employees.Select(emp => new Student()
{
    StudentId = emp.Id,
    StudentFullName = emp.Name,
    StudentEmail = emp.Email
}).ToList();

//foreach (var item in selectMethod)
//{
//    Console.WriteLine($"Id = {item.StudentId}, Name = {item.StudentFullName}, Email = {item.StudentEmail}");
//}

//Anonymous Syntax
var anonymousQuery = (from emp in employees
                      select new
                      {
                          CustomId = emp.Id,
                          CustomName = emp.Name,
                          CustomEmail = emp.Email
                      }).ToList();

var anonymousMethod = employees.Select(emp => new
{
    CustomId = emp.Id,
    CustomName = emp.Name,
    CustomEmail = emp.Email
}).ToList();

//foreach (var item in anonymousMethod)
//{
//    Console.WriteLine($"Id = {item.CustomId}, Name = {item.CustomName}, Email = {item.CustomEmail}");
//}

//Select By Index
var query = employees.Select((emp, index) => new { Index = index, FullName = emp.Name }).ToList();

//foreach (var item in query)
//{
//    Console.WriteLine($"Index = {item.Index}, FullName = {item.FullName}");
//}

#endregion

#region SelectMany in LINQ



#endregion

#endregion

Console.ReadLine();