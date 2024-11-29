using System.Runtime.CompilerServices;
using Example;
using Select_Operation;

// Select => transformation function عمليه تحويل عناصر موجوده في ليستا الي شكل اخر بتباع

RunSelectWithConstructANewType();
Console.WriteLine();
RunSelectWithPerformMathematicalOperation();
Console.WriteLine();
RunSelectWithConstructANewType01();

Console.ReadKey();

static void RunSelectWithConstructANewType()
{
    // Construct a new type
    List<String> words = new() { "i", "love", "asp.net", "core" };

    // Method Syntax
    var result = words.Select(x => x.ToUpper());
    foreach (var word in result)
    {
        Console.WriteLine(word);
    }

    Console.WriteLine("*************");

    // Query Syntax
    var result01 = from w in words
                   select w.ToUpper();
    foreach (var word in result01)
    {
        Console.WriteLine(word);
    }
}

static void RunSelectWithPerformMathematicalOperation()
{
    List<int> numbers = new() { 1, 3, 5, 7 };

    // Method Syntax
    var result = numbers.Select(n => n * n);
    foreach (var number in result)
    {
        Console.WriteLine(number);
    }

    Console.WriteLine("*************");

    // Query Syntax
    var result01 = from n in numbers
                   select n * n;
    foreach (var number in result01)
    {
        Console.WriteLine(number);
    }
}

static void RunSelectWithConstructANewType01()
{
    // فيها كل الموظفين 
    var employees = Repository.LoadEmployees();


    // Method Syntax
    var result = employees.Select(x =>
    {
        return new EmployeeDto // Data Transfare Object
        {
            Name = $"{x.FirstName} {x.LastName}",
            totalSkills = x.Skills.Count()
        };
    });
    foreach (var emp in result)
    {
        Console.WriteLine(emp);
    }

    Console.WriteLine("*************");

    // Query Syntax
    var result01 = from emp in employees
                   select emp.FullName;
    foreach (var emp in result01)
    {
        Console.WriteLine(emp);
    }
}