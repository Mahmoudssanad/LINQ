

List<string> stringList = new List<string>
            { "Yasser Sanad", "Mo Sanad", "Mahmoud Sanad", "Ahmed Sanad", "Mo Saad" };


// iteration غير لما اعمل عليه execution دا مش هيحصله query ال 
// .ToList, .ToArray, .ToDictionary and so on .... زي casting بأحد دوال ال casting او اعمله  
// var names = stringList.Where(name => name.Contains("Sanad"));

var names = stringList.Where(name => name.Contains("Sanad")).ToList();
// ومش هيشوف الا انا ضيفته او حذفته لانه اتنفذ خلاص ,iteration علطول مستناش ال query نفذ ال casting لما عملتله 

foreach (var name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine();

stringList.Remove("Mahmoud Sanad");
stringList.AddRange(new string[] { "Noor Ahmed", "Nabila Sanad" });

foreach (var name in names)
{
    // AddRange وال Remove فهو نفذ اصلا فمش هيشوف ال casting الا فوق لان انا عملت iteration هيطلع نفس ال 
    Console.WriteLine(name);
}

Console.ReadKey();