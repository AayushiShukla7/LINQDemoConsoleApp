using LINQDemoConsole;
using System.Security.Cryptography;
using System.Linq;
using System.Runtime.CompilerServices;

//List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

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

#region Where
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

#endregion

#region OfType

/* OFTYPE (Generic Method) */

//var dataSource = new List<object>() { "Adam", "Harry", "Kim", "John", 1, 2, 3, 4, 5 };

//var methodSyntax_AllStrings = dataSource.OfType<string>().ToList();
//var methodSyntax_AllIntegers = dataSource.OfType<int>().ToList();

//var querySyntax_AllStrings = (from x in dataSource
//                   where x is string
//                   select x).ToList();

//var querySyntax_AllIntegers = (from x in dataSource
//                              where x is int
//                              select x).ToList();

//var methodSyntax_StrWithCond = dataSource.OfType<string>().Where(x => x.Length > 3).ToList();

#endregion

#endregion

#region Sorting

#region Order By - [Default = ASCENDING]

////Example #1 - Order By on List<int>
//var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

//var querySyntax = (from num in dataSourceInt
//                   orderby num
//                   select num).ToList();

//var methodSyntax = dataSourceInt.OrderBy(x => x).ToList();

//var querySyntax_WithCond = (from num in dataSourceInt
//                            where num > 10
//                            orderby num
//                            select num).ToList();

//var methodSyntax_WithCond = dataSourceInt.Where(x => x > 10).OrderBy(x => x).ToList();

////Example #2 - Order By on List<String>
//var dataSourceString = new List<string>()
//{
//    "Smith",
//    "Anderson",
//    "Wright",
//    "Michelle",
//    "Thomas",
//    "Allen",
//    "Evans",
//    "Collins"
//};

//var querySyntax = (from name in dataSourceString
//                   orderby name
//                   select name).ToList();

//var querySyntax_WithCond = (from name in dataSourceString
//                            where name.Length > 6
//                            orderby name
//                            select name).ToList();

//foreach (var item in querySyntax_WithCond)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("--------------------");

//var methodSyntax = dataSourceString.OrderBy(str => str).ToList();

//var methodSyntax_WithCond = dataSourceString.Where(name => name.Length > 6).OrderBy(str => str).ToList();

//foreach (var item in methodSyntax_WithCond)
//{
//    Console.WriteLine(item);
//}

////Example #3 - Order By on Object
//var dataSourceString = new List<Employee>()
//{
//    new Employee()
//    {
//        Id =3,
//        Email="Smith@email.com",
//        Name="Smith"
//    },
//    new Employee()
//    {
//        Id =2,
//        Email="Thomas@email.com",
//        Name="Thomas"
//    },
//    new Employee()
//    {
//        Id =1,
//        Email="Allen@email.com",
//        Name="Allen"
//    },
//    new Employee()
//    {
//        Id =4,
//        Email="Anderson@email.com",
//        Name="Anderson"
//    }
//};

//var querySyntax = (from emp in dataSourceString
//                   orderby emp.Id
//                   select emp).ToList();

//var querySyntax_WithCond = (from emp in dataSourceString
//                            where emp.Id > 2
//                            orderby emp.Name
//                            select emp).ToList();

//foreach (var item in querySyntax_WithCond)
//{
//    //Console.WriteLine(item.Id + " : " + item.Name + " : " + item.Email);
//    Console.WriteLine($"{item.Id} : {item.Name} : {item.Email}");
//}

//Console.WriteLine("--------------------");

//var methodSyntax = dataSourceString.OrderBy(emp => emp.Name).ToList();

//var methodSyntax_WithCond = dataSourceString.Where(emp => emp.Id > 2).OrderBy(emp => emp.Name).ToList();

//foreach (var item in methodSyntax_WithCond)
//{
//    Console.WriteLine($"{item.Id} : {item.Name} : {item.Email}");
//}

#endregion

#region Order By - Descending

////Example #1 - Order By on List<int>
//var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

//var querySyntax = (from num in dataSourceInt
//                   orderby num descending
//                   select num).ToList();

//var methodSyntax = dataSourceInt.OrderByDescending(x => x).ToList();

//var querySyntax_WithCond = (from num in dataSourceInt
//                            where num > 10
//                            orderby num descending
//                            select num).ToList();

//foreach (var item in querySyntax)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("--------------------");

//var methodSyntax_WithCond = dataSourceInt.Where(x => x > 10).OrderByDescending(x => x).ToList();

//foreach (var item in methodSyntax_WithCond)
//{
//    Console.WriteLine(item);
//}

////Example #2 - Order By on List<String>
//var dataSourceString = new List<string>()
//{
//    "Smith",
//    "Anderson",
//    "Wright",
//    "Michelle",
//    "Thomas",
//    "Allen",
//    "Evans",
//    "Collins"
//};

//var querySyntax = (from name in dataSourceString
//                   orderby name descending
//                   select name).ToList();

//var querySyntax_WithCond = (from name in dataSourceString
//                            where name.Length > 6
//                            orderby name descending
//                            select name).ToList();

//foreach (var item in querySyntax_WithCond)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("--------------------");

//var methodSyntax = dataSourceString.OrderByDescending(str => str).ToList();

//var methodSyntax_WithCond = dataSourceString.Where(name => name.Length > 6).OrderByDescending(str => str).ToList();

//foreach (var item in methodSyntax_WithCond)
//{
//    Console.WriteLine(item);
//}

////Example #3 - Order By on Object
//var dataSourceString = new List<Employee>()
//{
//    new Employee()
//    {
//        Id =3,
//        Email="Smith@email.com",
//        Name="Smith"
//    },
//    new Employee()
//    {
//        Id =2,
//        Email="Thomas@email.com",
//        Name="Thomas"
//    },
//    new Employee()
//    {
//        Id =1,
//        Email="Allen@email.com",
//        Name="Allen"
//    },
//    new Employee()
//    {
//        Id =4,
//        Email="Anderson@email.com",
//        Name="Anderson"
//    }
//};

//var querySyntax = (from emp in dataSourceString
//                   orderby emp.Id descending
//                   select emp).ToList();

//var querySyntax_WithCond = (from emp in dataSourceString
//                            where emp.Id < 3
//                            orderby emp.Name descending
//                            select emp).ToList();

//foreach (var item in querySyntax_WithCond)
//{
//    Console.WriteLine($"{item.Id} : {item.Name} : {item.Email}");
//}

//Console.WriteLine("--------------------");

//var methodSyntax = dataSourceString.OrderByDescending(emp => emp.Name).ToList();

//var methodSyntax_WithCond = dataSourceString.Where(emp => emp.Id < 3).OrderByDescending(emp => emp.Name).ToList();

//foreach (var item in methodSyntax_WithCond)
//{
//    Console.WriteLine($"{item.Id} : {item.Name} : {item.Email}");
//}

#endregion

#region Then By - [Default = ASCENDING] & Then By - Descending

//Subsequent sorting (based on any number of properties) - SORTING IN LEVELS

//var dataSourceString = new List<Employee>()
//{
//    new Employee()
//    {
//        Id =3,
//        Email="Smith@email.com",
//        FirstName="Smith",
//        LastName="Foo"
//    },
//    new Employee()
//    {
//        Id =2,
//        Email="Thomas@email.com",
//        FirstName="Thomas",
//        LastName="Mark"
//    },
//    new Employee()
//    {
//        Id =1,
//        Email="Allen@email.com",
//        FirstName="Allen",
//        LastName="Mark"
//    },
//    new Employee()
//    {
//        Id =4,
//        Email="Anderson@email.com",
//        FirstName="Anderson",
//        LastName="Foo"
//    }
//};

//var querySyntax = (from emp in dataSourceString
//                   orderby emp.FirstName descending, emp.LastName
//                   select emp).ToList();

////THEN BY - Descending
//var querySyntax_WithCond = (from emp in dataSourceString
//                            where emp.Id > 2
//                            orderby emp.FirstName descending,               emp.LastName descending
//                            select emp).ToList();

//foreach (var item in querySyntax_WithCond)
//{
//    Console.WriteLine($"{item.Id} : {item.FirstName} : {item.LastName} : {item.Email}");
//}

//Console.WriteLine("--------------------");

//var methodSyntax = dataSourceString.OrderBy(emp => emp.FirstName).ThenBy(emp => emp.LastName).ToList();

////THEN BY - Descending
//var methodSyntax_WithCond = dataSourceString.Where(emp => emp.Id > 2).OrderBy(emp => emp.FirstName).ThenBy(emp => emp.LastName).ThenByDescending(emp => emp.Id).ToList();

//foreach (var item in methodSyntax_WithCond)
//{
//    Console.WriteLine($"{item.Id} : {item.FirstName} : {item.LastName} : {item.Email}");
//}

#endregion

#region Reverse

//Available under 2 namespces: System.Linq (Non-Generic) and System.Collections.Generic (For Generic)
//No permanent changes are made to the data source, just the output is affected.

////Example #1 - Order By on integer array
//var rollNums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//var querySyntax = (from num in rollNums
//                   select num).Reverse();

//var methodSyntax = rollNums.Reverse();


//foreach (var item in querySyntax)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("--------------------");

////Example #2 - Order By on List<String>
//var names = new List<string>()
//{
//    "Smith",
//    "Anderson",
//    "Wright",
//    "Michelle",
//    "Thomas",
//    "Allen",
//    "Evans",
//    "Collins"
//};

//var querySyntax = (from name in names
//                   select name).Reverse();

//foreach (var item in querySyntax)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("--------------------");

//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("--------------------");

////var methodSyntax = names.Reverse();  //This throws an error! User the one from Syetm.Collections.Generic (no return needed)
//names.Reverse();    //Generic way of reversing

//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("--------------------");

//var reversed_Enumerable = names.AsEnumerable().Reverse();  //OR, we could use this syntax [System.Linq Reverse() expect an object of Ienumerable/IQueryable type]
//var reversed_Queryable = names.AsQueryable().Reverse();

//foreach (var item in reversed_Enumerable)
//{
//    Console.WriteLine(item);
//}

#endregion

#endregion

#region Quantifier Operations

// All, Any and Contains [Returns Boolean]

#region All - All the elements of the data source must justify the condition

//Student[] students =
//{
//    new Student { Name="Kim", Marks=90,
//        Subject = new List<Subject>() {
//        new Subject() { SubjectName="Math", SubjectMarks=75 },
//        new Subject() { SubjectName="English", SubjectMarks=80 },
//        new Subject() { SubjectName="Art", SubjectMarks=86 },
//        new Subject() { SubjectName="History", SubjectMarks=91 }
//    }},
//    new Student { Name="John", Marks=80,
//        Subject = new List<Subject>() {
//        new Subject() { SubjectName="Math", SubjectMarks=89 },
//        new Subject() { SubjectName="English", SubjectMarks=91 },
//        new Subject() { SubjectName="Art", SubjectMarks=90 },
//        new Subject() { SubjectName="History", SubjectMarks=91 }
//    }},
//    new Student { Name="Lee", Marks=75,
//        Subject = new List<Subject>() {
//        new Subject() { SubjectName="Math", SubjectMarks=75 },
//        new Subject() { SubjectName="English", SubjectMarks=80 },
//        new Subject() { SubjectName="Art", SubjectMarks=60 },
//        new Subject() { SubjectName="History", SubjectMarks=91 }
//    }}
//};

////Basic Examples
//var query = students.All(stu => stu.Marks > 70);    //True
//var query1 = students.All(stu => stu.Marks > 75);   //False

//var query3 = (from student in students
//              select student).All(x => x.Marks > 70);   //True

////Complex example
//var method_syntax = students.Where(std => std.Subject.All(x => x.SubjectMarks > 70)).Select(std => std).ToList();

//var query_syntax = (from std in students
//                    where std.Subject.All(x => x.SubjectMarks > 70)
//                    select std).ToList();

#endregion
#region Any - At least one of the elements of the data source must justify the condition

//List<int> numbers = new List<int>();

//var isAvailable = numbers.Any();    //False

//Student[] students =
//{
//    new Student { Name = "Kim", Marks = 91 },
//    new Student { Name = "John", Marks = 80 },
//    new Student { Name = "Lee", Marks = 75 }
//};

////Basic examples
//var method_syntax = students.Any(stu => stu.Marks > 90);    //True
//var method_syntax1 = students.Any(stu => stu.Marks > 91);   //False

//var query_syntax = (from stu in students
//                    select stu).Any(x => x.Marks > 90);

////Complex example
//Student[] students =
//{
//    new Student { Name="Kim", Marks=90,
//        Subject = new List<Subject>() {
//        new Subject() { SubjectName="Math", SubjectMarks=75 },
//        new Subject() { SubjectName="English", SubjectMarks=80 },
//        new Subject() { SubjectName="Art", SubjectMarks=86 },
//        new Subject() { SubjectName="History", SubjectMarks=91 }
//    }},
//    new Student { Name="John", Marks=80,
//        Subject = new List<Subject>() {
//        new Subject() { SubjectName="Math", SubjectMarks=89 },
//        new Subject() { SubjectName="English", SubjectMarks=91 },
//        new Subject() { SubjectName="Art", SubjectMarks=90 },
//        new Subject() { SubjectName="History", SubjectMarks=93 }
//    }},
//    new Student { Name="Lee", Marks=75,
//        Subject = new List<Subject>() {
//        new Subject() { SubjectName="Math", SubjectMarks=75 },
//        new Subject() { SubjectName="English", SubjectMarks=80 },
//        new Subject() { SubjectName="Art", SubjectMarks=60 },
//        new Subject() { SubjectName="History", SubjectMarks=91 }
//    }}
//};

//var method_syntax = students.Where(std => std.Subject.Any(x => x.SubjectMarks > 91)).Select(std => std).ToList();

//var query_syntax = (from stu in students
//                    where stu.Subject.Any(x => x.SubjectMarks > 91)
//                    select stu).ToList();

#endregion
#region Contains - IEqualityComparer(Intro)

////Simple Examples
//List<string> students = new List<string>() { "Kim", "Jacob", "Simon", "John" };

//var isExist_Generic = students.Contains("Kim"); //True
//var isExist_Linq = students.AsEnumerable().Contains("Test");    //False

//var isExist_Query = (from std in students
//                     select std).Contains("Kim");

////Complex Examples
//List<Student> students = new List<Student>()
//{
//    new Student() { Id = 1, Name = "Kim" },
//    new Student() { Id = 2, Name = "John" }
//};

//var isExist_Method = students.Contains(new Student() { Id = 1, Name = "Kim" }); //Should be True but actually is False!! Why? - Because NO 2 references of the same type are the SAME

////But this works fine
//var std = new Student() { Id = 1, Name = "Kim" };
//students.Add(std);

//var isExist_Method1 = students.Contains(std);    //True now! Because the same reference is added and checked.

//// CASE - DIFFERENT REFERENCES BUT SAME VALUES.
//// SOLUTION - IEqualityComparer
//var comparer = new StudentComparer();

//var isExist_method = students.Contains(new Student() { Id = 1, Name = "Kim" }, comparer);  //True this time! Why? - Because of comparer

//var isExist_query = (from student in students
//                     select student).Contains(new Student() { Id = 1, Name = "Kim" }, comparer);    //True

#endregion

#endregion

#region Set Operations

// Distinct, Except, Intersect and Union

#region Distinct - Removes duplicate values from data source

//// Basic Example
//List<int> numbers = new List<int>() { 1, 2, 3, 1, 2, 3, 4, 5, 5, 5 };

//var ms = numbers.Distinct().ToList();
//var qs = (from num in numbers
//          select num).Distinct().ToList();

//// Complex Example
//List<Student> students = new List<Student>()
//{
//    new Student() { Id = 1, Name = "Kim" },
//    new Student() { Id = 2, Name = "John" },
//    new Student() { Id = 1, Name = "Kim" },
//    new Student() { Id = 4, Name = "John" }
//};

//// Before implementing IEquatable<T> interface => 4 records
//// After implementing IEquatable<T> interface => 3 records (only unique objects)
//var ms_notWorkingBecauseRef = students.Distinct().ToList();

//var ms = students.Select(x => x.Name).Distinct().ToList();

//var ms_Comparer = students.Distinct(new StudentComparer()).ToList();

#endregion

#region Except - Returns all the elements from one data source that do not exist in second data source

////Simple Example - With List<string>
//List<string> dataSource1 = new List<string>() { "A", "B", "C", "D" };
//List<string> dataSource2 = new List<string>() { "C", "D", "E", "F" };

//var ms = dataSource1.Except(dataSource2).ToList();

//// Complex Example
//List<Student> students = new List<Student>()
//{
//    new Student() { Id = 1, Name = "Kim" },
//    new Student() { Id = 2, Name = "John" },
//    new Student() { Id = 3, Name = "Kim" },
//    new Student() { Id = 4, Name = "Jill" },
//    //new Student() { Id = 5, Name = "Mark" }
//};

//List<Student> students1 = new List<Student>()
//{
//    new Student() { Id = 1, Name = "Kim" },
//    new Student() { Id = 2, Name = "John" },
//    new Student() { Id = 5, Name = "Kim" },
//    new Student() { Id = 6, Name = "Jill" }
//};

//// Comparing one property of each of the objects
//var ms = students.Select(x => x.Name).Except(students1.Select(x => x.Name)).ToList();

//// Comparing the whole object - WORKS only with IEquatable<Student> implementation present!
//var ms_WithComparerImpl = students.Except(students1).ToList();

//// Using Anonymous Method
//var ms_fixed = students.Select(x => new { x.Id, x.Name }).Except(students1.Select(x => new { x.Id, x.Name })).ToList();

//var qs = (from std in students
//          select std).Except(students1, new StudentComparer()).ToList();

#endregion
#region Intersect - Returns all the elements which exist in both the data source

////Simple Example
//List<string> dataSource1 = new List<string>() { "A", "B", "C", "D" };
//List<string> dataSource2 = new List<string>() { "C", "D", "E", "F" };

//var ms = dataSource1.Intersect(dataSource2).ToList();
//var qs = (from data in dataSource1
//          select data).Intersect(dataSource2).ToList();

//// Complex Example
//List<Student> students = new List<Student>()
//{
//    new Student() { Id = 1, Name = "Kim" },
//    new Student() { Id = 2, Name = "John" },
//    new Student() { Id = 3, Name = "Kim" },
//    new Student() { Id = 4, Name = "Jill" }
//};

//List<Student> students1 = new List<Student>()
//{
//    new Student() { Id = 1, Name = "Kim" },
//    new Student() { Id = 2, Name = "John" },
//    new Student() { Id = 5, Name = "Kim" },
//    new Student() { Id = 6, Name = "Jill" }
//};

//// Comparing one property of each of the objects (Ignores duplicates)
//var ms = students.Select(x => x.Name).Intersect(students1.Select(x => x.Name)).ToList();

//// Comparing the whole object - WORKS only with IEquatable<Student> implementation present!
//var ms_WithComparerImpl = students.Intersect(students1).ToList();

//// NO IEquatable<Student> Scenario: #1 - Using Anonymous Method
//var ms_fixed = students.Select(x => new { x.Id, x.Name }).Intersect(students1.Select(x => new { x.Id, x.Name })).ToList();

//// NO IEquatable<Student> Scenario: #2 - Using Custom Comparer
//var qs = (from std in students
//          select std).Intersect(students1, new StudentComparer()).ToList();

#endregion
#region Union - Returns all the elements that appear in either of two data sources [Ignores Duplicates]

////Simple Example
//List<string> dataSource1 = new List<string>() { "A", "B", "C", "D" };
//List<string> dataSource2 = new List<string>() { "C", "D", "E", "F" };

//var ms = dataSource1.Union(dataSource2).ToList();
//var qs = (from data in dataSource1
//          select data).Union(dataSource2).ToList();

// Complex Example
List<Student> students = new List<Student>()
{
    new Student() { Id = 1, Name = "Kim" },
    new Student() { Id = 2, Name = "John" },
    new Student() { Id = 3, Name = "Kim" },
    new Student() { Id = 4, Name = "Jill" }
};

List<Student> students1 = new List<Student>()
{
    new Student() { Id = 1, Name = "Kim" },
    new Student() { Id = 2, Name = "John" },
    new Student() { Id = 5, Name = "Kim" },
    new Student() { Id = 6, Name = "Jill" }
};

// Comparing one property of each of the objects (Ignores duplicates)
var ms = students.Select(x => x.Name).Union(students1.Select(x => x.Name)).ToList();

// Comparing the whole object - WORKS only with IEquatable<Student> implementation present!
var ms_WithComparerImpl = students.Union(students1).ToList();

// NO IEquatable<Student> Scenario: #1 - Using Anonymous Method
var ms_fixed = students.Select(x => new { x.Id, x.Name }).Union(students1.Select(x => new { x.Id, x.Name })).ToList();

// NO IEquatable<Student> Scenario: #2 - Using Custom Comparer
var qs = (from std in students
          select std).Union(students1, new StudentComparer()).ToList();

Console.ReadLine();

#endregion

#endregion

#region Partitioning Operations

// Take, TakeWhile, Skip and SkipWhile



#endregion

#region Join Operations

// Inner Join, Group Join and Left Join



#endregion

#region Element Operations

// ElementAt(), ElementAtOrDefault(), First(), FirstOrDefault(), Last(), LastOrDefault(), Single() and SingleOrDefault()



#endregion

#endregion

Console.ReadLine();