

List<string> stringList = new List<string>
            { "Yasser Sanad", "Mo Sanad", "Mahmoud Sanad", "Ahmed Sanad", "Mo Saad" };


var names = stringList.Where(name => name.Contains("Sanad"));

foreach (var name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine();

stringList.Remove("Mahmoud Sanad");
stringList.AddRange(new string[] { "Noor Ahmed", "Nabila Sanad" });

foreach (var name in names)
{
    Console.WriteLine(name);
}

Console.ReadKey();