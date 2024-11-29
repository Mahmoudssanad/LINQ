using Example;
using System.Collections.Generic;
using System.Collections.Immutable;

// Zip Operator => كأزواج مرتبه الاول مع الاول والتاني مع التاني وهكذا Two array بتعمل دمج ل
// زياده عن التانيه في عدد العناصر هنتجاهلهم array ولو في 


RunExample01();
RunExample02();

Console.ReadKey();

static void RunExample01()
{
    string[] colorName = { "Red", "Green", "Blue" };
    string[] colorHEX = { "FF0000", "00FF00", "0000FF", "extra" };

    var colors = colorName.Zip(colorHEX, (name, hex) => $"{name} ({hex})");

    foreach (var c in colors)
        Console.WriteLine(c);
}

static void RunExample02()
{
    var employees = Repository.LoadEmployees().ToArray();

    var fristThreeEmployee = employees[..3];
    var lastThreeEmployee = employees[^3..];

    // method syntax
    var teams = fristThreeEmployee.Zip(lastThreeEmployee, (frist, last) => 
    $"{frist.FullName} with {last.FullName}");

    // Query syntax => Query syntax مش ليها Zip بردك لان ال Zip استخدمت ال 
    var teams01 = from team in fristThreeEmployee.Zip(lastThreeEmployee)
                  select $"{team.First.FullName} with {team.Second.FullName}";
    // بكتب الشكل الا الرساله هتظهر بيه عادي select في ال 


    foreach (var team in teams)
        Console.WriteLine(team);

}